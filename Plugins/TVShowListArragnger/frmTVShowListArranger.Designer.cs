namespace PDStudio.SubTools.TVShowListArranger
{
    partial class frmTVShowListArranger
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkAddSeason = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeason = new System.Windows.Forms.TextBox();
            this.txtFileContents = new System.Windows.Forms.TextBox();
            this.btnReverseList = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.nudSeason = new PDStudio.SubTools.TVShowListArranger.NumericUpDown();
            this.SuspendLayout();
            // 
            // chkAddSeason
            // 
            this.chkAddSeason.AutoSize = true;
            this.chkAddSeason.Checked = global::PDStudio.SubTools.TVShowListArranger.Properties.Settings.Default.AddSeasonNo;
            this.chkAddSeason.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddSeason.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PDStudio.SubTools.TVShowListArranger.Properties.Settings.Default, "AddSeasonNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAddSeason.Location = new System.Drawing.Point(115, 43);
            this.chkAddSeason.Name = "chkAddSeason";
            this.chkAddSeason.Size = new System.Drawing.Size(124, 17);
            this.chkAddSeason.TabIndex = 16;
            this.chkAddSeason.Text = "Add Season Number";
            this.chkAddSeason.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Season";
            // 
            // txtSeason
            // 
            this.txtSeason.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PDStudio.SubTools.TVShowListArranger.Properties.Settings.Default, "SeasonNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSeason.Location = new System.Drawing.Point(147, 14);
            this.txtSeason.Name = "txtSeason";
            this.txtSeason.Size = new System.Drawing.Size(38, 20);
            this.txtSeason.TabIndex = 14;
            this.txtSeason.Text = global::PDStudio.SubTools.TVShowListArranger.Properties.Settings.Default.SeasonNo;
            this.txtSeason.Visible = false;
            // 
            // txtFileContents
            // 
            this.txtFileContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileContents.Location = new System.Drawing.Point(12, 67);
            this.txtFileContents.Multiline = true;
            this.txtFileContents.Name = "txtFileContents";
            this.txtFileContents.Size = new System.Drawing.Size(249, 285);
            this.txtFileContents.TabIndex = 13;
            // 
            // btnReverseList
            // 
            this.btnReverseList.Location = new System.Drawing.Point(12, 12);
            this.btnReverseList.Name = "btnReverseList";
            this.btnReverseList.Size = new System.Drawing.Size(129, 23);
            this.btnReverseList.TabIndex = 12;
            this.btnReverseList.Text = "Reverse List(From File)";
            this.btnReverseList.UseVisualStyleBackColor = true;
            this.btnReverseList.Click += new System.EventHandler(this.btnReverseList_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(185, 372);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // nudSeason
            // 
            this.nudSeason.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PDStudio.SubTools.TVShowListArranger.Properties.Settings.Default, "SeasonNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudSeason.Digits = 0;
            this.nudSeason.Location = new System.Drawing.Point(62, 41);
            this.nudSeason.Name = "nudSeason";
            this.nudSeason.Size = new System.Drawing.Size(40, 20);
            this.nudSeason.TabIndex = 18;
            this.nudSeason.Value = global::PDStudio.SubTools.TVShowListArranger.Properties.Settings.Default.SeasonNo;
            // 
            // frmTVShowListArranger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 400);
            this.Controls.Add(this.nudSeason);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkAddSeason);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeason);
            this.Controls.Add(this.txtFileContents);
            this.Controls.Add(this.btnReverseList);
            this.Name = "frmTVShowListArranger";
            this.Text = "frmTVShowListArranger";
            this.Load += new System.EventHandler(this.frmTVShowListArranger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAddSeason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeason;
        private System.Windows.Forms.TextBox txtFileContents;
        private System.Windows.Forms.Button btnReverseList;
        private System.Windows.Forms.Button btnClose;
        private NumericUpDown nudSeason;
    }
}