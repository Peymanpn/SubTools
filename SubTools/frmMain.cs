using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace PDStudio.SubTools
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Methods
        private void ApplyRes(Control c, int lang)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmMain));
            if (c.GetType() == typeof(MenuStrip))
                foreach (ToolStripMenuItem mitem in (c as MenuStrip).Items)
                    resources.ApplyResources(mitem, mitem.Name, new CultureInfo(lang));
            if (c.Controls.Count > 0)
                foreach (Control item in c.Controls)
                    ApplyRes(item, lang);
            resources.ApplyResources(c, c.Name, new CultureInfo(lang));

        }

        private void FindLanguages()
        {

        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            PDStudio.SubTools.Plugin.PluginDetect(this);
        }
    }
}