using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PDStudio.SubTools
{
    public class Plugin
    {
        public static bool PluginsDetected
        {
            get;
            set;
        }
        public static List<PDStudio.SubTools.IPlugin> PlugIns
        {
            get;
            set;
        }
        public static PDStudio.SubTools.IPlugin plugin; // = new PDStudio.SubTools.Plugin();
        //public static List<lcatgolProfileManager.IPlugin> plugins = new List<IPlugin>();
        public static void PluginDetect(System.Windows.Forms.Form mainForm)
        {
            if (PluginsDetected)
                return;
            PlugIns = new List<IPlugin>();
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Plugins"))
                return;
            foreach (string pfile in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "Plugins", "*.dll"))
            {
                //MessageBox.Show ( pfile );
                Assembly asm = Assembly.LoadFile(pfile);

                //MessageBox.Show ( asm.FullName );
                Type[] types = asm.GetTypes();
                foreach (Type t in types)
                    foreach (Type interfaces in t.GetInterfaces())
                    {
                        //MessageBox.Show ( interfaces.FullName + "\n" + t.FullName );
                        if (interfaces.FullName == "PDStudio.SubTools.IPlugin")
                        {
                            plugin = asm.CreateInstance(t.FullName) as PDStudio.SubTools.IPlugin;
                            plugin.ProgramMainForm = mainForm;
                            plugin.LoadCompleted = true;
                            plugin.StartingMethod.Invoke();
                            PlugIns.Add(plugin);
                        }
                    }
            }
            PluginsDetected = true;
        }
    }
}