namespace pizza
{
    partial class PizzaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaForm));
            this.label5 = new System.Windows.Forms.Label();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnAdatBe = new System.Windows.Forms.Button();
            this.brnBezar = new System.Windows.Forms.Button();
            this.txtFizetendo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlKozponti = new System.Windows.Forms.Panel();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(189, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fizetendő:";
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(26, 348);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(75, 23);
            this.btnSzamol.TabIndex = 7;
            this.btnSzamol.Text = "Számol";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(26, 416);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 8;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnAdatBe
            // 
            this.btnAdatBe.Location = new System.Drawing.Point(229, 416);
            this.btnAdatBe.Name = "btnAdatBe";
            this.btnAdatBe.Size = new System.Drawing.Size(174, 23);
            this.btnAdatBe.TabIndex = 9;
            this.btnAdatBe.Text = "Adatbevitel";
            this.btnAdatBe.UseVisualStyleBackColor = true;
            // 
            // brnBezar
            // 
            this.brnBezar.Location = new System.Drawing.Point(552, 416);
            this.brnBezar.Name = "brnBezar";
            this.brnBezar.Size = new System.Drawing.Size(75, 23);
            this.brnBezar.TabIndex = 10;
            this.brnBezar.Text = "Bezár";
            this.brnBezar.UseVisualStyleBackColor = true;
            // 
            // txtFizetendo
            // 
            this.txtFizetendo.Enabled = false;
            this.txtFizetendo.Location = new System.Drawing.Point(303, 352);
            this.txtFizetendo.Name = "txtFizetendo";
            this.txtFizetendo.Size = new System.Drawing.Size(100, 20);
            this.txtFizetendo.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "MENÜVÁLASZTÉK";
            // 
            // pnlKozponti
            // 
            this.pnlKozponti.AutoScroll = true;
            this.pnlKozponti.Location = new System.Drawing.Point(57, 68);
            this.pnlKozponti.Name = "pnlKozponti";
            this.pnlKozponti.Size = new System.Drawing.Size(533, 249);
            this.pnlKozponti.TabIndex = 17;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 460);
            this.Controls.Add(this.pnlKozponti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFizetendo);
            this.Controls.Add(this.brnBezar);
            this.Controls.Add(this.btnAdatBe);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.label5);
            this.Name = "PizzaForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnAdatBe;
        private System.Windows.Forms.Button brnBezar;
        private System.Windows.Forms.TextBox txtFizetendo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlKozponti;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

