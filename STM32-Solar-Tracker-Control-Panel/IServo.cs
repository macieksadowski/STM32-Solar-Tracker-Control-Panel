using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STM32_Solar_Tracker_Control_Panel
{
    public interface IServo
    {
        int Angle { get; }

        void RedrawArm(object sender, PaintEventArgs e);
        string SetAngle(int value);
    }
}