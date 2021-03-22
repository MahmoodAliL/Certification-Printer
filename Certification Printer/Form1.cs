using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Certification_Printer
{
    public partial class MainFrm : MaterialForm
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private int step = 1;

        ChoiceExcelFile choiceExcelFile = new ChoiceExcelFile();
        ChoiceOutputFolder choiceOutputFolder = new ChoiceOutputFolder();
        GenerateCertifcations generateCertifications = new GenerateCertifcations();


        private void button1_Click(object sender, EventArgs e)
        {
            
        }


      
        private void btnNext_Click(object sender, EventArgs e)
        {
            var choiceCertificationImages = new Choice_Certification_Images();
            panel1.Controls.Add(choiceCertificationImages);

        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            showCertificationTemplate();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {

            switch (step)
            {
                case 1:

                    showChoiceExcelFile();
                    step++;

                    break;

                case 2:
                    if (choiceExcelFile.isCompleted)
                    {
                        step++;
                        showChoiceOutputFolder();
                    }

                    break;
                case 3:

                    if (choiceOutputFolder.isCompleted)
                    {
                        step++;
                        showGenerateCertifcation();
                        nextBtn.Hide(); 
                        
                    }

                    break;

                default:
                    break;
            }

            updateSteps();

        }

        private void showCertificationTemplate()
        {
            var choiceCertificationImages = new Choice_Certification_Images();
            panel1.Controls.Add(choiceCertificationImages);
        }

        private void showChoiceExcelFile()
        {
            panel1.Controls.Add(choiceExcelFile);
            panel1.Controls.SetChildIndex(choiceExcelFile, 0);
        }

        private void showChoiceOutputFolder()
        {
            panel1.Controls.Add(choiceOutputFolder);
            panel1.Controls.SetChildIndex(choiceOutputFolder, 0);
        }

        private void showGenerateCertifcation()
        {
            panel1.Controls.Add(generateCertifications);
            panel1.Controls.SetChildIndex(generateCertifications, 0);

            var excelFilePath = choiceExcelFile.exceFilePath;
            var outputFolderPath = choiceOutputFolder.outputFolder;

            generateCertifications.processing(excelFilePath, outputFolderPath);
        }


        private void updateSteps()
        {
            stepsLbl.Text = "Step " + step + " of 4";
        }
    }



}
