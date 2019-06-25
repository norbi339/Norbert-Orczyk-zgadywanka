namespace GraGUI
{
    partial class Form2
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
            this.labelGUI = new System.Windows.Forms.Label();
            this.labelVer = new System.Windows.Forms.Label();
            this.labelCop = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGUI
            // 
            this.labelGUI.AutoSize = true;
            this.labelGUI.Location = new System.Drawing.Point(36, 24);
            this.labelGUI.Name = "labelGUI";
            this.labelGUI.Size = new System.Drawing.Size(43, 13);
            this.labelGUI.TabIndex = 1;
            this.labelGUI.Text = "GraGUI";
            this.labelGUI.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelVer
            // 
            this.labelVer.AutoSize = true;
            this.labelVer.Location = new System.Drawing.Point(36, 52);
            this.labelVer.Name = "labelVer";
            this.labelVer.Size = new System.Drawing.Size(60, 13);
            this.labelVer.TabIndex = 2;
            this.labelVer.Text = "Version 1.0";
            // 
            // labelCop
            // 
            this.labelCop.AutoSize = true;
            this.labelCop.Location = new System.Drawing.Point(36, 83);
            this.labelCop.Name = "labelCop";
            this.labelCop.Size = new System.Drawing.Size(78, 13);
            this.labelCop.TabIndex = 3;
            this.labelCop.Text = "Copyright 2019";
            this.labelCop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(36, 114);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(78, 13);
            this.labelN.TabIndex = 4;
            this.labelN.Text = "Norbert Orczyk";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(173, 152);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 188);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelCop);
            this.Controls.Add(this.labelVer);
            this.Controls.Add(this.labelGUI);
            this.Name = "Form2";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGUI;
        private System.Windows.Forms.Label labelVer;
        private System.Windows.Forms.Label labelCop;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Button buttonOk;
    }
}