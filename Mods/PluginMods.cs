using System;
using System.Collections.Generic;
using System.Text;
using Viveport;
using static Seralyth.Menu.Main;
using Seralyth.Classes;
using Seralyth.Mods;
using Seralyth.Managers;

namespace TFOEsCoolPlugin.Mods
{
    public static class PluginMods
    {
        
        public static void testinputs()
        {
            if (leftGrab)
            {
                NotificationManager.SendNotification("Left Grip Pressed!");
            }
            
            if (leftJoystickClick)
            {
                NotificationManager.SendNotification("Left Joystick Pressed!");
            }
            if (leftPrimary)
            {
                NotificationManager.SendNotification("Y Button Pressed!");
            }
            if (leftSecondary)
            {
                NotificationManager.SendNotification("X Button Pressed!");
            }
            if (leftTriggerPressed)
            {
                NotificationManager.SendNotification("Left Trigger Pressed!");
            }
            if (rightGrab)
            {
                NotificationManager.SendNotification("Right Grip Pressed!");
            }
            if (rightJoystickClick)
            {
                NotificationManager.SendNotification("Right Joystick Pressed!");
            }
            if (rightPrimary)
            {
                NotificationManager.SendNotification("B Pressed!");
            }
            if (rightSecondary)
            {
                NotificationManager.SendNotification("A Pressed!");
            }
            if (rightTriggerPressed)
            {
                NotificationManager.SendNotification("Right Trigger Pressed!");
            }

        }
    }
}
