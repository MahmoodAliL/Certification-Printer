namespace Certification_Printer
{
    partial class GenerateCertifcations
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
            this.certificationsGeneratedLbl = new MaterialSkin.Controls.MaterialLabel();
            this.openOutputFolder = new MaterialSkin.Controls.MaterialFlatButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.donePic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.donePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // certificationsGeneratedLbl
            // 
            this.certificationsGeneratedLbl.Depth = 0;
            this.certificationsGeneratedLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.certificationsGeneratedLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.certificationsGeneratedLbl.Location = new System.Drawing.Point(244, 256);
            this.certificationsGeneratedLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.certificationsGeneratedLbl.Name = "certificationsGeneratedLbl";
            this.certificationsGeneratedLbl.Size = new System.Drawing.Size(395, 27);
            this.certificationsGeneratedLbl.TabIndex = 11;
            this.certificationsGeneratedLbl.Text = "1 of 1";
            this.certificationsGeneratedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openOutputFolder
            // 
            this.openOutputFolder.AutoSize = true;
            this.openOutputFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openOutputFolder.Depth = 0;
            this.openOutputFolder.Location = new System.Drawing.Point(363, 354);
            this.openOutputFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openOutputFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.openOutputFolder.Name = "openOutputFolder";
            this.openOutputFolder.Primary = false;
            this.openOutputFolder.Size = new System.Drawing.Size(157, 36);
            this.openOutputFolder.TabIndex = 9;
            this.openOutputFolder.Text = "Open Output Folder";
            this.openOutputFolder.UseVisualStyleBackColor = true;
            this.openOutputFolder.Visible = false;
            this.openOutputFolder.Click += new System.EventHandler(this.openOutputFolder_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(244, 221);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(395, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 12;
            // 
            // donePic
            // 
            this.donePic.Image = global::Certification_Printer.Properties.Resources.done;
            this.donePic.Location = new System.Drawing.Point(415, 304);
            this.donePic.Name = "donePic";
            this.donePic.Size = new System.Drawing.Size(48, 41);
            this.donePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.donePic.TabIndex = 10;
            this.donePic.TabStop = false;
            this.donePic.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Certification_Printer.Properties.Resources.processing_date;
            this.pictureBox1.Location = new System.Drawing.Point(338, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // GenerateCertifcations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.certificationsGeneratedLbl);
            this.Controls.Add(this.donePic);
            this.Controls.Add(this.openOutputFolder);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GenerateCertifcations";
            this.Size = new System.Drawing.Size(892, 408);
            ((System.ComponentModel.ISupportInitialize)(this.donePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel certificationsGeneratedLbl;
        private System.Windows.Forms.PictureBox donePic;
        private MaterialSkin.Controls.MaterialFlatButton openOutputFolder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}
