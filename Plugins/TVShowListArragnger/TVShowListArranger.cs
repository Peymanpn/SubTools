using System;
using System.Collections.Generic;
using System.Text;

namespace PDStudio.SubTools.TVShowListArranger
{
    public class TVShowListArragnger:PDStudio.SubTools.IPlugin
    {
        private void RunPlugin()
        {
            if (!LoadCompleted) return;
            ProgramMainForm.Text = "tv show list";
            //mainMenuStrip
            //toolsToolStripMenuItem
            //pluginsToolStripMenuItem
            //pluginsToolStripMenuItem
        }
        public string ClassName
        {
            get { return "TV Show List Arragnger"; }
        }

        public System.Version Version
        {
            get { return (new PDStudio.SubTools.TVShowListArranger.Version()).AssemblyVersion; }
        }

        public PDStudio.SubTools.StartPlugin StartingMethod
        {
            get { return RunPlugin; }
        }



        System.Windows.Forms.Form _mainForm;
        public System.Windows.Forms.Form ProgramMainForm
        {
            get { return _mainForm; }
            set{_mainForm=value;}
        }



        public bool LoadCompleted
        {
            get;
            set;
        }
    }
}
