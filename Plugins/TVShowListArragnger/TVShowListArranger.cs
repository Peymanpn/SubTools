using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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
            ToolStripMenuItem tsmiAbout = new ToolStripMenuItem("About");
            ToolStripMenuItem tsmiOptions=new ToolStripMenuItem("Options");
            ToolStripMenuItem tsmiMain=new ToolStripMenuItem("TV Show List Arranger");

            tsmiAbout.Click+=new EventHandler(tsmiAbout_Click);
            tsmiOptions.Click += new EventHandler(tsmiOptions_Click);
            tsmiMain.Click +=new EventHandler(tsmiMain_Click);
            foreach (System.Windows.Forms.ToolStripMenuItem tsmi in ((System.Windows.Forms.MenuStrip)ProgramMainForm.Controls.Find("mainMenuStrip", true)[0]).Items)
                if (tsmi.Name == "toolsToolStripMenuItem")
                    foreach (System.Windows.Forms.ToolStripMenuItem tsmiPlugins in tsmi.DropDownItems)
                        if (tsmiPlugins.Name == "pluginsToolStripMenuItem")
                            tsmiPlugins.DropDownItems.Add(tsmiMain);

            if (TVShowListArranger.Properties.Settings.Default.ShowButtonInMainWindow)
            {
                System.Windows.Forms.Button btnStart = new Button();
                btnStart.Text = tsmiMain.Text;
                btnStart.Click += tsmiMain_Click;
                ProgramMainForm.Controls.Add(btnStart);
            }
                
                
            
        }

        private void tsmiMain_Click(object sender, EventArgs e)
        {
            (new frmTVShowListArranger()).ShowDialog();
        }

        private void tsmiOptions_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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


        public System.Windows.Forms.Form SettingsForm
        {
            get
            {
                return new frmSettings();
            }

        }


        public System.Windows.Forms.Form AboutForm
        {
            get { return new frmAbout(); }
        }
    }
}
