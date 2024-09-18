namespace CalculatorWindowsFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Operasi = new Label();
            NilaiB = new Label();
            btnHitung = new Button();
            txtNilaiA = new TextBox();
            txtNilaiB = new TextBox();
            hasil = new GroupBox();
            lstHasil = new ListBox();
            comboBoxOperasi = new ComboBox();
            label1 = new Label();
            bersihkan = new Button();
            hasil.SuspendLayout();
            SuspendLayout();
            // 
            // Operasi
            // 
            Operasi.AutoSize = true;
            Operasi.Location = new Point(12, 15);
            Operasi.Name = "Operasi";
            Operasi.Size = new Size(60, 20);
            Operasi.TabIndex = 0;
            Operasi.Text = "Operasi";
            Operasi.Click += NilaiA_Click;
            // 
            // NilaiB
            // 
            NilaiB.AutoSize = true;
            NilaiB.Location = new Point(12, 81);
            NilaiB.Name = "NilaiB";
            NilaiB.Size = new Size(53, 20);
            NilaiB.TabIndex = 1;
            NilaiB.Text = "Nilai B";
            // 
            // btnHitung
            // 
            btnHitung.Location = new Point(78, 116);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(90, 28);
            btnHitung.TabIndex = 2;
            btnHitung.Text = "Hitung";
            btnHitung.UseVisualStyleBackColor = true;
            btnHitung.Click += btnHitung_Click;
            // 
            // txtNilaiA
            // 
            txtNilaiA.Location = new Point(78, 46);
            txtNilaiA.Name = "txtNilaiA";
            txtNilaiA.Size = new Size(245, 26);
            txtNilaiA.TabIndex = 3;
            txtNilaiA.TextChanged += txtNilaiA_TextChanged;
            // 
            // txtNilaiB
            // 
            txtNilaiB.Location = new Point(78, 78);
            txtNilaiB.Name = "txtNilaiB";
            txtNilaiB.Size = new Size(245, 26);
            txtNilaiB.TabIndex = 4;
            txtNilaiB.TextChanged += textBox2_TextChanged;
            // 
            // hasil
            // 
            hasil.Controls.Add(lstHasil);
            hasil.Location = new Point(12, 150);
            hasil.Name = "hasil";
            hasil.Size = new Size(345, 215);
            hasil.TabIndex = 5;
            hasil.TabStop = false;
            hasil.Text = "{HASIL}";
            // 
            // lstHasil
            // 
            lstHasil.FormattingEnabled = true;
            lstHasil.Location = new Point(6, 25);
            lstHasil.Name = "lstHasil";
            lstHasil.Size = new Size(333, 175);
            lstHasil.TabIndex = 0;
            lstHasil.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // comboBoxOperasi
            // 
            comboBoxOperasi.FormattingEnabled = true;
            comboBoxOperasi.Items.AddRange(new object[] { "Penambahan", "Pengurangan", "Perkalian", "Pembagian" });
            comboBoxOperasi.Location = new Point(78, 12);
            comboBoxOperasi.Name = "comboBoxOperasi";
            comboBoxOperasi.Size = new Size(145, 27);
            comboBoxOperasi.TabIndex = 6;
            comboBoxOperasi.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 49);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 7;
            label1.Text = "Nilai A";
            // 
            // bersihkan
            // 
            bersihkan.Location = new Point(218, 116);
            bersihkan.Name = "bersihkan";
            bersihkan.Size = new Size(90, 28);
            bersihkan.TabIndex = 8;
            bersihkan.Text = "Bersihkan\r\n";
            bersihkan.UseVisualStyleBackColor = true;
            bersihkan.Click += bersihkan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 399);
            Controls.Add(bersihkan);
            Controls.Add(label1);
            Controls.Add(comboBoxOperasi);
            Controls.Add(hasil);
            Controls.Add(txtNilaiB);
            Controls.Add(txtNilaiA);
            Controls.Add(btnHitung);
            Controls.Add(NilaiB);
            Controls.Add(Operasi);
            Name = "Form1";
            Text = "Form1";
            hasil.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Operasi;
        private Label NilaiB;
        private Button btnHitung;
        private TextBox txtNilaiA;
        private TextBox txtNilaiB;
        private GroupBox hasil;
        private ListBox lstHasil;
        private ComboBox comboBoxOperasi;
        private Label label1;
        private Button bersihkan;
    }
}
