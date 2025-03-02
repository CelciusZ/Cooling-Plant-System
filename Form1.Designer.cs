
namespace V4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SEND = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paritybits = new System.Windows.Forms.ComboBox();
            this.stopbits = new System.Windows.Forms.ComboBox();
            this.databits = new System.Windows.Forms.ComboBox();
            this.baudrate = new System.Windows.Forms.ComboBox();
            this.comport = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.CLOSE = new System.Windows.Forms.Button();
            this.OPEN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.durum1 = new System.Windows.Forms.Button();
            this.sistem1 = new System.Windows.Forms.Label();
            this.sistem3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.durum3 = new System.Windows.Forms.Button();
            this.sistem2 = new System.Windows.Forms.Label();
            this.hedef1 = new System.Windows.Forms.Label();
            this.hedef3 = new System.Windows.Forms.Label();
            this.hedef2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.durum2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // SEND
            // 
            this.SEND.Location = new System.Drawing.Point(18, 188);
            this.SEND.Name = "SEND";
            this.SEND.Size = new System.Drawing.Size(164, 72);
            this.SEND.TabIndex = 9;
            this.SEND.Text = "SEND";
            this.SEND.UseVisualStyleBackColor = true;
            this.SEND.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "255";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "MASTER",
            "SLAVE1",
            "SLAVE2",
            "SLAVE3"});
            this.comboBox1.Location = new System.Drawing.Point(82, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "SLAVE1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.paritybits);
            this.groupBox1.Controls.Add(this.stopbits);
            this.groupBox1.Controls.Add(this.databits);
            this.groupBox1.Controls.Add(this.baudrate);
            this.groupBox1.Controls.Add(this.comport);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 169);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM PORT CONTROL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "COM PORT";
            // 
            // paritybits
            // 
            this.paritybits.Items.AddRange(new object[] {
            "Odd",
            "Even",
            "None"});
            this.paritybits.Location = new System.Drawing.Point(89, 131);
            this.paritybits.Name = "paritybits";
            this.paritybits.Size = new System.Drawing.Size(70, 21);
            this.paritybits.TabIndex = 19;
            this.paritybits.Text = "None";
            // 
            // stopbits
            // 
            this.stopbits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.stopbits.Location = new System.Drawing.Point(89, 104);
            this.stopbits.Name = "stopbits";
            this.stopbits.Size = new System.Drawing.Size(70, 21);
            this.stopbits.TabIndex = 18;
            this.stopbits.Text = "1";
            // 
            // databits
            // 
            this.databits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.databits.Location = new System.Drawing.Point(89, 77);
            this.databits.Name = "databits";
            this.databits.Size = new System.Drawing.Size(70, 21);
            this.databits.TabIndex = 17;
            this.databits.Text = "8";
            // 
            // baudrate
            // 
            this.baudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.baudrate.Location = new System.Drawing.Point(89, 50);
            this.baudrate.Name = "baudrate";
            this.baudrate.Size = new System.Drawing.Size(70, 21);
            this.baudrate.TabIndex = 16;
            this.baudrate.Text = "9600";
            // 
            // comport
            // 
            this.comport.Location = new System.Drawing.Point(89, 23);
            this.comport.Name = "comport";
            this.comport.Size = new System.Drawing.Size(70, 21);
            this.comport.TabIndex = 15;
            this.comport.Text = "COM1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.CLOSE);
            this.groupBox2.Controls.Add(this.OPEN);
            this.groupBox2.Location = new System.Drawing.Point(12, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 126);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 64);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(158, 36);
            this.progressBar1.TabIndex = 20;
            // 
            // CLOSE
            // 
            this.CLOSE.Location = new System.Drawing.Point(98, 19);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(75, 39);
            this.CLOSE.TabIndex = 19;
            this.CLOSE.Text = "CLOSE";
            this.CLOSE.UseVisualStyleBackColor = true;
            this.CLOSE.Click += new System.EventHandler(this.CLOSE_Click);
            // 
            // OPEN
            // 
            this.OPEN.Location = new System.Drawing.Point(15, 19);
            this.OPEN.Name = "OPEN";
            this.OPEN.Size = new System.Drawing.Size(75, 39);
            this.OPEN.TabIndex = 18;
            this.OPEN.Text = "OPEN";
            this.OPEN.UseVisualStyleBackColor = true;
            this.OPEN.Click += new System.EventHandler(this.OPEN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "DATA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "CRC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "ADRESS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.SEND);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(207, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 286);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmitter";
            // 
            // comboBox2
            // 
            this.comboBox2.Items.AddRange(new object[] {
            "ACK",
            "NACK"});
            this.comboBox2.Location = new System.Drawing.Point(82, 151);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.Text = "ACK";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "ACK";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Location = new System.Drawing.Point(413, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 451);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receiver";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 301);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(184, 103);
            this.textBox4.TabIndex = 25;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(16, 224);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(106, 17);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "Add To Old Data";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 188);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 17);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Always Update";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 32);
            this.button1.TabIndex = 26;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 26);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 105);
            this.textBox3.TabIndex = 25;
            // 
            // durum1
            // 
            this.durum1.Location = new System.Drawing.Point(101, 350);
            this.durum1.Name = "durum1";
            this.durum1.Size = new System.Drawing.Size(91, 26);
            this.durum1.TabIndex = 25;
            this.durum1.Text = "SOGUTUCU 1";
            this.durum1.UseVisualStyleBackColor = true;
            // 
            // sistem1
            // 
            this.sistem1.AutoSize = true;
            this.sistem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistem1.Location = new System.Drawing.Point(316, 350);
            this.sistem1.Name = "sistem1";
            this.sistem1.Size = new System.Drawing.Size(85, 30);
            this.sistem1.TabIndex = 26;
            this.sistem1.Text = "sistem1";
            this.sistem1.UseCompatibleTextRendering = true;
            // 
            // sistem3
            // 
            this.sistem3.AutoSize = true;
            this.sistem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistem3.Location = new System.Drawing.Point(316, 414);
            this.sistem3.Name = "sistem3";
            this.sistem3.Size = new System.Drawing.Size(85, 30);
            this.sistem3.TabIndex = 27;
            this.sistem3.Text = "sistem3";
            this.sistem3.UseCompatibleTextRendering = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(69, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 30);
            this.label12.TabIndex = 26;
            this.label12.Text = "SOGUTUCU";
            this.label12.UseCompatibleTextRendering = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(316, 317);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 30);
            this.label13.TabIndex = 26;
            this.label13.Text = "SİSTEM";
            this.label13.UseCompatibleTextRendering = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(210, 317);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 30);
            this.label14.TabIndex = 26;
            this.label14.Text = "HEDEF";
            this.label14.UseCompatibleTextRendering = true;
            // 
            // durum3
            // 
            this.durum3.Location = new System.Drawing.Point(101, 414);
            this.durum3.Name = "durum3";
            this.durum3.Size = new System.Drawing.Size(91, 26);
            this.durum3.TabIndex = 25;
            this.durum3.Text = "SOGUTUCU 3";
            this.durum3.UseVisualStyleBackColor = true;
            // 
            // sistem2
            // 
            this.sistem2.AutoSize = true;
            this.sistem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistem2.Location = new System.Drawing.Point(316, 382);
            this.sistem2.Name = "sistem2";
            this.sistem2.Size = new System.Drawing.Size(85, 30);
            this.sistem2.TabIndex = 27;
            this.sistem2.Text = "sistem2";
            this.sistem2.UseCompatibleTextRendering = true;
            // 
            // hedef1
            // 
            this.hedef1.AutoSize = true;
            this.hedef1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hedef1.Location = new System.Drawing.Point(210, 346);
            this.hedef1.Name = "hedef1";
            this.hedef1.Size = new System.Drawing.Size(76, 30);
            this.hedef1.TabIndex = 26;
            this.hedef1.Text = "hedef1";
            this.hedef1.UseCompatibleTextRendering = true;
            // 
            // hedef3
            // 
            this.hedef3.AutoSize = true;
            this.hedef3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hedef3.Location = new System.Drawing.Point(210, 410);
            this.hedef3.Name = "hedef3";
            this.hedef3.Size = new System.Drawing.Size(76, 30);
            this.hedef3.TabIndex = 27;
            this.hedef3.Text = "hedef3";
            this.hedef3.UseCompatibleTextRendering = true;
            // 
            // hedef2
            // 
            this.hedef2.AutoSize = true;
            this.hedef2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hedef2.Location = new System.Drawing.Point(210, 378);
            this.hedef2.Name = "hedef2";
            this.hedef2.Size = new System.Drawing.Size(76, 30);
            this.hedef2.TabIndex = 27;
            this.hedef2.Text = "hedef2";
            this.hedef2.UseCompatibleTextRendering = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 346);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 30);
            this.label19.TabIndex = 26;
            this.label19.Text = "ODA1";
            this.label19.UseCompatibleTextRendering = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 410);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 30);
            this.label21.TabIndex = 27;
            this.label21.Text = "ODA3";
            this.label21.UseCompatibleTextRendering = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 378);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 30);
            this.label22.TabIndex = 27;
            this.label22.Text = "ODA2";
            this.label22.UseCompatibleTextRendering = true;
            // 
            // durum2
            // 
            this.durum2.Location = new System.Drawing.Point(101, 382);
            this.durum2.Name = "durum2";
            this.durum2.Size = new System.Drawing.Size(91, 26);
            this.durum2.TabIndex = 25;
            this.durum2.Text = "SOGUTUCU 2";
            this.durum2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 523);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.hedef2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.sistem2);
            this.Controls.Add(this.hedef3);
            this.Controls.Add(this.sistem3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.hedef1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sistem1);
            this.Controls.Add(this.durum3);
            this.Controls.Add(this.durum2);
            this.Controls.Add(this.durum1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Sis-Tek Tesis Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button SEND;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox paritybits;
        private System.Windows.Forms.ComboBox stopbits;
        private System.Windows.Forms.ComboBox databits;
        private System.Windows.Forms.ComboBox baudrate;
        private System.Windows.Forms.ComboBox comport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button CLOSE;
        private System.Windows.Forms.Button OPEN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button durum1;
        private System.Windows.Forms.Label sistem1;
        private System.Windows.Forms.Label sistem3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button durum3;
        private System.Windows.Forms.Label sistem2;
        private System.Windows.Forms.Label hedef1;
        private System.Windows.Forms.Label hedef3;
        private System.Windows.Forms.Label hedef2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button durum2;
    }
}

