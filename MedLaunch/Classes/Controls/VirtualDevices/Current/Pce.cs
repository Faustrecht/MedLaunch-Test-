﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedLaunch.Classes.Controls.VirtualDevices
{
    public class Pce : VirtualDeviceBase
    {
        public static DeviceDefinition GamePad(int VirtualPort)
        {
            DeviceDefinition device = new DeviceDefinition();
            device.DeviceName = "PCE GamePad";
            device.CommandStart = "pce.input.port" + VirtualPort;
            device.ControllerName = "gamepad";
            device.VirtualPort = VirtualPort;
            device.MapList = new List<Mapping>
            {
                /* MapList is now autogenerated from mednafen.cfg */
            };

            device.CustomOptions = new List<NonControlMapping>
            {
                new NonControlMapping { Description = "Default position for 'MODE' switch",
                    MednafenCommand = device.CommandStart + ".gamepad.mode_select.defpos",
                    MinValue = 2, MaxValue = 6,
                    Values = new List<string>
                    {
                        "2", "6"
                    },
                    ContType = ContrType.COMBO,
                 ConvType = ConvertionType.STRING},
            };

            DeviceDefinition.ParseOptionsFromConfig(device);
            DeviceDefinition.PopulateConfig(device);
            return device;
        }

        public static DeviceDefinition Mouse(int VirtualPort)
        {
            DeviceDefinition device = new DeviceDefinition();
            device.DeviceName = "PCE Mouse";
            device.CommandStart = "pce.input.port" + VirtualPort;
            device.ControllerName = "mouse";
            device.VirtualPort = VirtualPort;
            device.MapList = new List<Mapping>
            {
                /* MapList is now autogenerated from mednafen.cfg */
            };
            DeviceDefinition.ParseOptionsFromConfig(device);
            DeviceDefinition.PopulateConfig(device);
            return device;
        }

        public static DeviceDefinition Tsushin(int VirtualPort)
        {
            DeviceDefinition device = new DeviceDefinition();
            device.DeviceName = "PCE Tsushin Keyboard";
            device.CommandStart = "pce.input.port" + VirtualPort;
            device.ControllerName = "tsushinkb";
            device.VirtualPort = VirtualPort;
            device.MapList = new List<Mapping>
            {
                /* MapList is now autogenerated from mednafen.cfg */
            };
            DeviceDefinition.ParseOptionsFromConfig(device);
            DeviceDefinition.PopulateConfig(device);
            return device;
        }
    }
}
