﻿
namespace _102190145_NguyenQuyTrieu.GUI
{
    partial class Form3
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
            this.lgt1 = new Login.LGT();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lgt1
            // 
            this.lgt1.Location = new System.Drawing.Point(38, 27);
            this.lgt1.Name = "lgt1";
            this.lgt1.Passwork = "";
            this.lgt1.Size = new System.Drawing.Size(361, 138);
            this.lgt1.TabIndex = 0;
            this.lgt1.User = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lgt1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private Login.LGT lgt1;
        private System.Windows.Forms.Button button1;
    }
}