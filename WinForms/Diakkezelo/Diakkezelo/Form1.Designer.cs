namespace Diakkezelo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDiak = new System.Windows.Forms.Label();
            this.pnlEvek = new System.Windows.Forms.Panel();
            this.lstDiakok = new System.Windows.Forms.ListBox();
            this.lstEredmeny = new System.Windows.Forms.ListBox();
            this.btnAdatBe = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(82, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diákok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(412, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Születési év";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "A keresés eredménye:";
            // 
            // lblDiak
            // 
            this.lblDiak.AutoSize = true;
            this.lblDiak.Location = new System.Drawing.Point(299, 408);
            this.lblDiak.Name = "lblDiak";
            this.lblDiak.Size = new System.Drawing.Size(35, 13);
            this.lblDiak.TabIndex = 3;
            this.lblDiak.Text = "label4";
            // 
            // pnlEvek
            // 
            this.pnlEvek.AutoScroll = true;
            this.pnlEvek.Location = new System.Drawing.Point(302, 76);
            this.pnlEvek.Name = "pnlEvek";
            this.pnlEvek.Size = new System.Drawing.Size(374, 59);
            this.pnlEvek.TabIndex = 4;
            // 
            // lstDiakok
            // 
            this.lstDiakok.FormattingEnabled = true;
            this.lstDiakok.Location = new System.Drawing.Point(42, 76);
            this.lstDiakok.Name = "lstDiakok";
            this.lstDiakok.Size = new System.Drawing.Size(187, 316);
            this.lstDiakok.TabIndex = 5;
            // 
            // lstEredmeny
            // 
            this.lstEredmeny.FormattingEnabled = true;
            this.lstEredmeny.Location = new System.Drawing.Point(303, 175);
            this.lstEredmeny.Name = "lstEredmeny";
            this.lstEredmeny.Size = new System.Drawing.Size(374, 212);
            this.lstEredmeny.TabIndex = 6;
            this.lstEredmeny.SelectedIndexChanged += new System.EventHandler(this.lstEredmeny_SelectedIndexChanged);
            // 
            // btnAdatBe
            // 
            this.btnAdatBe.Location = new System.Drawing.Point(89, 398);
            this.btnAdatBe.Name = "btnAdatBe";
            this.btnAdatBe.Size = new System.Drawing.Size(75, 23);
            this.btnAdatBe.TabIndex = 7;
            this.btnAdatBe.Text = "Adatbevitel";
            this.btnAdatBe.UseVisualStyleBackColor = true;
            this.btnAdatBe.Click += new System.EventHandler(this.btnAdatBe_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.btnAdatBe);
            this.Controls.Add(this.lstEredmeny);
            this.Controls.Add(this.lstDiakok);
            this.Controls.Add(this.pnlEvek);
            this.Controls.Add(this.lblDiak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDiak;
        private System.Windows.Forms.Panel pnlEvek;
        private System.Windows.Forms.ListBox lstDiakok;
        private System.Windows.Forms.ListBox lstEredmeny;
        private System.Windows.Forms.Button btnAdatBe;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

