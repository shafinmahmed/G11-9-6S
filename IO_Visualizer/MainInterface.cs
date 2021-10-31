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
            serialPort1.Encoding = Encoding.UTF8;
            string[] inData = serialPort1.ReadExisting().Trim().Split('\n');
            string myVal = inData[0];

            int dist;

            if (distances.Contains(myVal))
            {
                dist =  distances.IndexOf(myVal) + 1;
            }
            else
            {
                dist = -1;
            }

            if (dist != - 1)
            {
                BaseProgram.ColorInfo rgbVal = BaseProgram.GetRGB(dist);

                txtBoxSerialMonitor.Text = "R: " + rgbVal.r + " G: " + rgbVal.g + " B: " + rgbVal.b;

                labelRed.BackColor = Color.FromArgb(rgbVal.r, rgbVal.b, rgbVal.g);
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
    }
}
