namespace bevasarlolista
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
            this.rtbadatok = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtermek = new System.Windows.Forms.TextBox();
            this.txar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbadat1 = new System.Windows.Forms.Label();
            this.lbadat2 = new System.Windows.Forms.Label();
            this.lbadat3 = new System.Windows.Forms.Label();
            this.btsave = new System.Windows.Forms.Button();
            this.xbmennyiseg = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbfizetendo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fájlban szereplő adatokű";
            // 
            // rtbadatok
            // 
            this.rtbadatok.Location = new System.Drawing.Point(12, 43);
            this.rtbadatok.Name = "rtbadatok";
            this.rtbadatok.ReadOnly = true;
            this.rtbadatok.Size = new System.Drawing.Size(230, 229);
            this.rtbadatok.TabIndex = 1;
            this.rtbadatok.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Termék";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Egység ár";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ft";
            // 
            // txtermek
            // 
            this.txtermek.Location = new System.Drawing.Point(297, 40);
            this.txtermek.Name = "txtermek";
            this.txtermek.Size = new System.Drawing.Size(151, 20);
            this.txtermek.TabIndex = 5;
            // 
            // txar
            // 
            this.txar.Location = new System.Drawing.Point(314, 66);
            this.txar.Name = "txar";
            this.txar.Size = new System.Drawing.Size(100, 20);
            this.txar.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mennyiség";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tétel fizetendő: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Fuchsia;
            this.groupBox1.Controls.Add(this.lbadat3);
            this.groupBox1.Controls.Add(this.lbadat2);
            this.groupBox1.Controls.Add(this.lbadat1);
            this.groupBox1.Location = new System.Drawing.Point(248, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adatok";
            // 
            // lbadat1
            // 
            this.lbadat1.AutoSize = true;
            this.lbadat1.Location = new System.Drawing.Point(7, 20);
            this.lbadat1.Name = "lbadat1";
            this.lbadat1.Size = new System.Drawing.Size(132, 13);
            this.lbadat1.TabIndex = 0;
            this.lbadat1.Text = "Fizetendő ár:  5489 Ft";
            // 
            // lbadat2
            // 
            this.lbadat2.AutoSize = true;
            this.lbadat2.Location = new System.Drawing.Point(7, 43);
            this.lbadat2.Name = "lbadat2";
            this.lbadat2.Size = new System.Drawing.Size(122, 13);
            this.lbadat2.TabIndex = 1;
            this.lbadat2.Text = "Tételek száma: 8 db";
            // 
            // lbadat3
            // 
            this.lbadat3.AutoSize = true;
            this.lbadat3.Location = new System.Drawing.Point(10, 69);
            this.lbadat3.Name = "lbadat3";
            this.lbadat3.Size = new System.Drawing.Size(156, 13);
            this.lbadat3.TabIndex = 2;
            this.lbadat3.Text = "Legdrágább termék:  kávé";
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(454, 40);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(112, 124);
            this.btsave.TabIndex = 11;
            this.btsave.Text = "Mentés";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // xbmennyiseg
            // 
            this.xbmennyiseg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xbmennyiseg.FormattingEnabled = true;
            this.xbmennyiseg.Location = new System.Drawing.Point(319, 98);
            this.xbmennyiseg.Name = "xbmennyiseg";
            this.xbmennyiseg.Size = new System.Drawing.Size(58, 21);
            this.xbmennyiseg.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(383, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "db";
            // 
            // lbfizetendo
            // 
            this.lbfizetendo.AutoSize = true;
            this.lbfizetendo.Location = new System.Drawing.Point(352, 128);
            this.lbfizetendo.Name = "lbfizetendo";
            this.lbfizetendo.Size = new System.Drawing.Size(48, 13);
            this.lbfizetendo.TabIndex = 14;
            this.lbfizetendo.Text = "label11";
            this.lbfizetendo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(578, 286);
            this.Controls.Add(this.lbfizetendo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.xbmennyiseg);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txar);
            this.Controls.Add(this.txtermek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbadatok);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Bevásárló lista";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbadatok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtermek;
        private System.Windows.Forms.TextBox txar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbadat1;
        private System.Windows.Forms.Label lbadat3;
        private System.Windows.Forms.Label lbadat2;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.ComboBox xbmennyiseg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbfizetendo;
    }
}

