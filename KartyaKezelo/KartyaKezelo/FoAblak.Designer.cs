
namespace KartyaKezelo
{
    partial class FoAblak
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
            this.lbCards = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKartyaAdatok = new System.Windows.Forms.Button();
            this.btnKartyaEsTulajdonosAdatok = new System.Windows.Forms.Button();
            this.btnRemoveCard = new System.Windows.Forms.Button();
            this.btnDisableCard = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateCard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKartyaszam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKartyatulajdonos = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCards
            // 
            this.lbCards.FormattingEnabled = true;
            this.lbCards.ItemHeight = 16;
            this.lbCards.Location = new System.Drawing.Point(12, 34);
            this.lbCards.Name = "lbCards";
            this.lbCards.Size = new System.Drawing.Size(272, 308);
            this.lbCards.TabIndex = 0;
            this.lbCards.SelectedIndexChanged += new System.EventHandler(this.lbCards_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 337);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bankkártyák listája";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKartyaAdatok);
            this.groupBox2.Controls.Add(this.btnKartyaEsTulajdonosAdatok);
            this.groupBox2.Controls.Add(this.btnRemoveCard);
            this.groupBox2.Controls.Add(this.btnDisableCard);
            this.groupBox2.Location = new System.Drawing.Point(298, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 176);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Műveletek a kiválasztott kártyával";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnKartyaAdatok
            // 
            this.btnKartyaAdatok.Enabled = false;
            this.btnKartyaAdatok.Location = new System.Drawing.Point(6, 24);
            this.btnKartyaAdatok.Name = "btnKartyaAdatok";
            this.btnKartyaAdatok.Size = new System.Drawing.Size(478, 32);
            this.btnKartyaAdatok.TabIndex = 4;
            this.btnKartyaAdatok.Text = "Kártya adatainak lekérdezése";
            this.btnKartyaAdatok.UseVisualStyleBackColor = true;
            this.btnKartyaAdatok.Click += new System.EventHandler(this.btnKartyaAdatok_Click);
            // 
            // btnKartyaEsTulajdonosAdatok
            // 
            this.btnKartyaEsTulajdonosAdatok.Enabled = false;
            this.btnKartyaEsTulajdonosAdatok.Location = new System.Drawing.Point(6, 62);
            this.btnKartyaEsTulajdonosAdatok.Name = "btnKartyaEsTulajdonosAdatok";
            this.btnKartyaEsTulajdonosAdatok.Size = new System.Drawing.Size(478, 32);
            this.btnKartyaEsTulajdonosAdatok.TabIndex = 3;
            this.btnKartyaEsTulajdonosAdatok.Text = "Kártya és tulajdonos adatainak lekérdezése";
            this.btnKartyaEsTulajdonosAdatok.UseVisualStyleBackColor = true;
            this.btnKartyaEsTulajdonosAdatok.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnRemoveCard
            // 
            this.btnRemoveCard.Enabled = false;
            this.btnRemoveCard.Location = new System.Drawing.Point(6, 138);
            this.btnRemoveCard.Name = "btnRemoveCard";
            this.btnRemoveCard.Size = new System.Drawing.Size(478, 32);
            this.btnRemoveCard.TabIndex = 2;
            this.btnRemoveCard.Text = "Kártya törlése";
            this.btnRemoveCard.UseVisualStyleBackColor = true;
            // 
            // btnDisableCard
            // 
            this.btnDisableCard.Enabled = false;
            this.btnDisableCard.Location = new System.Drawing.Point(6, 100);
            this.btnDisableCard.Name = "btnDisableCard";
            this.btnDisableCard.Size = new System.Drawing.Size(478, 32);
            this.btnDisableCard.TabIndex = 1;
            this.btnDisableCard.Text = "Kártya letiltása";
            this.btnDisableCard.UseVisualStyleBackColor = true;
            this.btnDisableCard.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnCreateCard);
            this.groupBox3.Location = new System.Drawing.Point(298, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 99);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Egyéb műveletek";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(6, 59);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(478, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Kilépés a programból";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreateCard
            // 
            this.btnCreateCard.Location = new System.Drawing.Point(6, 21);
            this.btnCreateCard.Name = "btnCreateCard";
            this.btnCreateCard.Size = new System.Drawing.Size(478, 32);
            this.btnCreateCard.TabIndex = 3;
            this.btnCreateCard.Text = "Új kártya létrehozása";
            this.btnCreateCard.UseVisualStyleBackColor = true;
            this.btnCreateCard.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kiválasztott bankkártya:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tbKartyaszam
            // 
            this.tbKartyaszam.Location = new System.Drawing.Point(464, 12);
            this.tbKartyaszam.Name = "tbKartyaszam";
            this.tbKartyaszam.ReadOnly = true;
            this.tbKartyaszam.Size = new System.Drawing.Size(323, 22);
            this.tbKartyaszam.TabIndex = 8;
            this.tbKartyaszam.Text = "(nincs kiválasztva bankkártya)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bankkártya tulajdonosa:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbKartyatulajdonos
            // 
            this.tbKartyatulajdonos.Location = new System.Drawing.Point(464, 40);
            this.tbKartyatulajdonos.Name = "tbKartyatulajdonos";
            this.tbKartyatulajdonos.ReadOnly = true;
            this.tbKartyatulajdonos.Size = new System.Drawing.Size(323, 22);
            this.tbKartyatulajdonos.TabIndex = 10;
            this.tbKartyatulajdonos.Text = "(nincs kiválasztva bankkártya)";
            // 
            // FoAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.tbKartyatulajdonos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKartyaszam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbCards);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 409);
            this.MinimumSize = new System.Drawing.Size(818, 409);
            this.Name = "FoAblak";
            this.Text = "Bankkártya kezelő alkalamzás";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCards;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveCard;
        private System.Windows.Forms.Button btnDisableCard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCreateCard;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKartyaszam;
        private System.Windows.Forms.Button btnKartyaEsTulajdonosAdatok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKartyatulajdonos;
        private System.Windows.Forms.Button btnKartyaAdatok;
    }
}

