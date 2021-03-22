namespace Certification_Printer
{
    partial class ChoiceOutputFolder
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
            this.selectedOuputFolder = new MaterialSkin.Controls.MaterialLabel();
            this.selectOutputFolder = new MaterialSkin.Controls.MaterialFlatButton();
            this.donePic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.donePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedOuputFolder
            // 
            this.selectedOuputFolder.Depth = 0;
            this.selectedOuputFolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.selectedOuputFolder.Font = new System.Drawing.Font("Roboto", 11F);
            this.selectedOuputFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.selectedOuputFolder.Location = new System.Drawing.Point(0, 366);
            this.selectedOuputFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectedOuputFolder.Name = "selectedOuputFolder";
            this.selectedOuputFolder.Size = new System.Drawing.Size(892, 42);
            this.selectedOuputFolder.TabIndex = 7;
            this.selectedOuputFolder.Text = "Selected Folder";
            this.selectedOuputFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.selectedOuputFolder.Visible = false;
            // 
            // selectOutputFolder
            // 
            this.selectOutputFolder.AutoSize = true;
            this.selectOutputFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectOutputFolder.Depth = 0;
            this.selectOutputFolder.Location = new System.Drawing.Point(355, 233);
            this.selectOutputFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.selectOutputFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectOutputFolder.Name = "selectOutputFolder";
            this.selectOutputFolder.Primary = false;
            this.selectOutputFolder.Size = new System.Drawing.Size(170, 36);
            this.selectOutputFolder.TabIndex = 5;
            this.selectOutputFolder.Text = "Choice Output Folder";
            this.selectOutputFolder.UseVisualStyleBackColor = true;
            this.selectOutputFolder.Click += new System.EventHandler(this.selectOutputFolder_Click);
            // 
            // donePic
            // 
            this.donePic.Image = global::Certification_Printer.Properties.Resources.done;
            this.donePic.Location = new System.Drawing.Point(419, 282);
            this.donePic.Name = "donePic";
            this.donePic.Size = new System.Drawing.Size(48, 41);
            this.donePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.donePic.TabIndex = 6;
            this.donePic.TabStop = false;
            this.donePic.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Certification_Printer.Properties.Resources.folder;
            this.pictureBox1.Location = new System.Drawing.Point(351, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ChoiceOutputFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectedOuputFolder);
            this.Controls.Add(this.donePic);
            this.Controls.Add(this.selectOutputFolder);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ChoiceOutputFolder";
            this.Size = new System.Drawing.Size(892, 408);
            ((System.ComponentModel.ISupportInitialize)(this.donePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel selectedOuputFolder;
        private System.Windows.Forms.PictureBox donePic;
        private MaterialSkin.Controls.MaterialFlatButton selectOutputFolder;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
