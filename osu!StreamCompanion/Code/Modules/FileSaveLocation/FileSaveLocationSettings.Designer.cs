﻿namespace osu_StreamCompanion.Code.Modules.osuPathReslover
{
    partial class FileSaveLocationSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_OpenFilesFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "StreamCompanion files save location:";
            // 
            // button_OpenFilesFolder
            // 
            this.button_OpenFilesFolder.Location = new System.Drawing.Point(192, 2);
            this.button_OpenFilesFolder.Name = "button_OpenFilesFolder";
            this.button_OpenFilesFolder.Size = new System.Drawing.Size(180, 23);
            this.button_OpenFilesFolder.TabIndex = 2;
            this.button_OpenFilesFolder.Text = "Open";
            this.button_OpenFilesFolder.UseVisualStyleBackColor = true;
            this.button_OpenFilesFolder.Click += new System.EventHandler(this.button_OpenFilesFolder_Click);
            // 
            // FileSaveLocationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_OpenFilesFolder);
            this.Controls.Add(this.label1);
            this.Name = "FileSaveLocationSettings";
            this.Size = new System.Drawing.Size(392, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button_OpenFilesFolder;
    }
}
