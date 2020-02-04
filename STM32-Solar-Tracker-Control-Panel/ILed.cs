using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STM32_Solar_Tracker_Control_Panel
{
    public interface ILed
    {
        /*
         * @brief    Method return LED state
         * @retval   LED state (TRUE for high, FALSE for low)
        */
        bool State { get;}

        /*
         * @brief Method switches LED off
         * @retval UART command to switch LED off
        */
        string Off();

        /*
         * @brief Method switches LED on
         * @retval UART command to switch LED on
        */
        string On();

        /*
         * @brief   Toggle method return proper UART communicate, to steer LEDS
         * @retval  UART command ("LED x=00x")
        */
        string Toggle();
    }
}