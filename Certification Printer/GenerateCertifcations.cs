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
using ExcelDataReader;
using System.Threading;

namespace Certification_Printer
{
    public partial class GenerateCertifcations : UserControl
    {
        BackgroundWorker backgroundWorker;
        public GenerateCertifcations()
        {
            InitializeComponent();

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;

            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        private class InputOutputInfo
        {

            public string exceFilePath { get; }
            public string outputFolderPath { get; }

            public InputOutputInfo(string efp, string ofp)
            {
                exceFilePath = efp;
                outputFolderPath = ofp;
            }
        }

        private int totalUsers = 0;
        private int currentUser = 0;

        private string mOuputFolderPath = "";
        

        internal void processing(string excelFilePath, string outputFolderPath)
        {
            mOuputFolderPath = outputFolderPath;
            var inputOuputInfo = new InputOutputInfo(excelFilePath, outputFolderPath);

            backgroundWorker.RunWorkerAsync(inputOuputInfo);
           
        }


        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var inputOuputInfo = (InputOutputInfo) e.Argument;
            readAllNames(inputOuputInfo.exceFilePath, inputOuputInfo.outputFolderPath);
        }

        private void readAllNames(string excelFilePath, string outputFolderPath)
        {
            FileStream stream = File.Open(excelFilePath, FileMode.Open, FileAccess.Read);

            //2. Reading from a OpenXml Excel file (2007 format; *.xlsx)
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            totalUsers = excelReader.RowCount;
            currentUser = 0;

            //5. Data Reader methods
            while (excelReader.Read())
            {

                

                var name = excelReader.GetString(2);
                saveImage(outputFolderPath, name);
                var percentProgress = (int) ((++currentUser / (float)totalUsers) * 100) ;
                Console.WriteLine(percentProgress);
                backgroundWorker.ReportProgress(percentProgress);
                

            }

            //6. Free resources (IExcelDataReader is IDisposable)
            excelReader.Close();
        }
        private void saveImage(string outFolderPath, string imageName)
        {
            var bmp = new Bitmap(Properties.Resources.certification_temp1);
            var gra = Graphics.FromImage(bmp);

            var text = "((" + imageName + "))";
            var font = new Font("SPFNuyorkArabic-Light", 32);
            var brush = Brushes.Black;

            using (var sf = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                //LineAlignment = StringAlignment.Center,
            })
            {
                gra.DrawString(text, font, brush, new Rectangle(0, 470, bmp.Width, bmp.Height), sf);
            };


            bmp.Save(outFolderPath + "\\" + imageName + ".jpg");

        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            certificationsGeneratedLbl.Text = currentUser + " of " + totalUsers;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            donePic.Visible = Visible;
            openOutputFolder.Visible = Visible;
           
        }

        private void openOutputFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(mOuputFolderPath);
        }
    }
}
