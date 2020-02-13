using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace STM32_Solar_Tracker_Control_Panel
{

    public enum device_type { LED, SRV,SEN }; //<! enum device_type stores information about used device
    public class Device
    {
        public PictureBox pictureBox; 
        public Label statusLabel;
        private int number;
        private string name;
        private device_type type;

        public Device(device_type type,int number,PictureBox pictureBox,Label label)
        {
            this.type = type;
            this.number = number;
            this.pictureBox = pictureBox;
            this.statusLabel = label;
            name = type.ToString() + " " + number.ToString();
        }
        public device_type Type { get => type; }

        public int Number
        {
            get => number;
            
        }

        /**
         * @brief   Method ToString returns device name as string
         * @retval  device number as string
        */
        public override string ToString()
        {
            return name;
        }

        /**
         * @brief   Method Receive is implemented in inherited classes
         * @param   data stores information about device data(ie. servo position)
        */
        public virtual void Receive(int data)
        {
            throw new System.NotImplementedException();
        }
    }
}