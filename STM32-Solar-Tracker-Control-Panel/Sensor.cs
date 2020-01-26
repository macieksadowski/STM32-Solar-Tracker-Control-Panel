using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STM32_Solar_Tracker_Control_Panel
{
    public class Sensor : Device, ISensor
    {

        public int Value { get; private set; } = 0;
        public Sensor(int number, Label label) : base(device_type.SEN,number,null,label)
        {
            statusLabel.Text = "SENSOR " + Number + " : VALUE = " + Value;
        }
        
        public override void Receive(int data)
        {
            Value = data;
            statusLabel.Text = "SENSOR " + Number + " : VALUE = " + Value;
        }

    }
}