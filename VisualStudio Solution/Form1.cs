using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace fftPlot
{
    public partial class Form1 : Form
    {
        private int DataPoints = 32;
        private byte[] dataBuffer;
        private int dataIndex = 0;
        private String chartName = "Waiting";
        int rxBuffers = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea("Default"));
            chart1.Series.Add(chartName);
            chart1.Series[chartName].ChartType = SeriesChartType.Column;
            chart1.Series[chartName].XValueType = ChartValueType.Int32;
            chart1.ChartAreas["Default"].AxisX.Minimum = 0;       
            chart1.ChartAreas["Default"].AxisY.Minimum = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if((Convert.ToInt16(textBox_bufferSize.Text) > 0) && (Convert.ToDouble(textBox_hRes.Text) > 0) && (Convert.ToDouble(textBox_vRes.Text) > 0))
                {
                    if (!serialPort1.IsOpen)
                    {
                        button_comOpen.Text = "Close";
                        serialPort1.PortName = comboBox_availableSerialPorts.SelectedItem.ToString();
                        serialPort1.Open();
                        comboBox_availableSerialPorts.Enabled = false;
                        textBox_bufferSize.Enabled = false;
                        textBox_hRes.Enabled = false;
                        textBox_chartName.Enabled = false;
                        textBox_vRes.Enabled = false;

                        DataPoints = Convert.ToInt16(textBox_bufferSize.Text);
                        dataBuffer = new byte[DataPoints];
                        chart1.ChartAreas["Default"].AxisX.Maximum = Convert.ToDouble(textBox_hRes.Text) * DataPoints;
                        chart1.Series[chartName].Name = textBox_chartName.Text;
                        chartName = textBox_chartName.Text;
                    }
                    else
                    {
                        button_comOpen.Text = "Open";
                        serialPort1.Close();
                        comboBox_availableSerialPorts.Enabled = true;
                        textBox_bufferSize.Enabled = true;
                        textBox_hRes.Enabled = true;
                        textBox_chartName.Enabled = true;
                        textBox_vRes.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Configure parâmetros válidos para o gráfico!", "CFG Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }          
            }
            catch
            {
                MessageBox.Show("Falha ao abrir porta de comunicação!", "COM Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button_comOpen.Text = "Open";
            };
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (serialPort1.BytesToRead > 0)
            {
                int value = serialPort1.ReadByte();
                if (value == 0xFF)
                {
                    dataIndex = 0;
                }
                else
                {
                    if (dataIndex < DataPoints)
                    {
                        dataBuffer[dataIndex++] = (byte)value;
                    }
                    if (dataIndex == DataPoints)
                    {
                        UpdateChart(dataBuffer);
                        dataIndex = 0;
                    }
                }
            }
        }

        private void UpdateChart(byte[] data)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<byte[]>(UpdateChart), new object[] { data });
                return;
            }

            chart1.Series[chartName].Points.Clear();
            for (int i = 0; i < data.Length; i++)
            {
                chart1.Series[chartName].Points.AddXY(i * Convert.ToDouble(textBox_hRes.Text), data[i] * Convert.ToDouble(textBox_vRes.Text));
            }

            // Ajusta o limite do eixo Y, caso necessário
            //chart1.ChartAreas["Default"].AxisY.Maximum = Math.Max(255, data.Max() + 10);

            rxBuffers++;

            label_rxBuffers.Text = rxBuffers.ToString();
        }

        private void comboBox_availableSerialPorts_DropDown(object sender, EventArgs e)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            comboBox_availableSerialPorts.DataSource = null;

            comboBox_availableSerialPorts.Items.Clear();
            for (int cont = 0; cont < ports.Length; cont++)
                comboBox_availableSerialPorts.Items.Add(ports[cont]);

            if (comboBox_availableSerialPorts.Items.Count > 0)
                comboBox_availableSerialPorts.SelectedIndex = 0;

            comboBox_availableSerialPorts.DataSource = ports;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://programacaoeletronica.wordpress.com/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/programacao-eletronica/ProgElet_SerialViewer");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://programacaoeletronica.wordpress.com/");
        }
    }
}
