
namespace KartyaKezelo
{
    partial class KartyaLetrehozas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCvc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpLejarat = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBankkartyaSzam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbVisa = new System.Windows.Forms.RadioButton();
            this.rbMasterCard = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUjTulajdonos = new System.Windows.Forms.Button();
            this.lbTulajdonosok = new System.Windows.Forms.ListBox();
            this.btnMentesKilepes = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbTulajdonosTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTulajdonosEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTulajdonosNeve = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMentesListaba = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCvc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpLejarat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbBankkartyaSzam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(235, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bankkártya adatai";
            // 
            // tbCvc
            // 
            this.tbCvc.Location = new System.Drawing.Point(6, 133);
            this.tbCvc.Name = "tbCvc";
            this.tbCvc.Size = new System.Drawing.Size(382, 22);
            this.tbCvc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "CVC kód";
            // 
            // dtpLejarat
            // 
            this.dtpLejarat.CustomFormat = "MM/yy";
            this.dtpLejarat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLejarat.Location = new System.Drawing.Point(7, 88);
            this.dtpLejarat.Name = "dtpLejarat";
            this.dtpLejarat.Size = new System.Drawing.Size(381, 22);
            this.dtpLejarat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lejárat dátuma";
            // 
            // tbBankkartyaSzam
            // 
            this.tbBankkartyaSzam.Location = new System.Drawing.Point(7, 43);
            this.tbBankkartyaSzam.Name = "tbBankkartyaSzam";
            this.tbBankkartyaSzam.Size = new System.Drawing.Size(381, 22);
            this.tbBankkartyaSzam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bankkártya száma";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbVisa);
            this.groupBox2.Controls.Add(this.rbMasterCard);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bankkártya típusa";
            // 
            // rbVisa
            // 
            this.rbVisa.AutoSize = true;
            this.rbVisa.Location = new System.Drawing.Point(152, 21);
            this.rbVisa.Name = "rbVisa";
            this.rbVisa.Size = new System.Drawing.Size(59, 21);
            this.rbVisa.TabIndex = 1;
            this.rbVisa.TabStop = true;
            this.rbVisa.Text = "VISA";
            this.rbVisa.UseVisualStyleBackColor = true;
            this.rbVisa.CheckedChanged += new System.EventHandler(this.rbVisa_CheckedChanged);
            // 
            // rbMasterCard
            // 
            this.rbMasterCard.AutoSize = true;
            this.rbMasterCard.Location = new System.Drawing.Point(6, 21);
            this.rbMasterCard.Name = "rbMasterCard";
            this.rbMasterCard.Size = new System.Drawing.Size(102, 21);
            this.rbMasterCard.TabIndex = 0;
            this.rbMasterCard.TabStop = true;
            this.rbMasterCard.Text = "MasterCard";
            this.rbMasterCard.UseVisualStyleBackColor = true;
            this.rbMasterCard.CheckedChanged += new System.EventHandler(this.rbMasterCard_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUjTulajdonos);
            this.groupBox4.Controls.Add(this.lbTulajdonosok);
            this.groupBox4.Location = new System.Drawing.Point(12, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 201);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tulajdonos kiválasztása";
            // 
            // btnUjTulajdonos
            // 
            this.btnUjTulajdonos.Location = new System.Drawing.Point(6, 161);
            this.btnUjTulajdonos.Name = "btnUjTulajdonos";
            this.btnUjTulajdonos.Size = new System.Drawing.Size(204, 32);
            this.btnUjTulajdonos.TabIndex = 1;
            this.btnUjTulajdonos.Text = "Új tulajdonos létrehozása";
            this.btnUjTulajdonos.UseVisualStyleBackColor = true;
            this.btnUjTulajdonos.Click += new System.EventHandler(this.btnUjTulajdonos_Click);
            // 
            // lbTulajdonosok
            // 
            this.lbTulajdonosok.FormattingEnabled = true;
            this.lbTulajdonosok.ItemHeight = 16;
            this.lbTulajdonosok.Location = new System.Drawing.Point(7, 22);
            this.lbTulajdonosok.Name = "lbTulajdonosok";
            this.lbTulajdonosok.Size = new System.Drawing.Size(204, 132);
            this.lbTulajdonosok.TabIndex = 0;
            this.lbTulajdonosok.SelectedIndexChanged += new System.EventHandler(this.lbTulajdonosok_SelectedIndexChanged);
            // 
            // btnMentesKilepes
            // 
            this.btnMentesKilepes.ForeColor = System.Drawing.Color.Green;
            this.btnMentesKilepes.Location = new System.Drawing.Point(12, 345);
            this.btnMentesKilepes.Name = "btnMentesKilepes";
            this.btnMentesKilepes.Size = new System.Drawing.Size(292, 32);
            this.btnMentesKilepes.TabIndex = 4;
            this.btnMentesKilepes.Text = "Kártya lista mentése és kilépés";
            this.btnMentesKilepes.UseVisualStyleBackColor = true;
            this.btnMentesKilepes.Click += new System.EventHandler(this.btnMentesKilepes_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.ForeColor = System.Drawing.Color.Red;
            this.btnKilepes.Location = new System.Drawing.Point(337, 345);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(292, 32);
            this.btnKilepes.TabIndex = 5;
            this.btnKilepes.Text = "Kilépés mentés nélkül";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbTulajdonosTel);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.tbTulajdonosEmail);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.tbTulajdonosNeve);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(235, 193);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(394, 145);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tulajdonos adatai";
            // 
            // tbTulajdonosTel
            // 
            this.tbTulajdonosTel.Location = new System.Drawing.Point(198, 105);
            this.tbTulajdonosTel.Name = "tbTulajdonosTel";
            this.tbTulajdonosTel.ReadOnly = true;
            this.tbTulajdonosTel.Size = new System.Drawing.Size(190, 22);
            this.tbTulajdonosTel.TabIndex = 5;
            this.tbTulajdonosTel.Text = "(nincs kiválasztva tulajdonos)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefonszám";
            // 
            // tbTulajdonosEmail
            // 
            this.tbTulajdonosEmail.Location = new System.Drawing.Point(6, 105);
            this.tbTulajdonosEmail.Name = "tbTulajdonosEmail";
            this.tbTulajdonosEmail.ReadOnly = true;
            this.tbTulajdonosEmail.Size = new System.Drawing.Size(190, 22);
            this.tbTulajdonosEmail.TabIndex = 3;
            this.tbTulajdonosEmail.Text = "(nincs kiválasztva tulajdonos)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "E-mail cím";
            // 
            // tbTulajdonosNeve
            // 
            this.tbTulajdonosNeve.Location = new System.Drawing.Point(7, 43);
            this.tbTulajdonosNeve.Name = "tbTulajdonosNeve";
            this.tbTulajdonosNeve.ReadOnly = true;
            this.tbTulajdonosNeve.Size = new System.Drawing.Size(381, 22);
            this.tbTulajdonosNeve.TabIndex = 1;
            this.tbTulajdonosNeve.Text = "(nincs kiválasztva tulajdonos)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tulajdonos neve";
            // 
            // btnMentesListaba
            // 
            this.btnMentesListaba.Enabled = false;
            this.btnMentesListaba.ForeColor = System.Drawing.Color.Blue;
            this.btnMentesListaba.Location = new System.Drawing.Point(18, 293);
            this.btnMentesListaba.Name = "btnMentesListaba";
            this.btnMentesListaba.Size = new System.Drawing.Size(204, 32);
            this.btnMentesListaba.TabIndex = 2;
            this.btnMentesListaba.Text = "Kártya mentése listába";
            this.btnMentesListaba.UseVisualStyleBackColor = true;
            this.btnMentesListaba.Click += new System.EventHandler(this.btnMentesListaba_Click);
            // 
            // KartyaLetrehozas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 388);
            this.Controls.Add(this.btnMentesListaba);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnMentesKilepes);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(659, 435);
            this.MinimumSize = new System.Drawing.Size(659, 435);
            this.Name = "KartyaLetrehozas";
            this.Text = "Új kártya létrehozása";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCvc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpLejarat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBankkartyaSzam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbVisa;
        private System.Windows.Forms.RadioButton rbMasterCard;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUjTulajdonos;
        private System.Windows.Forms.ListBox lbTulajdonosok;
        private System.Windows.Forms.Button btnMentesKilepes;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbTulajdonosTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTulajdonosEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTulajdonosNeve;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMentesListaba;
    }
}