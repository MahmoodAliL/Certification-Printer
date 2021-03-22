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
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Certification_Printer
{
    public partial class ChoiceOutputFolder : UserControl
    {

        public string outputFolder { get; set; }
        public bool isCompleted { get; set; }

        public ChoiceOutputFolder()
        {
            InitializeComponent();
        }

        private void selectOutputFolder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                outputFolder = dialog.FileName;
                isCompleted = true;
                showCompletedStatus(outputFolder);

            }

           
        }

        private void showCompletedStatus(string fileName)
        {
            donePic.Visible = true;
            selectedOuputFolder.Visible = true;
            selectedOuputFolder.Text = "Selected Folder: " + fileName;

        }
    }
}
