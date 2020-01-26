using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace STM32_Solar_Tracker_Control_Panel
{
    public class Led : Device, ILed
    {
        private bool state = false;

        public Led(int number, PictureBox pictureBox, Label label) : base(device_type.LED, number, pictureBox, label)
        {
            pictureBox.Image = Properties.Resources.led;
            statusLabel.Text = "LED" + Number + " = OFF";
        }

        public bool State
        {
            get => state;

        }

        public String Toggle()
        {
            if (state)
                return this.ToString() + "0000";
            else return this.ToString() + "0001";

        }

        public String On()
        {
            return this.ToString() + "=0001";
        }

        public String Off()
        {
            return this.ToString() + "=0000";
        }

        public override void Receive(int data)
        {
            if (data == 1)
            {
                state = true;
                pictureBox.Image = Properties.Resources.led_on;
                statusLabel.Text = "LED" + Number + " = ON";
            }
            else if (data == 0)
            {
                state = false;
                pictureBox.Image = Properties.Resources.led;
                statusLabel.Text = "LED" + Number + " = OFF";
            }

        }
    }
}