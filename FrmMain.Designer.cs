﻿
namespace WFA23100503
{
    partial class FrmMain
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
            this.lblTextfield = new System.Windows.Forms.Label();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTextfield
            // 
            this.lblTextfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTextfield.Location = new System.Drawing.Point(12, 9);
            this.lblTextfield.Name = "lblTextfield";
            this.lblTextfield.Size = new System.Drawing.Size(370, 89);
            this.lblTextfield.TabIndex = 0;
            this.lblTextfield.Text = "###placeholder###";
            this.lblTextfield.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClickMe
            // 
            this.btnClickMe.BackColor = System.Drawing.Color.HotPink;
            this.btnClickMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClickMe.Location = new System.Drawing.Point(18, 101);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(364, 76);
            this.btnClickMe.TabIndex = 1;
            this.btnClickMe.Text = "Click me!";
            this.btnClickMe.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 189);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.lblTextfield);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTextfield;
        private System.Windows.Forms.Button btnClickMe;
    }
}

