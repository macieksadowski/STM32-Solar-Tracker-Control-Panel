using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace STM32_Solar_Tracker_Control_Panel
{


    public partial class Form1 : Form
    {
 
        List<Device> devices;
        String receivedData;
   
        private void receiveText()
        {
            
            Regex regReceive = new Regex("[A-Z]{3}\\s\\d=\\d{3}");
            
            receiveField.AppendText(receivedData + "\r\n");
            try
            {
                if (regReceive.IsMatch(receivedData))
                {
                    String[] substrings = receivedData.Split(' ');
                    String receiveDataDeviceType = substrings[0];
                    String[] substrings2 = substrings[1].Split('=');
                    int receiveDataDeviceNumber = Convert.ToInt32(substrings2[0]);
                    int receiveDataValue = Convert.ToInt32(substrings2[1]);
                    foreach (Device d in devices)
                    {
                        if (receiveDataDeviceType == device_type.LED.ToString())
                        {
                            if (d is ILed && d.Number == receiveDataDeviceNumber)
                            {
                                d.Receive(receiveDataValue);

                                break;
                            }
                        }
                        else if (receiveDataDeviceType == device_type.SRV.ToString())
                        {
                            if (d is IServo && d.Number == receiveDataDeviceNumber)
                            {
                                armSym.Refresh();
                                d.Receive(receiveDataValue);
                                break;
                            }
                        }
                        else if (receiveDataDeviceType == device_type.SEN.ToString())
                        {
                            if (d is ISensor && d.Number == receiveDataDeviceNumber)
                            {
                                d.Receive(receiveDataValue);
                                break;
                            }
                        }
                    }
                }
            }
            catch(Exception exc)
            {

            }
 
        }

        private void closeConnection()
        {
            if(serialPort1.IsOpen)
            {  
                backgroundWorker1.CancelAsync();
                MessageBox.Show(this, "Connection with port " + serialPort1.PortName + " closed.", "Info", MessageBoxButtons.OK);
            }
            deviceNumberList.Hide();
            label1.Hide();
            label2.Hide();
            deviceTypeComboBox.Hide();
            valueOptionLed.Hide();
            valueOptionServo.Hide();
            btnSend.Hide();
            
            StatusLabel.Text = "Disconnected";
            connectToolStripMenuItem.Text = "Connect";
            
        }
        private void openConnection()
        {
            try
            {
                serialPort1.Open();
                backgroundWorker1.RunWorkerAsync();
                MessageBox.Show("Succesfully connected with port " + serialPort1.PortName + " !", "Info", MessageBoxButtons.OK);
                StatusLabel.Text = "Connected";
                PortLabel.Text = serialPort1.PortName;
                label1.Show();
                deviceTypeComboBox.Show();
                connectToolStripMenuItem.Text = "Disconnect";
            }
            catch (Exception exc)
            {
                MessageBox.Show(this, "Connection error:\n" + exc.Message, "Info", MessageBoxButtons.OK);
            }
        }
        public Form1()
        {
            
            InitializeComponent();
            devices = new List<Device>()
            {
                new Servo(1,armSym,dataPanel.Controls[5] as Label),
                new Sensor(1,dataPanel.Controls[6] as Label),
                new Sensor(2,dataPanel.Controls[7] as Label),
            };
            for(int i=0;i<ledPanel.Controls.Count;i++)
            {
                devices.Add(new Led(i + 1, ledPanel.Controls[i] as PictureBox, dataPanel.Controls[i] as Label));
            }
            
            
           
            closeConnection();
            serialPort1.NewLine = "\r\n";
            serialPort1.PortName = "COM4";
            PortLabel.Text = serialPort1.PortName;
            serialPort1.BaudRate = 9600;
            BaudRateLabel.Text = serialPort1.BaudRate.ToString();
            


            if (serialPort1.IsOpen)
            {
                StatusLabel.Text = "Connected";
                connectToolStripMenuItem.Text = "Disconnect";
            }
            else
            {
                StatusLabel.Text = "Disconnected";
                connectToolStripMenuItem.Text = "Connect";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                closeConnection();
                
                 
            }
            else
            {
                openConnection();
            }

        }

       

        private void portToolStripMenuItem_Click(object sender, EventArgs e)
        {
            portToolStripMenuItem.DropDownItems.Clear();
            foreach (String s in SerialPort.GetPortNames()) portToolStripMenuItem.DropDownItems.Add(s);
            menuStrip1.Refresh();
            statusStrip1.Refresh();
        }

        private void portToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            PortLabel.Text = e.ClickedItem.Text;
            serialPort1.PortName = e.ClickedItem.Text;
            statusStrip1.Refresh();
            
        }

        private void speedToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem s in speedToolStripMenuItem.DropDownItems) s.Checked = false;
            BaudRateLabel.Text = e.ClickedItem.Text;
            serialPort1.BaudRate = Convert.ToInt32(e.ClickedItem.Text);
            statusStrip1.Refresh();
        }
        
        //MANUAL

        private void deviceTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deviceNumberList.Show();
            label2.Show();
            valueBox.Show();
            deviceNumberList.Select();
                if (deviceTypeComboBox.SelectedItem.ToString() =="Led")
                {
                    deviceNumberList.Items.Clear();
                    foreach (Device l in devices)
                    {
                    if (l is ILed)
                        deviceNumberList.Items.Add(l.Number);

                    }
                deviceNumberList.SelectedIndex = 0;
                valueOptionServo.Hide();
                valueOptionLed.Show();
               
                
            }
                else if (deviceTypeComboBox.SelectedItem.ToString() == "Servo")
                {
                   
                    deviceNumberList.Items.Clear();
                    foreach (Device s in devices)
                    if (s is IServo)
                    {
                        deviceNumberList.Items.Add(s.Number);
                    }
                deviceNumberList.SelectedIndex = 0;
                valueOptionServo.Show();
                valueOptionLed.Hide();
               
            }
            
                
        }

        private void ValueBox_TextChanged(object sender, EventArgs e)
        {
            btnSend.Show();
            valueBox.Text = valueScrollBar.Value.ToString();
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int selectedDevice = deviceNumberList.SelectedIndex+1;
            
            if (deviceTypeComboBox.SelectedItem.ToString() == "Led")
            {
                foreach(Device l in devices)
                {
                    if(l is ILed && l.Number ==selectedDevice)
                    {
                        
                        if (btnON.Checked) serialPort1.WriteLine((l as ILed).On());
                        if (btnOFF.Checked) serialPort1.WriteLine((l as ILed).Off());
                    }
                }  
            }
            else if (deviceTypeComboBox.SelectedItem.ToString() == "Servo")
            {
                foreach (Device s in devices)
                {
                    if (s is IServo && s.Number == selectedDevice)
                    {
                        serialPort1.WriteLine((s as IServo).SetAngle(valueScrollBar.Value));
                    }
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                
                closeConnection();
                
            }
            this.Close();
        }
        
        private void valueOptionServo_MouseHover(object sender, EventArgs e)
        {
            valueOptionServo.Select();
            valueScrollBar.Select();
        }

        private void valueOptionLed_MouseHover(object sender, EventArgs e)
        {
            valueOptionLed.Controls[1].Select();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void armSym_Paint(object sender, PaintEventArgs e)
        {
            (devices[0] as IServo).RedrawArm(sender, e);
            
        }

        private void Form1_FormClosing(object sender, FormClosedEventArgs e)
        {
            
            if (serialPort1.IsOpen)
            {
                
                closeConnection();
               
            }
 
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            String receivedData;
            do
            {
                if(backgroundWorker1.CancellationPending)
                {
                    serialPort1.Close();
                    break;
                }
                else
                {
                    receivedData = serialPort1.ReadLine();
                    (sender as BackgroundWorker).ReportProgress(0, receivedData);

                }
                //System.Threading.Thread.Sleep(10);
            } while (true);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!backgroundWorker1.CancellationPending)
            {
                receivedData = e.UserState as String;
                receiveText();
            }
                
        }


        //AUTO


    }
}
