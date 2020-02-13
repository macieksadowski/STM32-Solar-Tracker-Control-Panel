using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STM32_Solar_Tracker_Control_Panel
{
    public class Sensor : Device, ISensor
    {
        private int value = 0;

        /**
         * @brief   Returns actual Sensor value
         * @retval  actual sensor value
         */
        public int Value
        {
            get => value;

        }
        //Constructor
        public Sensor(int number, Label label) : base(device_type.SEN,number,null,label)
        {
            statusLabel.Text = "SENSOR " + Number + " : VALUE = " + Value;
        }

        /**
         * @brief   Updates device
         * @param   data new parameters
         */
        public override void Receive(int data)
        {
            value = data;
            statusLabel.Text = "SENSOR " + Number + " : VALUE = " + value;
        }

    }
}