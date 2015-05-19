using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PDStudio.SubTools.TVShowListArranger
{
    public partial class frmTVShowListArranger : Form
    {
        public frmTVShowListArranger()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //PDStudio.SubTools.TVShowListArranger.Properties.Settings.Default.Upgrade();
            PDStudio.SubTools.TVShowListArranger.Properties.Settings.Default.Save();
            Close();
        }

        private void btnReverseList_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                if (ofd.FileName != string.Empty)
                {
                    txtFileContents.Clear();
                    List<string> fileContents = new List<string>();

                    StreamReader sr = new StreamReader(ofd.FileName);
                    while (!sr.EndOfStream)
                    {
                        string str = sr.ReadLine();
                        if (str.StartsWith("Episode"))
                        {


                            str = str.Substring(8);//Episode string removing
                            str = str.Insert(2, "_");//adding _ after episode no
                            str = str.Insert(0, "E");
                            //season adding
                            if (chkAddSeason.Checked)
                                str = str.Insert(0, "S" + nudSeason.Value); //was  txtSeason.Text before 

                            //removing extra space after epidose no
                            str = str.Remove(7, 1);
                            //adding to list
                            fileContents.Add(str);
                        }
                    }

                    sr.Close();

                    for (int i = fileContents.Count - 1; i >= 0; i--)
                    {
                        txtFileContents.Text += fileContents[i];
                        if (i > 0) txtFileContents.Text += "\r\n";
                    }

                    StreamWriter sw = new StreamWriter(Path.GetDirectoryName(ofd.FileName) + "\\" + Path.GetFileNameWithoutExtension(ofd.FileName) + "out.txt");
                    sw.Write(txtFileContents.Text);
                    sw.Close();

                }
        }

        private void btnBatchRenameFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            string RenameHelperLastBrowsedFolder = string.Empty;
            RenameHelperLastBrowsedFolder = PDStudio.SubTools.TVShowListArranger.Properties.Settings.Default.LastBrowsedFolder;
            if (RenameHelperLastBrowsedFolder != string.Empty)
                if (Directory.Exists(RenameHelperLastBrowsedFolder))
                    fbd.SelectedPath = RenameHelperLastBrowsedFolder;

            if (fbd.ShowDialog() == DialogResult.OK)
                PDStudio.SubTools.TVShowListArranger.Properties.Settings.Default.LastBrowsedFolder = fbd.SelectedPath;
        }

        private void frmTVShowListArranger_Load(object sender, EventArgs e)
        {

        }
    }
}
