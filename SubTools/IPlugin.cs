using System;
using System.Collections.Generic;
using System.Text;

namespace PDStudio.SubTools
{
    public delegate void StartPlugin();
    interface IPlugin
    {
        string ClassName { get; }
        System.Version Version { get; }
        StartPlugin StartingMethod { get; }
        System.Windows.Forms.Form MainForm { get; set; }
    }

    public class Plugin
    {
        public static bool PluginsDetected
        {
            get;
            set;
        }


    }

}
