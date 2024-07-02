namespace jatekadatumokkal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEvSzam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNapSorszam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKesobbiDatum = new System.Windows.Forms.TextBox();
            this.txtNapSzam = new System.Windows.Forms.TextBox();
            this.btnKiir = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnBezár = new System.Windows.Forms.Button();
            this.IbIDatum = new System.Windows.Forms.Label();
            this.IbIGratulacio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mskdTxtSzulDatum = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pontos dátum és idő:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Születési dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ennyi éves vagy:";
            // 
            // txtEvSzam
            // 
            this.txtEvSzam.Location = new System.Drawing.Point(199, 169);
            this.txtEvSzam.Name = "txtEvSzam";
            this.txtEvSzam.Size = new System.Drawing.Size(100, 20);
            this.txtEvSzam.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ilyen napon születtél:";
            // 
            // txtNap
            // 
            this.txtNap.Location = new System.Drawing.Point(635, 172);
            this.txtNap.Name = "txtNap";
            this.txtNap.Size = new System.Drawing.Size(100, 20);
            this.txtNap.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tetszőleges dátum:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 358);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ez az év ennyiedik napja:";
            // 
            // txtNapSorszam
            // 
            this.txtNapSorszam.Location = new System.Drawing.Point(635, 322);
            this.txtNapSorszam.Name = "txtNapSorszam";
            this.txtNapSorszam.Size = new System.Drawing.Size(100, 20);
            this.txtNapSorszam.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "nappal későbbi dátum:";
            // 
            // txtKesobbiDatum
            // 
            this.txtKesobbiDatum.Location = new System.Drawing.Point(635, 379);
            this.txtKesobbiDatum.Name = "txtKesobbiDatum";
            this.txtKesobbiDatum.Size = new System.Drawing.Size(100, 20);
            this.txtKesobbiDatum.TabIndex = 12;
            // 
            // txtNapSzam
            // 
            this.txtNapSzam.Location = new System.Drawing.Point(432, 379);
            this.txtNapSzam.Name = "txtNapSzam";
            this.txtNapSzam.Size = new System.Drawing.Size(49, 20);
            this.txtNapSzam.TabIndex = 13;
            this.txtNapSzam.TextChanged += new System.EventHandler(this.txtNapSzam_TextChanged);
            // 
            // btnKiir
            // 
            this.btnKiir.Location = new System.Drawing.Point(173, 415);
            this.btnKiir.Name = "btnKiir";
            this.btnKiir.Size = new System.Drawing.Size(75, 23);
            this.btnKiir.TabIndex = 14;
            this.btnKiir.Text = "Kiír";
            this.btnKiir.UseVisualStyleBackColor = true;
            this.btnKiir.Click += new System.EventHandler(this.btnKiir_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(386, 415);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 15;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnBezár
            // 
            this.btnBezár.Location = new System.Drawing.Point(599, 415);
            this.btnBezár.Name = "btnBezár";
            this.btnBezár.Size = new System.Drawing.Size(75, 23);
            this.btnBezár.TabIndex = 16;
            this.btnBezár.Text = "Bezár";
            this.btnBezár.UseVisualStyleBackColor = true;
            this.btnBezár.Click += new System.EventHandler(this.btnBezár_Click);
            // 
            // IbIDatum
            // 
            this.IbIDatum.AutoSize = true;
            this.IbIDatum.Location = new System.Drawing.Point(300, 43);
            this.IbIDatum.Name = "IbIDatum";
            this.IbIDatum.Size = new System.Drawing.Size(10, 13);
            this.IbIDatum.TabIndex = 17;
            this.IbIDatum.Text = ".";
            this.IbIDatum.Click += new System.EventHandler(this.IbIDatum_Click);
            // 
            // IbIGratulacio
            // 
            this.IbIGratulacio.AutoSize = true;
            this.IbIGratulacio.Location = new System.Drawing.Point(386, 251);
            this.IbIGratulacio.Name = "IbIGratulacio";
            this.IbIGratulacio.Size = new System.Drawing.Size(10, 13);
            this.IbIGratulacio.TabIndex = 18;
            this.IbIGratulacio.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mskdTxtSzulDatum
            // 
            this.mskdTxtSzulDatum.Location = new System.Drawing.Point(199, 106);
            this.mskdTxtSzulDatum.Mask = "0000-00-00";
            this.mskdTxtSzulDatum.Name = "mskdTxtSzulDatum";
            this.mskdTxtSzulDatum.Size = new System.Drawing.Size(100, 20);
            this.mskdTxtSzulDatum.TabIndex = 19;
            this.mskdTxtSzulDatum.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskdTxtSzulDatum_MaskInputRejected);
            this.mskdTxtSzulDatum.Leave += new System.EventHandler(this.maskedTextBox1_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mskdTxtSzulDatum);
            this.Controls.Add(this.IbIGratulacio);
            this.Controls.Add(this.IbIDatum);
            this.Controls.Add(this.btnBezár);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnKiir);
            this.Controls.Add(this.txtNapSzam);
            this.Controls.Add(this.txtKesobbiDatum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNapSorszam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEvSzam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dátum és idő kezelése";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEvSzam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNapSorszam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKesobbiDatum;
        private System.Windows.Forms.TextBox txtNapSzam;
        private System.Windows.Forms.Button btnKiir;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnBezár;
        private System.Windows.Forms.Label IbIDatum;
        private System.Windows.Forms.Label IbIGratulacio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox mskdTxtSzulDatum;
    }
}

