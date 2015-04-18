namespace PDStudio.SubTools.TVShowListArranger
{
    partial class NumericUpDown
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nup = new System.Windows.Forms.NumericUpDown();
            this.txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nup)).BeginInit();
            this.SuspendLayout();
            // 
            // nup
            // 
            this.nup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nup.Location = new System.Drawing.Point(0, 0);
            this.nup.Name = "nup";
            this.nup.Size = new System.Drawing.Size(120, 20);
            this.nup.TabIndex = 0;
            this.nup.ValueChanged += new System.EventHandler(this.nup_ValueChanged);
            // 
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.Location = new System.Drawing.Point(0, 0);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(105, 20);
            this.txt.TabIndex = 1;
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt);
            this.Controls.Add(this.nup);
            this.Name = "NumericUpDown";
            this.Size = new System.Drawing.Size(120, 20);
            ((System.ComponentModel.ISupportInitialize)(this.nup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nup;
        private System.Windows.Forms.TextBox txt;
    }
}
