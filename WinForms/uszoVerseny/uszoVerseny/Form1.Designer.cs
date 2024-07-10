namespace uszoVerseny
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblResztvevok = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRajtszam = new System.Windows.Forms.TextBox();
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.txtIdoEredmeny = new System.Windows.Forms.TextBox();
            this.txtEletkor = new System.Windows.Forms.TextBox();
            this.btnGyoztes = new System.Windows.Forms.Button();
            this.txtGyoztesIdo = new System.Windows.Forms.TextBox();
            this.rchTxtGyoztes = new System.Windows.Forms.RichTextBox();
            this.btBezar = new System.Windows.Forms.Button();
            this.btnAdatBe = new System.Windows.Forms.Button();
            this.lstVersenyzok = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(282, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "200 m-es pillangó úszás";
            // 
            // lblResztvevok
            // 
            this.lblResztvevok.AutoSize = true;
            this.lblResztvevok.Location = new System.Drawing.Point(127, 66);
            this.lblResztvevok.Name = "lblResztvevok";
            this.lblResztvevok.Size = new System.Drawing.Size(64, 13);
            this.lblResztvevok.TabIndex = 1;
            this.lblResztvevok.Text = "Résztvevők";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rajtszám:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ország:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Időeredmény:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Életkor:";
            // 
            // txtRajtszam
            // 
            this.txtRajtszam.Location = new System.Drawing.Point(555, 74);
            this.txtRajtszam.Name = "txtRajtszam";
            this.txtRajtszam.Size = new System.Drawing.Size(100, 20);
            this.txtRajtszam.TabIndex = 7;
            // 
            // txtOrszag
            // 
            this.txtOrszag.Location = new System.Drawing.Point(555, 119);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.Size = new System.Drawing.Size(100, 20);
            this.txtOrszag.TabIndex = 8;
            // 
            // txtIdoEredmeny
            // 
            this.txtIdoEredmeny.Location = new System.Drawing.Point(555, 148);
            this.txtIdoEredmeny.Name = "txtIdoEredmeny";
            this.txtIdoEredmeny.Size = new System.Drawing.Size(100, 20);
            this.txtIdoEredmeny.TabIndex = 9;
            // 
            // txtEletkor
            // 
            this.txtEletkor.Location = new System.Drawing.Point(555, 182);
            this.txtEletkor.Name = "txtEletkor";
            this.txtEletkor.Size = new System.Drawing.Size(100, 20);
            this.txtEletkor.TabIndex = 10;
            // 
            // btnGyoztes
            // 
            this.btnGyoztes.Location = new System.Drawing.Point(466, 226);
            this.btnGyoztes.Name = "btnGyoztes";
            this.btnGyoztes.Size = new System.Drawing.Size(75, 23);
            this.btnGyoztes.TabIndex = 11;
            this.btnGyoztes.Text = "Győztes";
            this.btnGyoztes.UseVisualStyleBackColor = true;
            this.btnGyoztes.Click += new System.EventHandler(this.btGyoztes_Click);
            // 
            // txtGyoztesIdo
            // 
            this.txtGyoztesIdo.Location = new System.Drawing.Point(575, 228);
            this.txtGyoztesIdo.Name = "txtGyoztesIdo";
            this.txtGyoztesIdo.Size = new System.Drawing.Size(100, 20);
            this.txtGyoztesIdo.TabIndex = 12;
            // 
            // rchTxtGyoztes
            // 
            this.rchTxtGyoztes.Location = new System.Drawing.Point(466, 269);
            this.rchTxtGyoztes.Name = "rchTxtGyoztes";
            this.rchTxtGyoztes.Size = new System.Drawing.Size(209, 91);
            this.rchTxtGyoztes.TabIndex = 13;
            this.rchTxtGyoztes.Text = "";
            // 
            // btBezar
            // 
            this.btBezar.Location = new System.Drawing.Point(537, 375);
            this.btBezar.Name = "btBezar";
            this.btBezar.Size = new System.Drawing.Size(75, 23);
            this.btBezar.TabIndex = 14;
            this.btBezar.Text = "Bezár";
            this.btBezar.UseVisualStyleBackColor = true;
            this.btBezar.Click += new System.EventHandler(this.btBezar_Click);
            // 
            // btnAdatBe
            // 
            this.btnAdatBe.Location = new System.Drawing.Point(104, 375);
            this.btnAdatBe.Name = "btnAdatBe";
            this.btnAdatBe.Size = new System.Drawing.Size(123, 23);
            this.btnAdatBe.TabIndex = 15;
            this.btnAdatBe.Text = "Adatok beolvasása";
            this.btnAdatBe.UseVisualStyleBackColor = true;
            // 
            // lstVersenyzok
            // 
            this.lstVersenyzok.FormattingEnabled = true;
            this.lstVersenyzok.Location = new System.Drawing.Point(85, 82);
            this.lstVersenyzok.Name = "lstVersenyzok";
            this.lstVersenyzok.Size = new System.Drawing.Size(169, 277);
            this.lstVersenyzok.Sorted = true;
            this.lstVersenyzok.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstVersenyzok);
            this.Controls.Add(this.btnAdatBe);
            this.Controls.Add(this.btBezar);
            this.Controls.Add(this.rchTxtGyoztes);
            this.Controls.Add(this.txtGyoztesIdo);
            this.Controls.Add(this.btnGyoztes);
            this.Controls.Add(this.txtEletkor);
            this.Controls.Add(this.txtIdoEredmeny);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.txtRajtszam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResztvevok);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResztvevok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRajtszam;
        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.TextBox txtIdoEredmeny;
        private System.Windows.Forms.TextBox txtEletkor;
        private System.Windows.Forms.Button btnGyoztes;
        private System.Windows.Forms.TextBox txtGyoztesIdo;
        private System.Windows.Forms.RichTextBox rchTxtGyoztes;
        private System.Windows.Forms.Button btBezar;
        private System.Windows.Forms.Button btnAdatBe;
        private System.Windows.Forms.ListBox lstVersenyzok;
    }
}

