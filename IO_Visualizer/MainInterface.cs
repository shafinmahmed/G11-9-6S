using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Ports;
using System.IO;

namespace IO_Visualizer
{
    public partial class MainInterface : Form
    {
        List<string> distances = new List<string>();

        public MainInterface()
        {
            InitializeComponent();
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {
            btnClosePort.Enabled = false;
            labelStatus.Text = "Disconnected";
            labelStatus.ForeColor = Color.Red;
            txtBoxArdInput.Enabled = false;
            comBoxPortList.Items.AddRange(SerialPort.GetPortNames());

            distances.Add("1");
            distances.Add("2");
            distances.Add("3");
            distances.Add("4");
            distances.Add("5");
            distances.Add("6");
            distances.Add("7");
            distances.Add("8");
            distances.Add("9");
            distances.Add("10");
            distances.Add("11");
            distances.Add("12");
            distances.Add("13");
            distances.Add("14");
            distances.Add("15");
            distances.Add("16");
            distances.Add("17");
            distances.Add("18");
            distances.Add("19");
            distances.Add("20");


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/shafinmahmed/G11-9-6S");
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comBoxPortList.Text.Trim()) || string.IsNullOrWhiteSpace(comBoxBaudrate.Text.Trim()))
            {
                MessageBox.Show("COM Port and Baudrate must be selected!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cursor = Cursors.WaitCursor;
            try
            {
                serialPort1.PortName = comBoxPortList.Text.Trim();
                serialPort1.BaudRate = Convert.ToInt32(comBoxBaudrate.Text.Trim());
                serialPort1.Open();

                Application.DoEvents();

                btnOpenPort.Enabled = false;
                btnClosePort.Enabled = true;
                labelStatus.Text = "Connected";
                labelStatus.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                btnOpenPort.Enabled = true;
                btnClosePort.Enabled = false;
                labelStatus.Text = "Disconnected";
                labelStatus.ForeColor = Color.Red;

                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor = Cursors.Default;
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                Cursor = Cursors.WaitCursor;
                try
                {
                    serialPort1.Close();
                    btnOpenPort.Enabled = true;
                    btnClosePort.Enabled = false;
                    labelStatus.Text = "Disconnected";
                    labelStatus.ForeColor = Color.Red;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Cursor = Cursors.Default;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.BeginInvoke(new EventHandler(ProcessData));
        }

        private void ProcessData(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                return;
            }
            Thread.Sleep(50);
            byte[] data = new byte[serialPort1.BytesToRead];
            Stream portStream = serialPort1.BaseStream;
            portStream.Read(data, 0, data.Length);
            string dataString = Encoding.UTF8.GetString(data);
            List<int> cleanData = new List<int>();
            if (dataString.Length != 0)
            {
                string[] alldata = dataString.Split('A');



                foreach (string item in alldata)
                {
                    string trimmed = item.Trim();
                    if (distances.Contains(trimmed))
                    {
                        int value = distances.IndexOf(trimmed) + 1;
                        cleanData.Add(value);
                    }
                    else
                    {
                        int value = 20;
                        cleanData.Add(value);
                    }
                }
            }



            string str = "";

            foreach (int item in cleanData)
            {
                str += item.ToString() + " ";
            }
            if (str.Trim().Length != 0)
            {
                try
                {
                    //button1
                    BaseProgram.ColorInfo color1 = BaseProgram.GetRGB(cleanData[0]);
                    button1.BackColor = Color.FromArgb(color1.r, color1.g, color1.b);
                    //button2
                    BaseProgram.ColorInfo color2 = BaseProgram.GetRGB(cleanData[1]);
                    button2.BackColor = Color.FromArgb(color2.r, color2.g, color2.b);
                    //button3
                    BaseProgram.ColorInfo color3 = BaseProgram.GetRGB(cleanData[2]);
                    button3.BackColor = Color.FromArgb(color3.r, color3.g, color3.b);
                    //button4
                    BaseProgram.ColorInfo color4 = BaseProgram.GetRGB(cleanData[3]);
                    button4.BackColor = Color.FromArgb(color4.r, color4.g, color4.b);
                    //button5
                    BaseProgram.ColorInfo color5 = BaseProgram.GetRGB(cleanData[4]);
                    button5.BackColor = Color.FromArgb(color5.r, color5.g, color5.b);
                    //button6
                    BaseProgram.ColorInfo color6 = BaseProgram.GetRGB(cleanData[5]);
                    button6.BackColor = Color.FromArgb(color6.r, color6.g, color6.b);
                    //button7
                    BaseProgram.ColorInfo color7 = BaseProgram.GetRGB(cleanData[6]);
                    button7.BackColor = Color.FromArgb(color7.r, color7.g, color7.b);
                    //button8
                    BaseProgram.ColorInfo color8 = BaseProgram.GetRGB(cleanData[7]);
                    button8.BackColor = Color.FromArgb(color8.r, color8.g, color8.b);
                    //button9
                    BaseProgram.ColorInfo color9 = BaseProgram.GetRGB(cleanData[8]);
                    button9.BackColor = Color.FromArgb(color9.r, color9.g, color9.b);

                }
                catch (Exception)
                {

                }
            }
        }

        private void MainInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                serialPort1.Close();
                Application.DoEvents();
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxSerialMonitor_TextChanged(object sender, EventArgs e)
        {

        }

        private void comBoxPortList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
