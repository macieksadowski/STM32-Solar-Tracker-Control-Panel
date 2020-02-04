using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace STM32_Solar_Tracker_Control_Panel
{
    public class Servo : Device, IServo
    {
        private int angle=0;
        
        /*
        * @brief    Servo object constructor
        * @param number information about device number
        * @param pictureBox assigned to this object
        * @param label assigned to this object
        */
        public Servo(int number, PictureBox pictureBox, Label label) : base(device_type.SRV, number,pictureBox,label)
        {
            statusLabel.Text = "SERVO " + Number + " : ANGLE = " + angle;
        }

        /*
         * @brief   Returns actual Angle value
         * @retval  actual angle <0:180>
         */
        public int Angle
        {
            get => angle;

        }
        
        /*
        * @brief    This method returns UART command to control servomechanism
        * @param    angle to set on servo
        * @retval   returns UART command
        */
        public String SetAngle(int angle)
        {
            if (angle >= 0 && angle <= 180)
            {
                int zerosToAdd = 3 - angle.ToString().Length;
                string zeros = "";
                for (int i = 0; i < zerosToAdd; i++)
                {
                    zeros += "0";
                }
                return this.ToString() + "=" + zeros + angle;
            }

            else
            {
                MessageBox.Show("Inserted value is above the range!\n", "Error", MessageBoxButtons.OK);
                return "";
            }

        }

        /*
         * @brief   Updates device
         * @param   data new parameters
         */
        public override void Receive(int data)
        {
            angle = data;
            statusLabel.Text = "SERVO " + Number + " : ANGLE = "+angle;
        }

        /*
         * @brief   This method updates servomechanism visualization position
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the event data.
         */
        public void RedrawArm(Object sender, PaintEventArgs e)
        {
            double angleRad = angle * 6.28 / 360.0;
            //double angle = (devices[0] as IServo).Angle * 6.28 / 360;
            Graphics g = e.Graphics;
            Rectangle pivot = new Rectangle(pictureBox.Width / 2 - 15, (int)(0.8 * pictureBox.Height), 30, 30);
            Point pivotCentre = new Point(pivot.X + pivot.Width / 2, pivot.Y + pivot.Height / 2);
            int armLength = (int)((0.9) * pictureBox.Height);
            Point armEnd = pivotCentre;
            armEnd.Offset(new Point((int)(Math.Cos(angleRad) * armLength), (int)(Math.Sin(angleRad) * -armLength)));
            Pen mypen = new Pen(Color.Black);
            g.FillEllipse(Brushes.Black, pivot);
            g.DrawLine(mypen, pivotCentre, armEnd);
        }

    }
}