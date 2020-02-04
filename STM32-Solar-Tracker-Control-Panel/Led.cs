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

        
         
        //! Default constructor
        public Led(int number, PictureBox pictureBox, Label label) : base(device_type.LED, number, pictureBox, label)
        {
            pictureBox.Image = Properties.Resources.led;
            statusLabel.Text = "LED" + Number + " = OFF";
        }

        /*
        * @brief    Method return LED state
        * @retval   LED state (TRUE for high, FALSE for low)
        */
        public bool State
        {
            get => state;

        }

        /*
         * @brief   Toggle method return proper UART communicate, to steer LEDS
         * @retval  UART command ("LED x=00x")
        */
        public String Toggle()
        {
            if (state)
                return this.ToString() + "000";
            else return this.ToString() + "001";

        }

        /*
         * @brief Method switches LED on
         * @retval UART command to switch LED on
        */
        public String On()
        {
            return this.ToString() + "=001";
        }

       /*
        * @brief Method switches LED off
        * @retval UART command to switch LED off
       */
        public String Off()
        {
            return this.ToString() + "=000";
        }

        /*
         * @brief   Receive method updates device
         * @param   data new parameters
        */
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