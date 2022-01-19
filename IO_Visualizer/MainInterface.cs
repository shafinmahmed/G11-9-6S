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
            distances.Add("21");
            distances.Add("22");
            distances.Add("23");
            distances.Add("24");
            distances.Add("25");


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
            Thread.Sleep(100);
            byte[] data = new byte[serialPort1.BytesToRead];
            Stream portStream = serialPort1.BaseStream;
            portStream.Read(data, 0, data.Length);
            string dataString = Encoding.UTF8.GetString(data);

            List<int> cleanData = new List<int>();
            foreach (string theStr in dataString.Split('\n'))
            {
                if (theStr.Count(f=> (f == 'A')) == 25)
                {

                    string processedData = theStr;
                    string[] allData = theStr.Split('A');

                    foreach (string item in allData)
                    {
                        string trimmed = item.Trim();
                        if (distances.Contains(trimmed))
                        {
                            int value = distances.IndexOf(trimmed) + 1;
                            cleanData.Add(value);
                        }

                    }
                }
            }

            /*
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
                        int value = 25;
                        cleanData.Add(value);
                    }
                }
            }
            */


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
                    //button10
                    BaseProgram.ColorInfo color10 = BaseProgram.GetRGB(cleanData[9]);
                    button10.BackColor = Color.FromArgb(color10.r, color10.g, color10.b);
                    //button11
                    BaseProgram.ColorInfo color11 = BaseProgram.GetRGB(cleanData[10]);
                    button11.BackColor = Color.FromArgb(color11.r, color11.g, color11.b);
                    //button12
                    BaseProgram.ColorInfo color12 = BaseProgram.GetRGB(cleanData[11]);
                    button12.BackColor = Color.FromArgb(color12.r, color12.g, color12.b);
                    //button13
                    BaseProgram.ColorInfo color13 = BaseProgram.GetRGB(cleanData[12]);
                    button13.BackColor = Color.FromArgb(color13.r, color13.g, color13.b);
                    //button14
                    BaseProgram.ColorInfo color14 = BaseProgram.GetRGB(cleanData[13]);
                    button14.BackColor = Color.FromArgb(color14.r, color14.g, color14.b);
                    //button15
                    BaseProgram.ColorInfo color15 = BaseProgram.GetRGB(cleanData[14]);
                    button15.BackColor = Color.FromArgb(color15.r, color15.g, color15.b);
                    //button16
                    BaseProgram.ColorInfo color16 = BaseProgram.GetRGB(cleanData[15]);
                    button16.BackColor = Color.FromArgb(color16.r, color16.g, color16.b);
                    //button17
                    BaseProgram.ColorInfo color17 = BaseProgram.GetRGB(cleanData[16]);
                    button17.BackColor = Color.FromArgb(color17.r, color17.g, color17.b);
                    //button18
                    BaseProgram.ColorInfo color18 = BaseProgram.GetRGB(cleanData[17]);
                    button18.BackColor = Color.FromArgb(color18.r, color18.g, color18.b);
                    //button19
                    BaseProgram.ColorInfo color19 = BaseProgram.GetRGB(cleanData[18]);
                    button19.BackColor = Color.FromArgb(color19.r, color19.g, color19.b);
                    //button20
                    BaseProgram.ColorInfo color20 = BaseProgram.GetRGB(cleanData[19]);
                    button20.BackColor = Color.FromArgb(color20.r, color20.g, color20.b);
                    //button21
                    BaseProgram.ColorInfo color21 = BaseProgram.GetRGB(cleanData[20]);
                    button21.BackColor = Color.FromArgb(color21.r, color21.g, color21.b);
                    //button22
                    BaseProgram.ColorInfo color22 = BaseProgram.GetRGB(cleanData[21]);
                    button22.BackColor = Color.FromArgb(color22.r, color22.g, color22.b);
                    //button23
                    BaseProgram.ColorInfo color23 = BaseProgram.GetRGB(cleanData[22]);
                    button23.BackColor = Color.FromArgb(color23.r, color23.g, color23.b);
                    //button24
                    BaseProgram.ColorInfo color24 = BaseProgram.GetRGB(cleanData[23]);
                    button24.BackColor = Color.FromArgb(color24.r, color24.g, color24.b);
                    //button25
                    BaseProgram.ColorInfo color25 = BaseProgram.GetRGB(cleanData[24]);
                    button25.BackColor = Color.FromArgb(color25.r, color25.g, color25.b);
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
