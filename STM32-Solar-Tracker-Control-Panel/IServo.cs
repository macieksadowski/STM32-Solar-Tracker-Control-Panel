using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STM32_Solar_Tracker_Control_Panel
{
    public interface IServo
    {
        /*
         * @brief   Returns actual Angle value
         * @retval  actual angle <0:180>
         */
        int Angle { get; }

        /*
        * @brief   This method updates servomechanism visualization position
        * @param sender - contains a reference to the control/object that raised the event.
        * @param e - contains the event data.
        * @reval None
        */
        void RedrawArm(object sender, PaintEventArgs e);

        /*
        * @brief    This method returns UART command to control servomechanism
        * @param    angle to set on servo
        * @retval   returns UART command
        */
        string SetAngle(int value);
    }
}