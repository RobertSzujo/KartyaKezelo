
namespace KartyaKezelo
{
    partial class KartyaEsTulajdonosLekerdezes
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
            this.tbTulajdonosNev = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTulajdonosTel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTulajdonosEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTulajdonosNev);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbTulajdonosTel);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbTulajdonosEmail);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(13, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 177);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tulajdonos adatai";
            // 
            // tbTulajdonosNev
            // 
            this.tbTulajdonosNev.Location = new System.Drawing.Point(7, 45);
            this.tbTulajdonosNev.Name = "tbTulajdonosNev";
            this.tbTulajdonosNev.ReadOnly = true;
            this.tbTulajdonosNev.Size = new System.Drawing.Size(297, 22);
            this.tbTulajdonosNev.TabIndex = 11;
            this.tbTulajdonosNev.Text = "null";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tulajdonos neve:";
            // 
            // tbTulajdonosTel
            // 
            this.tbTulajdonosTel.Location = new System.Drawing.Point(7, 135);
            this.tbTulajdonosTel.Name = "tbTulajdonosTel";
            this.tbTulajdonosTel.ReadOnly = true;
            this.tbTulajdonosTel.Size = new System.Drawing.Size(297, 22);
            this.tbTulajdonosTel.TabIndex = 9;
            this.tbTulajdonosTel.Text = "null";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Tulajdonos telefonszáma:";
            // 
            // tbTulajdonosEmail
            // 
            this.tbTulajdonosEmail.Location = new System.Drawing.Point(7, 90);
            this.tbTulajdonosEmail.Name = "tbTulajdonosEmail";
            this.tbTulajdonosEmail.ReadOnly = true;
            this.tbTulajdonosEmail.Size = new System.Drawing.Size(297, 22);
            this.tbTulajdonosEmail.TabIndex = 7;
            this.tbTulajdonosEmail.Text = "null";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Tulajdonos e-mail címe:";
            //
            // btnBezaras
            //
            this.btnBezaras.Location = new System.Drawing.Point(12, 458);
            // 
            // KartyaEsTulajdonosLekerdezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 502);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(353, 549);
            this.MinimumSize = new System.Drawing.Size(353, 549);
            this.Name = "KartyaEsTulajdonosLekerdezes";
            this.Text = "Részletes adatok";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.TextBox tbTulajdonosNev;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.TextBox tbTulajdonosTel;
        protected System.Windows.Forms.Label label12;
        protected System.Windows.Forms.TextBox tbTulajdonosEmail;
        protected System.Windows.Forms.Label label11;
    }
}