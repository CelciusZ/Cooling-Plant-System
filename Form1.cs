using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace V4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte MASTER = 0x11;
        byte SLAVE1 = 0x21;
        byte SLAVE2 = 0x31;
        byte SLAVE3 = 0x41;
        byte veri,CRC,x=0xa,veri2,veri3;
        byte adres,know;
        int sag_motor;
        int sol_motor,i;
        string data_in;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right)
            {
                label1.Text = "RIGHT";
                serialPort1.Write("r");
                sag_motor = sag_motor + 5;
                if (sag_motor>=255)
                {
                    
                    sag_motor = 255;
                }

            }
            if (e.KeyCode == Keys.Left)
            {
                label1.Text = "LEFT";
                serialPort1.Write("l");
                sol_motor = sol_motor + 5;
                if (sol_motor >= 255)
                {
                    sol_motor = 255;
                }

            }
            if (e.KeyCode == Keys.Up)
            {
                label1.Text = "FORWARD";
                serialPort1.Write("r");
                serialPort1.Write("l");

                sol_motor = sol_motor + 5;
                if (sol_motor >= 255)
                {
                    sol_motor = 255;
                }


                sag_motor = sag_motor + 5;
                if (sag_motor >= 255)
                {
                    sag_motor = 255;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                label1.Text = "SLOW";
                serialPort1.Write("3");
                sol_motor = sol_motor -5;
                if (sol_motor <=0)
                {
                    sol_motor = 0;
                }

            }
            if (e.KeyCode == Keys.W)
            {

                byte[] ccc = new byte[1];
                ccc[0] = 0xBB;
                serialPort1.Write("2S");
                serialPort1.Write(ccc, 0, ccc.Length);


            }
            if (e.KeyCode == Keys.S)
            {
                label1.Text = "PITCH(-)";
                serialPort1.Write("s");
            }
            if (e.KeyCode == Keys.A)
            {
                label1.Text = "ROLL(+)";
                serialPort1.Write("a");
            }
            if (e.KeyCode == Keys.D)
            {
                veri = 100;
                byte[] qqq = {MASTER,SLAVE1,0x01,0x01,veri,0x79 };
                
                serialPort1.Write(qqq, 0, qqq.Length);

            }
            if (e.KeyCode==Keys.Space)
            {
             
                serialPort1.Write("M");
                serialPort1.Write("1");

                byte[] ccc ={0xBB};
               
                serialPort1.Write(ccc, 0, ccc.Length);
               
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comport.Items.AddRange(ports);
            checkBox1.Checked = false;
            checkBox2.Checked = true;

        }








        private void button1_Click(object sender, EventArgs e)
        {
          
                try
                {
                    decimal x, z;
                    x = Decimal.Parse(textBox1.Text);
                    z = Decimal.Parse(textBox2.Text);
                    veri = decimal.ToByte(x);
                    CRC = decimal.ToByte(z);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (comboBox2.Text == "ACK")
                {
                    know = 0x01;
                }
                else
                {
                    know = 0x00;
                }

                if (comboBox1.Text == "MASTER")
                {
                    try
                    { byte[] qqq = { 0x4d, 0x31, veri };
                        serialPort1.Write(qqq, 0, qqq.Length);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (comboBox1.Text == "SLAVE1")
                    {
                        adres = 0x21;
                        hedef1.Text = (veri.ToString()+ " C°");
                    }

                    if (comboBox1.Text == "SLAVE2")
                    {
                        adres = 0x31;
                        hedef2.Text = (veri.ToString() + " C°");
                    }

                    if (comboBox1.Text == "SLAVE3")
                    {
                        adres = 0x41;
                        hedef3.Text = (veri.ToString() + " C°");
                    }
                    byte[] qqq = { MASTER, adres, know, 0x01, veri, CRC };
                    try
                    {
                        serialPort1.Write(qqq, 0, qqq.Length);
                    }

                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                
            }
        }





        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen == true)
                serialPort1.Close();
        }

        

        private void OPEN_Click(object sender, EventArgs e)
        {

            try
            {
                serialPort1.PortName = comport.Text;
                serialPort1.BaudRate = Convert.ToInt32(baudrate.Text);
                serialPort1.DataBits = Convert.ToInt32(databits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopbits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), paritybits.Text);
                serialPort1.Open();
                progressBar1.Value = 100;

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal x;
            x = Decimal.Parse(textBox1.Text);
            veri = decimal.ToByte(x);

            byte[] qqq = { veri };
            try
            {
                serialPort1.Write(qqq, 0, qqq.Length);
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = false;
            }
        }

        public void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            serialPort1.DtrEnable = true;
            serialPort1.RtsEnable = true;
            byte[] buffer = new byte[5];
            try
            {
                for (i = 0; i < buffer.Length; i++)
                {
                    serialPort1.Read(buffer, i, 1);
                }
                x = buffer[2];              
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // veri, kimden, deger
            if ( buffer[0]==0x47 && buffer[1] == 0x31)
            {
                if (x > veri)
                {
                    durum1.Invoke((MethodInvoker)delegate { durum1.Text = "AKTIF"; durum1.BackColor = Color.Green; });
                    sistem1.Invoke((MethodInvoker)delegate { sistem1.Text = (System.Convert.ToString(System.Convert.ToDecimal(buffer[2])) + " C°"); });
                }
                else
                {
                    durum1.Invoke((MethodInvoker)delegate { durum1.Text = "PASIF"; durum1.BackColor = Color.Red; });
                    sistem1.Invoke((MethodInvoker)delegate { sistem1.Text = (System.Convert.ToString(System.Convert.ToDecimal(buffer[2]))+  " C°"); });
                }
            }

            else if (buffer[0] == 0x47 &&  buffer[1] == 0x32)
            {
                if (x > veri)
                {
                    durum2.Invoke((MethodInvoker)delegate { durum2.Text = "AKTIF"; durum2.BackColor = Color.Green; });
                    sistem2.Invoke((MethodInvoker)delegate { sistem2.Text = (System.Convert.ToString(System.Convert.ToDecimal(buffer[2])) + " C°"); });
                }
                else
                {
                    durum2.Invoke((MethodInvoker)delegate { durum2.Text = "PASIF"; durum2.BackColor = Color.Red; });
                    sistem2.Invoke((MethodInvoker)delegate { sistem2.Text = (System.Convert.ToString(System.Convert.ToDecimal(buffer[2])) + " C°"); });
                }
            }

            else if (buffer[0] == 0x47 && buffer[1] == 0x33)
            {
                if (x > veri)
                {


                    durum3.Invoke((MethodInvoker)delegate { durum3.Text = "AKTIF"; durum3.BackColor = Color.Green; });
                    sistem3.Invoke((MethodInvoker)delegate { sistem3.Text = (System.Convert.ToString(System.Convert.ToDecimal(buffer[2])) + " C°"); });
                }
                else
                {
                    durum3.Invoke((MethodInvoker)delegate { durum3.Text = "PASIF"; durum3.BackColor = Color.Red; });
                    sistem3.Invoke((MethodInvoker)delegate { sistem3.Text = (System.Convert.ToString(System.Convert.ToDecimal(buffer[2])) + " C°"); });
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                textBox4.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox3.Text!="")
            {
                textBox3.Text = "";
            }
        }

        private void ShowData(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                textBox3.Text = data_in;
            }
            else 
            {
                textBox3.Text += data_in;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = true;
            }
    
        }


    }

}
