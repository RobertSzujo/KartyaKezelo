
namespace KartyaKezelo
{
    partial class TulajdonosLetrehozas
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
            this.tbTulajdonosTel = new System.Windows.Forms.TextBox();
            this.tbTulajdonosNeve = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTulajdonosEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMentesKilepes = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTulajdonosTel);
            this.groupBox1.Controls.Add(this.tbTulajdonosNeve);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbTulajdonosEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tulajdonos adatai";
            // 
            // tbTulajdonosTel
            // 
            this.tbTulajdonosTel.Location = new System.Drawing.Point(6, 135);
            this.tbTulajdonosTel.Name = "tbTulajdonosTel";
            this.tbTulajdonosTel.Size = new System.Drawing.Size(297, 22);
            this.tbTulajdonosTel.TabIndex = 19;
            // 
            // tbTulajdonosNeve
            // 
            this.tbTulajdonosNeve.Location = new System.Drawing.Point(6, 45);
            this.tbTulajdonosNeve.Name = "tbTulajdonosNeve";
            this.tbTulajdonosNeve.Size = new System.Drawing.Size(297, 22);
            this.tbTulajdonosNeve.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tulajdonos telefonszáma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tulajdonos neve:";
            // 
            // tbTulajdonosEmail
            // 
            this.tbTulajdonosEmail.Location = new System.Drawing.Point(6, 90);
            this.tbTulajdonosEmail.Name = "tbTulajdonosEmail";
            this.tbTulajdonosEmail.Size = new System.Drawing.Size(297, 22);
            this.tbTulajdonosEmail.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tulajdonos e-mail címe:";
            // 
            // btnMentesKilepes
            // 
            this.btnMentesKilepes.ForeColor = System.Drawing.Color.Green;
            this.btnMentesKilepes.Location = new System.Drawing.Point(13, 191);
            this.btnMentesKilepes.Name = "btnMentesKilepes";
            this.btnMentesKilepes.Size = new System.Drawing.Size(312, 32);
            this.btnMentesKilepes.TabIndex = 1;
            this.btnMentesKilepes.Text = "Új tulajdonos mentése és kilépés";
            this.btnMentesKilepes.UseVisualStyleBackColor = true;
            this.btnMentesKilepes.Click += new System.EventHandler(this.btnMentesKilepes_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.ForeColor = System.Drawing.Color.Red;
            this.btnKilepes.Location = new System.Drawing.Point(14, 229);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(312, 32);
            this.btnKilepes.TabIndex = 2;
            this.btnKilepes.Text = "Mentés kilépés nélkül";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.button2_Click);
            // 
            // TulajdonosLetrehozas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 276);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnMentesKilepes);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(356, 323);
            this.MinimumSize = new System.Drawing.Size(356, 323);
            this.Name = "TulajdonosLetrehozas";
            this.Text = "Új tulajdonos létrehozása";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTulajdonosTel;
        private System.Windows.Forms.TextBox tbTulajdonosNeve;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTulajdonosEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMentesKilepes;
        private System.Windows.Forms.Button btnKilepes;
    }
}