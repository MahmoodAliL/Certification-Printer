using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Certification_Printer
{
    public partial class ChoiceExcelFile : UserControl
    {
        public ChoiceExcelFile()
        {
            InitializeComponent();
        }

        public string exceFilePath { get; set; }
        public bool isCompleted { get; set; }

        private void openExcelFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select Excel file";
            fdlg.Filter = "All files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                exceFilePath = fdlg.FileName;
                isCompleted = true;
                showCompletedStatus(exceFilePath);


            }
        }

        private void showCompletedStatus(string fileName)
        {
            donePic.Visible = true;
            selectedFileLbl.Visible = true;
            selectedFileLbl.Text = "Selected File: " + fileName;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
