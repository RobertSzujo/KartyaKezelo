
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
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tulajdonos adatai";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 135);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(297, 22);
            this.textBox7.TabIndex = 19;
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 90);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(297, 22);
            this.textBox6.TabIndex = 17;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(297, 22);
            this.textBox5.TabIndex = 15;
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
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(13, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Új tulajdonos mentése és kilépés";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(14, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Mentés kilépés nélkül";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TulajdonosLetrehozas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 276);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}