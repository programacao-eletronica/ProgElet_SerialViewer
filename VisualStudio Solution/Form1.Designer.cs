namespace fftPlot
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button_comOpen = new System.Windows.Forms.Button();
            this.comboBox_availableSerialPorts = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_hRes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_bufferSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox_vRes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_rxBuffers = new System.Windows.Forms.Label();
            this.textBox_chartName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1388, 392);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.UseWaitCursor = true;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button_comOpen
            // 
            this.button_comOpen.Location = new System.Drawing.Point(148, 18);
            this.button_comOpen.Name = "button_comOpen";
            this.button_comOpen.Size = new System.Drawing.Size(59, 21);
            this.button_comOpen.TabIndex = 1;
            this.button_comOpen.Text = "Open";
            this.button_comOpen.UseVisualStyleBackColor = true;
            this.button_comOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_availableSerialPorts
            // 
            this.comboBox_availableSerialPorts.FormattingEnabled = true;
            this.comboBox_availableSerialPorts.Location = new System.Drawing.Point(6, 19);
            this.comboBox_availableSerialPorts.Name = "comboBox_availableSerialPorts";
            this.comboBox_availableSerialPorts.Size = new System.Drawing.Size(136, 21);
            this.comboBox_availableSerialPorts.TabIndex = 5;
            this.comboBox_availableSerialPorts.Text = "Selecione a porta COM";
            this.comboBox_availableSerialPorts.DropDown += new System.EventHandler(this.comboBox_availableSerialPorts_DropDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_rxBuffers);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox_availableSerialPorts);
            this.groupBox1.Controls.Add(this.button_comOpen);
            this.groupBox1.Location = new System.Drawing.Point(14, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 78);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_chartName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_vRes);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_hRes);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_bufferSize);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(239, 410);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 78);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuração dos Dados";
            // 
            // textBox_hRes
            // 
            this.textBox_hRes.Location = new System.Drawing.Point(307, 24);
            this.textBox_hRes.Name = "textBox_hRes";
            this.textBox_hRes.Size = new System.Drawing.Size(31, 20);
            this.textBox_hRes.TabIndex = 3;
            this.textBox_hRes.Text = "2.5";
            this.textBox_hRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resolução Horizontal";
            // 
            // textBox_bufferSize
            // 
            this.textBox_bufferSize.Location = new System.Drawing.Point(142, 23);
            this.textBox_bufferSize.Name = "textBox_bufferSize";
            this.textBox_bufferSize.Size = new System.Drawing.Size(31, 20);
            this.textBox_bufferSize.TabIndex = 1;
            this.textBox_bufferSize.Text = "30";
            this.textBox_bufferSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamanho do Buffer [bytes]";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::fftPlot.Properties.Resources.github_logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(1290, 428);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 20);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::fftPlot.Properties.Resources.Transparent_Logo_White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(1356, 422);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1068, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Código fonte e tutorial disponíveis no GitHub:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1068, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desenvolvido por:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1158, 452);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(194, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "programacaoeletronica.wordpress.com/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBox_vRes
            // 
            this.textBox_vRes.Location = new System.Drawing.Point(307, 49);
            this.textBox_vRes.Name = "textBox_vRes";
            this.textBox_vRes.Size = new System.Drawing.Size(31, 20);
            this.textBox_vRes.TabIndex = 5;
            this.textBox_vRes.Text = "1";
            this.textBox_vRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resolução Vertical";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Buffers recebidos:";
            // 
            // label_rxBuffers
            // 
            this.label_rxBuffers.AutoSize = true;
            this.label_rxBuffers.Location = new System.Drawing.Point(94, 55);
            this.label_rxBuffers.Name = "label_rxBuffers";
            this.label_rxBuffers.Size = new System.Drawing.Size(13, 13);
            this.label_rxBuffers.TabIndex = 7;
            this.label_rxBuffers.Text = "0";
            // 
            // textBox_chartName
            // 
            this.textBox_chartName.Location = new System.Drawing.Point(62, 49);
            this.textBox_chartName.Name = "textBox_chartName";
            this.textBox_chartName.Size = new System.Drawing.Size(110, 20);
            this.textBox_chartName.TabIndex = 9;
            this.textBox_chartName.Text = "Serial Data";
            this.textBox_chartName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Legenda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 492);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ProgElet Serial Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button_comOpen;
        private System.Windows.Forms.ComboBox comboBox_availableSerialPorts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_hRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_bufferSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label_rxBuffers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_chartName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_vRes;
        private System.Windows.Forms.Label label5;
    }
}

