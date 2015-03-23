using System;
using System.Collections.Generic;
using System.Text;

namespace PDStudio.SubTools.ListManager
{
    public class ListManager:PDStudio.SubTools.IPlugin
    {
        private void RunPlugin()
        {
            //System.Windows.Forms.MessageBox.Show("List Manager");
            System.Diagnostics.Debug.WriteLine("List Manager");
        }
        public string ClassName
        {
            get { return "List Manager"; }
        }

        public System.Version Version
        {
            get { return (new PDStudio.SubTools.ListManager.Version()).AssemblyVersion; }
        }

        public PDStudio.SubTools.StartPlugin StartingMethod
        {
            get { return RunPlugin; }
        }



        public System.Windows.Forms.Form ProgramMainForm
        {
            get;
            set;
        }


        public bool LoadCompleted
        {
            get;
            set;
        }


        public System.Windows.Forms.Form SettingsForm
        {
            get { throw new NotImplementedException(); }
        }

        public System.Windows.Forms.Form AboutForm
        {
            get { throw new NotImplementedException(); }
        }
    }
}
