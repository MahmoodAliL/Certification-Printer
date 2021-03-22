namespace Certification_Printer
{
    partial class ChoiceExcelFile
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
            this.openExcelFileBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.donePic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectedFileLbl = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.donePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openExcelFileBtn
            // 
            this.openExcelFileBtn.AutoSize = true;
            this.openExcelFileBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openExcelFileBtn.Depth = 0;
            this.openExcelFileBtn.Location = new System.Drawing.Point(385, 243);
            this.openExcelFileBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openExcelFileBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.openExcelFileBtn.Name = "openExcelFileBtn";
            this.openExcelFileBtn.Primary = false;
            this.openExcelFileBtn.Size = new System.Drawing.Size(122, 36);
            this.openExcelFileBtn.TabIndex = 1;
            this.openExcelFileBtn.Text = "Open Excel File";
            this.openExcelFileBtn.UseVisualStyleBackColor = true;
            this.openExcelFileBtn.Click += new System.EventHandler(this.openExcelFileBtn_Click);
            // 
            // donePic
            // 
            this.donePic.Image = global::Certification_Printer.Properties.Resources.done;
            this.donePic.Location = new System.Drawing.Point(420, 288);
            this.donePic.Name = "donePic";
            this.donePic.Size = new System.Drawing.Size(48, 41);
            this.donePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.donePic.TabIndex = 2;
            this.donePic.TabStop = false;
            this.donePic.Visible = false;
            this.donePic.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Certification_Printer.Properties.Resources.excel_logo;
            this.pictureBox1.Location = new System.Drawing.Point(340, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // selectedFileLbl
            // 
            this.selectedFileLbl.Depth = 0;
            this.selectedFileLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.selectedFileLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.selectedFileLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.selectedFileLbl.Location = new System.Drawing.Point(0, 366);
            this.selectedFileLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectedFileLbl.Name = "selectedFileLbl";
            this.selectedFileLbl.Size = new System.Drawing.Size(892, 42);
            this.selectedFileLbl.TabIndex = 3;
            this.selectedFileLbl.Text = "Selected File: ";
            this.selectedFileLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.selectedFileLbl.Visible = false;
            // 
            // ChoiceExcelFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectedFileLbl);
            this.Controls.Add(this.donePic);
            this.Controls.Add(this.openExcelFileBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ChoiceExcelFile";
            this.Size = new System.Drawing.Size(892, 408);
            ((System.ComponentModel.ISupportInitialize)(this.donePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton openExcelFileBtn;
        private System.Windows.Forms.PictureBox donePic;
        private MaterialSkin.Controls.MaterialLabel selectedFileLbl;
    }
}
