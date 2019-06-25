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
            this.components = new System.ComponentModel.Container();
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosuj = new System.Windows.Forms.GroupBox();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.textBoxZakresDo = new System.Windows.Forms.TextBox();
            this.textBoxZakresOd = new System.Windows.Forms.TextBox();
            this.labelZakresDo = new System.Windows.Forms.Label();
            this.labelZakresOd = new System.Windows.Forms.Label();
            this.groupBoxWylosowano = new System.Windows.Forms.GroupBox();
            this.textBoxWylosowana = new System.Windows.Forms.TextBox();
            this.buttonPrzerwij = new System.Windows.Forms.Button();
            this.groupBoxPrzerwij = new System.Windows.Forms.GroupBox();
            this.wylosowana2 = new System.Windows.Forms.Label();
            this.liczbaRuchow2 = new System.Windows.Forms.Label();
            this.czas2 = new System.Windows.Forms.Label();
            this.wylosowana = new System.Windows.Forms.Label();
            this.liczbaRuchow = new System.Windows.Forms.Label();
            this.czasGry = new System.Windows.Forms.Label();
            this.buttonHistoria = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.czas = new System.Windows.Forms.Label();
            this.Odpowiedz = new System.Windows.Forms.Label();
            this.groupBoxLosuj.SuspendLayout();
            this.groupBoxWylosowano.SuspendLayout();
            this.groupBoxPrzerwij.SuspendLayout();
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
            this.groupBoxWylosowano.Controls.Add(this.Odpowiedz);
            this.groupBoxWylosowano.Controls.Add(this.czas);
            this.groupBoxWylosowano.Controls.Add(this.buttonSprawdz);
            this.groupBoxWylosowano.Controls.Add(this.textBoxWylosowana);
            this.groupBoxWylosowano.Location = new System.Drawing.Point(13, 158);
            this.groupBoxWylosowano.Name = "groupBoxWylosowano";
            this.groupBoxWylosowano.Size = new System.Drawing.Size(293, 94);
            this.groupBoxWylosowano.TabIndex = 4;
            this.groupBoxWylosowano.TabStop = false;
            this.groupBoxWylosowano.Text = "Liczba wylosowana. Odgadnij ją!";
            this.groupBoxWylosowano.Visible = false;
            this.groupBoxWylosowano.Enter += new System.EventHandler(this.groupBoxWylosowano_Enter);
            // 
            // textBoxWylosowana
            // 
            this.textBoxWylosowana.Location = new System.Drawing.Point(21, 42);
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
            // groupBoxPrzerwij
            // 
            this.groupBoxPrzerwij.Controls.Add(this.wylosowana2);
            this.groupBoxPrzerwij.Controls.Add(this.liczbaRuchow2);
            this.groupBoxPrzerwij.Controls.Add(this.czas2);
            this.groupBoxPrzerwij.Controls.Add(this.wylosowana);
            this.groupBoxPrzerwij.Controls.Add(this.liczbaRuchow);
            this.groupBoxPrzerwij.Controls.Add(this.czasGry);
            this.groupBoxPrzerwij.Location = new System.Drawing.Point(13, 270);
            this.groupBoxPrzerwij.Name = "groupBoxPrzerwij";
            this.groupBoxPrzerwij.Size = new System.Drawing.Size(293, 90);
            this.groupBoxPrzerwij.TabIndex = 7;
            this.groupBoxPrzerwij.TabStop = false;
            this.groupBoxPrzerwij.Visible = false;
            // 
            // wylosowana2
            // 
            this.wylosowana2.AutoSize = true;
            this.wylosowana2.Location = new System.Drawing.Point(156, 65);
            this.wylosowana2.Name = "wylosowana2";
            this.wylosowana2.Size = new System.Drawing.Size(35, 13);
            this.wylosowana2.TabIndex = 5;
            this.wylosowana2.Text = "label2";
            // 
            // liczbaRuchow2
            // 
            this.liczbaRuchow2.AutoSize = true;
            this.liczbaRuchow2.Location = new System.Drawing.Point(156, 42);
            this.liczbaRuchow2.Name = "liczbaRuchow2";
            this.liczbaRuchow2.Size = new System.Drawing.Size(35, 13);
            this.liczbaRuchow2.TabIndex = 4;
            this.liczbaRuchow2.Text = "label2";
            // 
            // czas2
            // 
            this.czas2.AutoSize = true;
            this.czas2.Location = new System.Drawing.Point(156, 16);
            this.czas2.Name = "czas2";
            this.czas2.Size = new System.Drawing.Size(35, 13);
            this.czas2.TabIndex = 3;
            this.czas2.Text = "label2";
            // 
            // wylosowana
            // 
            this.wylosowana.AutoSize = true;
            this.wylosowana.Location = new System.Drawing.Point(15, 65);
            this.wylosowana.Name = "wylosowana";
            this.wylosowana.Size = new System.Drawing.Size(71, 13);
            this.wylosowana.TabIndex = 2;
            this.wylosowana.Text = "Wylosowana:";
            // 
            // liczbaRuchow
            // 
            this.liczbaRuchow.AutoSize = true;
            this.liczbaRuchow.Location = new System.Drawing.Point(15, 42);
            this.liczbaRuchow.Name = "liczbaRuchow";
            this.liczbaRuchow.Size = new System.Drawing.Size(79, 13);
            this.liczbaRuchow.TabIndex = 1;
            this.liczbaRuchow.Text = "Liczba ruchów:";
            // 
            // czasGry
            // 
            this.czasGry.AutoSize = true;
            this.czasGry.Location = new System.Drawing.Point(15, 16);
            this.czasGry.Name = "czasGry";
            this.czasGry.Size = new System.Drawing.Size(99, 13);
            this.czasGry.TabIndex = 0;
            this.czasGry.Text = "Całkowity czas gry:";
            // 
            // buttonHistoria
            // 
            this.buttonHistoria.Location = new System.Drawing.Point(13, 366);
            this.buttonHistoria.Name = "buttonHistoria";
            this.buttonHistoria.Size = new System.Drawing.Size(75, 23);
            this.buttonHistoria.TabIndex = 8;
            this.buttonHistoria.Text = "Historia gry";
            this.buttonHistoria.UseVisualStyleBackColor = true;
            this.buttonHistoria.Click += new System.EventHandler(this.buttonHistoria_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(225, 366);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonInfo.TabIndex = 9;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Location = new System.Drawing.Point(212, 42);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(75, 23);
            this.buttonSprawdz.TabIndex = 4;
            this.buttonSprawdz.Text = "Sprawdź";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            this.buttonSprawdz.Click += new System.EventHandler(this.buttonSprawdz_Click);
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Location = new System.Drawing.Point(209, 16);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(35, 13);
            this.czas.TabIndex = 5;
            this.czas.Text = "label2";
            // 
            // Odpowiedz
            // 
            this.Odpowiedz.AutoSize = true;
            this.Odpowiedz.Location = new System.Drawing.Point(18, 70);
            this.Odpowiedz.Name = "Odpowiedz";
            this.Odpowiedz.Size = new System.Drawing.Size(60, 13);
            this.Odpowiedz.TabIndex = 6;
            this.Odpowiedz.Text = "Odpowiedź";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 401);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonHistoria);
            this.Controls.Add(this.groupBoxPrzerwij);
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
            this.groupBoxPrzerwij.ResumeLayout(false);
            this.groupBoxPrzerwij.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxWylosowana;
        private System.Windows.Forms.Button buttonPrzerwij;
        private System.Windows.Forms.GroupBox groupBoxPrzerwij;
        private System.Windows.Forms.Label wylosowana2;
        private System.Windows.Forms.Label liczbaRuchow2;
        private System.Windows.Forms.Label czas2;
        private System.Windows.Forms.Label wylosowana;
        private System.Windows.Forms.Label liczbaRuchow;
        private System.Windows.Forms.Label czasGry;
        private System.Windows.Forms.Button buttonHistoria;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label czas;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Odpowiedz;
    }
}

