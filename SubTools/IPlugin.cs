using System;
using System.Collections.Generic;
using System.Text;

namespace PDStudio.SubTools
{
    public delegate void StartPlugin();
    public interface IPlugin
    {
        string ClassName { get; }
        System.Version Version { get; }
        StartPlugin StartingMethod { get; }
        System.Windows.Forms.Form ProgramMainForm { get; set; }
        bool LoadCompleted { get; set; }
        System.Windows.Forms.Form SettingsForm { get; }
        System.Windows.Forms.Form AboutForm { get; }
    }
}
