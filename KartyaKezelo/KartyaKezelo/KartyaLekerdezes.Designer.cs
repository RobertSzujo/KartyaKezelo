
namespace KartyaKezelo
{
    partial class KartyaLekerdezes
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
            this.tbKartyatipus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLejarat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKartyaszam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbCvc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLetiltva = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLetiltva);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbCvc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbKartyatipus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbLejarat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbKartyaszam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bankkártya adatai";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbKartyatipus
            // 
            this.tbKartyatipus.Location = new System.Drawing.Point(7, 44);
            this.tbKartyatipus.Name = "tbKartyatipus";
            this.tbKartyatipus.ReadOnly = true;
            this.tbKartyatipus.Size = new System.Drawing.Size(297, 22);
            this.tbKartyatipus.TabIndex = 5;
            this.tbKartyatipus.Text = "null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bankkártya típusa:";
            // 
            // tbLejarat
            // 
            this.tbLejarat.Location = new System.Drawing.Point(7, 134);
            this.tbLejarat.Name = "tbLejarat";
            this.tbLejarat.ReadOnly = true;
            this.tbLejarat.Size = new System.Drawing.Size(297, 22);
            this.tbLejarat.TabIndex = 3;
            this.tbLejarat.Text = "null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lejárat dátuma:";
            // 
            // tbKartyaszam
            // 
            this.tbKartyaszam.Location = new System.Drawing.Point(7, 89);
            this.tbKartyaszam.Name = "tbKartyaszam";
            this.tbKartyaszam.ReadOnly = true;
            this.tbKartyaszam.Size = new System.Drawing.Size(297, 22);
            this.tbKartyaszam.TabIndex = 1;
            this.tbKartyaszam.Text = "null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bankkártya száma:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(13, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ablak bezárása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCvc
            // 
            this.tbCvc.Location = new System.Drawing.Point(6, 179);
            this.tbCvc.Name = "tbCvc";
            this.tbCvc.ReadOnly = true;
            this.tbCvc.Size = new System.Drawing.Size(297, 22);
            this.tbCvc.TabIndex = 7;
            this.tbCvc.Text = "null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "CVC kód:";
            // 
            // tbLetiltva
            // 
            this.tbLetiltva.Location = new System.Drawing.Point(6, 224);
            this.tbLetiltva.Name = "tbLetiltva";
            this.tbLetiltva.ReadOnly = true;
            this.tbLetiltva.Size = new System.Drawing.Size(297, 22);
            this.tbLetiltva.TabIndex = 9;
            this.tbLetiltva.Text = "null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Letiltás állapota:";
            // 
            // KartyaLekerdezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "KartyaLekerdezes";
            this.Text = "Részletes adatok";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKartyatipus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLejarat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKartyaszam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbLetiltva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCvc;
        private System.Windows.Forms.Label label4;
    }
}