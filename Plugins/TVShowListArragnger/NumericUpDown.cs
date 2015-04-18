using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PDStudio.SubTools.TVShowListArranger
{
    public partial class NumericUpDown : UserControl
    {
        public NumericUpDown()
        {
            InitializeComponent();
        }
        [Category("Behavior")]

        public int Digits { get; set; }

        [Category("Behavior")]
        [DefaultValue(1)]
        public virtual string Value
        {
            get { return nup.Value.ToString("00"); }
            set { nup.Value = decimal.Parse(value); }
        }
        private void nup_ValueChanged(object sender, EventArgs e)
        {
            txt.Text = nup.Value.ToString("00");
            Value = nup.Value.ToString("00");
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            Value = txt.Text;
        }

        
    }
}
