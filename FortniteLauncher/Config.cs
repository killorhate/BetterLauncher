﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortniteLauncher
{
    public class Config
    {
        public static string PlayerAuthUsername { get; set; }
        public static string PlayerAuthPassword { get; set; }
        public static bool ShowIfAnotherInstanceRunningDialog { get; set; }

        public static string SSLBypassDLL { get; set; } 
        public static string ConsoleDLL { get; set; }
        public static string MemoryLeakFixDLL { get; set; } 

        public class GameLaunchConfig
        {
            public static bool EnableSSLBypassConfig;

            public static bool SuspendBEConfig;
            public static bool SuspendEACConfig;
            public static bool FixMemoryLeakConfig;

            public static string LaunchArguments;
        }
    }
}
