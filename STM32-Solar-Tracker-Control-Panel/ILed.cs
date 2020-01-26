using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STM32_Solar_Tracker_Control_Panel
{
    public interface ILed
    {
        bool State { get;}

       
        string Off();
        string On();
        string Toggle();
    }
}