namespace GraGUI
{
    partial class Form1
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosuj = new System.Windows.Forms.GroupBox();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.textBoxZakresDo = new System.Windows.Forms.TextBox();
            this.textBoxZakresOd = new System.Windows.Forms.TextBox();
            this.labelZakresDo = new System.Windows.Forms.Label();
            this.labelZakresOd = new System.Windows.Forms.Label();
            this.groupBoxWylosowano = new System.Windows.Forms.GroupBox();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.textBoxWylosowana = new System.Windows.Forms.TextBox();
            this.buttonPrzerwij = new System.Windows.Forms.Button();
            this.groupBoxLosuj.SuspendLayout();
            this.groupBoxWylosowano.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(13, 13);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosuj
            // 
            this.groupBoxLosuj.Controls.Add(this.buttonLosuj);
            this.groupBoxLosuj.Controls.Add(this.textBoxZakresDo);
            this.groupBoxLosuj.Controls.Add(this.textBoxZakresOd);
            this.groupBoxLosuj.Controls.Add(this.labelZakresDo);
            this.groupBoxLosuj.Controls.Add(this.labelZakresOd);
            this.groupBoxLosuj.Location = new System.Drawing.Point(13, 43);
            this.groupBoxLosuj.Name = "groupBoxLosuj";
            this.groupBoxLosuj.Size = new System.Drawing.Size(293, 100);
            this.groupBoxLosuj.TabIndex = 1;
            this.groupBoxLosuj.TabStop = false;
            this.groupBoxLosuj.Text = "Losowanie";
            this.groupBoxLosuj.Visible = false;
            this.groupBoxLosuj.Enter += new System.EventHandler(this.groupBoxLosuj_Enter);
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(212, 41);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonLosuj.TabIndex = 2;
            this.buttonLosuj.Text = "Wylosuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            this.buttonLosuj.Click += new System.EventHandler(this.buttonLosuj_Click);
            // 
            // textBoxZakresDo
            // 
            this.textBoxZakresDo.Location = new System.Drawing.Point(91, 64);
            this.textBoxZakresDo.Name = "textBoxZakresDo";
            this.textBoxZakresDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxZakresDo.TabIndex = 3;
            // 
            // textBoxZakresOd
            // 
            this.textBoxZakresOd.Location = new System.Drawing.Point(91, 27);
            this.textBoxZakresOd.Name = "textBoxZakresOd";
            this.textBoxZakresOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxZakresOd.TabIndex = 2;
            // 
            // labelZakresDo
            // 
            this.labelZakresDo.AutoSize = true;
            this.labelZakresDo.Location = new System.Drawing.Point(18, 67);
            this.labelZakresDo.Name = "labelZakresDo";
            this.labelZakresDo.Size = new System.Drawing.Size(58, 13);
            this.labelZakresDo.TabIndex = 1;
            this.labelZakresDo.Text = "Zakres do:";
            // 
            // labelZakresOd
            // 
            this.labelZakresOd.AutoSize = true;
            this.labelZakresOd.Location = new System.Drawing.Point(18, 30);
            this.labelZakresOd.Name = "labelZakresOd";
            this.labelZakresOd.Size = new System.Drawing.Size(58, 13);
            this.labelZakresOd.TabIndex = 0;
            this.labelZakresOd.Text = "Zakres od:";
            // 
            // groupBoxWylosowano
            // 
            this.groupBoxWylosowano.Controls.Add(this.buttonSprawdz);
            this.groupBoxWylosowano.Controls.Add(this.textBoxWylosowana);
            this.groupBoxWylosowano.Location = new System.Drawing.Point(13, 158);
            this.groupBoxWylosowano.Name = "groupBoxWylosowano";
            this.groupBoxWylosowano.Size = new System.Drawing.Size(293, 75);
            this.groupBoxWylosowano.TabIndex = 4;
            this.groupBoxWylosowano.TabStop = false;
            this.groupBoxWylosowano.Text = "Liczba wylosowana. Odgadnij ją!";
            this.groupBoxWylosowano.Visible = false;
            this.groupBoxWylosowano.Enter += new System.EventHandler(this.groupBoxWylosowano_Enter);
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Location = new System.Drawing.Point(154, 30);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(75, 23);
            this.buttonSprawdz.TabIndex = 4;
            this.buttonSprawdz.Text = "Sprawdź";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            this.buttonSprawdz.Click += new System.EventHandler(this.buttonSprawdz_Click);
            // 
            // textBoxWylosowana
            // 
            this.textBoxWylosowana.Location = new System.Drawing.Point(21, 33);
            this.textBoxWylosowana.Name = "textBoxWylosowana";
            this.textBoxWylosowana.Size = new System.Drawing.Size(100, 20);
            this.textBoxWylosowana.TabIndex = 4;
            // 
            // buttonPrzerwij
            // 
            this.buttonPrzerwij.Location = new System.Drawing.Point(225, 10);
            this.buttonPrzerwij.Name = "buttonPrzerwij";
            this.buttonPrzerwij.Size = new System.Drawing.Size(75, 23);
            this.buttonPrzerwij.TabIndex = 5;
            this.buttonPrzerwij.Text = "Przerwij";
            this.buttonPrzerwij.UseVisualStyleBackColor = true;
            this.buttonPrzerwij.Click += new System.EventHandler(this.buttonPrzerwij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 369);
            this.Controls.Add(this.buttonPrzerwij);
            this.Controls.Add(this.groupBoxWylosowano);
            this.Controls.Add(this.groupBoxLosuj);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxLosuj.ResumeLayout(false);
            this.groupBoxLosuj.PerformLayout();
            this.groupBoxWylosowano.ResumeLayout(false);
            this.groupBoxWylosowano.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosuj;
        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.TextBox textBoxZakresDo;
        private System.Windows.Forms.TextBox textBoxZakresOd;
        private System.Windows.Forms.Label labelZakresDo;
        private System.Windows.Forms.Label labelZakresOd;
        private System.Windows.Forms.GroupBox groupBoxWylosowano;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.TextBox textBoxWylosowana;
        private System.Windows.Forms.Button buttonPrzerwij;
    }
}

