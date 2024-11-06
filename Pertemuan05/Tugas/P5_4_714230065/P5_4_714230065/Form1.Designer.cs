namespace P5_4_714230065
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
            this.labelNama = new System.Windows.Forms.Label();
            this.labelJK = new System.Windows.Forms.Label();
            this.labelTL = new System.Windows.Forms.Label();
            this.nama1 = new System.Windows.Forms.TextBox();
            this.PilihJk = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pilihKelas = new System.Windows.Forms.GroupBox();
            this.pilihJdw = new System.Windows.Forms.GroupBox();
            this.seninRabu = new System.Windows.Forms.RadioButton();
            this.selasaKamis = new System.Windows.Forms.RadioButton();
            this.sabtuMinggu = new System.Windows.Forms.RadioButton();
            this.minngu = new System.Windows.Forms.RadioButton();
            this.checkSepakBola = new System.Windows.Forms.CheckBox();
            this.checkRenang = new System.Windows.Forms.CheckBox();
            this.buttonTampilkan = new System.Windows.Forms.Button();
            this.checkYoga = new System.Windows.Forms.CheckBox();
            this.buttonSelesai = new System.Windows.Forms.Button();
            this.checkTenis = new System.Windows.Forms.CheckBox();
            this.checkBasket = new System.Windows.Forms.CheckBox();
            this.checkBuluTangkis = new System.Windows.Forms.CheckBox();
            this.checkVoli = new System.Windows.Forms.CheckBox();
            this.checkPanahan = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pilihKelas.SuspendLayout();
            this.pilihJdw.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(128, 74);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(48, 16);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "Nama";
            this.labelNama.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelJK
            // 
            this.labelJK.AutoSize = true;
            this.labelJK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJK.Location = new System.Drawing.Point(128, 117);
            this.labelJK.Name = "labelJK";
            this.labelJK.Size = new System.Drawing.Size(103, 16);
            this.labelJK.TabIndex = 1;
            this.labelJK.Text = "Jenis Kelamin";
            // 
            // labelTL
            // 
            this.labelTL.AutoSize = true;
            this.labelTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTL.Location = new System.Drawing.Point(128, 161);
            this.labelTL.Name = "labelTL";
            this.labelTL.Size = new System.Drawing.Size(103, 16);
            this.labelTL.TabIndex = 2;
            this.labelTL.Text = "Tanggal Lahir";
            // 
            // nama1
            // 
            this.nama1.Location = new System.Drawing.Point(275, 68);
            this.nama1.Name = "nama1";
            this.nama1.Size = new System.Drawing.Size(200, 22);
            this.nama1.TabIndex = 3;
            this.nama1.Text = "te";
            this.nama1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PilihJk
            // 
            this.PilihJk.FormattingEnabled = true;
            this.PilihJk.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.PilihJk.Location = new System.Drawing.Point(275, 109);
            this.PilihJk.MaxLength = 10;
            this.PilihJk.Name = "PilihJk";
            this.PilihJk.Size = new System.Drawing.Size(200, 24);
            this.PilihJk.TabIndex = 4;
            this.PilihJk.Text = "--Pilih Jenis Kelamin--";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(275, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pilihKelas
            // 
            this.pilihKelas.Controls.Add(this.checkSepakBola);
            this.pilihKelas.Controls.Add(this.checkPanahan);
            this.pilihKelas.Controls.Add(this.checkRenang);
            this.pilihKelas.Controls.Add(this.checkVoli);
            this.pilihKelas.Controls.Add(this.checkTenis);
            this.pilihKelas.Controls.Add(this.checkBuluTangkis);
            this.pilihKelas.Controls.Add(this.checkYoga);
            this.pilihKelas.Controls.Add(this.checkBasket);
            this.pilihKelas.Location = new System.Drawing.Point(41, 212);
            this.pilihKelas.Name = "pilihKelas";
            this.pilihKelas.Size = new System.Drawing.Size(229, 138);
            this.pilihKelas.TabIndex = 6;
            this.pilihKelas.TabStop = false;
            this.pilihKelas.Text = "Pilih Olahraga";
            // 
            // pilihJdw
            // 
            this.pilihJdw.Controls.Add(this.seninRabu);
            this.pilihJdw.Controls.Add(this.selasaKamis);
            this.pilihJdw.Controls.Add(this.sabtuMinggu);
            this.pilihJdw.Controls.Add(this.minngu);
            this.pilihJdw.Location = new System.Drawing.Point(315, 212);
            this.pilihJdw.Name = "pilihJdw";
            this.pilihJdw.Size = new System.Drawing.Size(229, 138);
            this.pilihJdw.TabIndex = 7;
            this.pilihJdw.TabStop = false;
            this.pilihJdw.Text = "Pilih Jadwal";
            // 
            // seninRabu
            // 
            this.seninRabu.AutoSize = true;
            this.seninRabu.Location = new System.Drawing.Point(6, 21);
            this.seninRabu.Name = "seninRabu";
            this.seninRabu.Size = new System.Drawing.Size(192, 20);
            this.seninRabu.TabIndex = 8;
            this.seninRabu.TabStop = true;
            this.seninRabu.Text = "Senin s/d Rabu, 14.00-16.00";
            this.seninRabu.UseVisualStyleBackColor = true;
            // 
            // selasaKamis
            // 
            this.selasaKamis.AutoSize = true;
            this.selasaKamis.Location = new System.Drawing.Point(6, 47);
            this.selasaKamis.Name = "selasaKamis";
            this.selasaKamis.Size = new System.Drawing.Size(205, 20);
            this.selasaKamis.TabIndex = 9;
            this.selasaKamis.TabStop = true;
            this.selasaKamis.Text = "Selasa s/d Kamis, 14.00-16.00";
            this.selasaKamis.UseVisualStyleBackColor = true;
            // 
            // sabtuMinggu
            // 
            this.sabtuMinggu.AutoSize = true;
            this.sabtuMinggu.Location = new System.Drawing.Point(7, 74);
            this.sabtuMinggu.Name = "sabtuMinggu";
            this.sabtuMinggu.Size = new System.Drawing.Size(204, 20);
            this.sabtuMinggu.TabIndex = 10;
            this.sabtuMinggu.TabStop = true;
            this.sabtuMinggu.Text = "Sabtu s/d Minggu, 19.00-11.00";
            this.sabtuMinggu.UseVisualStyleBackColor = true;
            // 
            // minngu
            // 
            this.minngu.AutoSize = true;
            this.minngu.Location = new System.Drawing.Point(7, 100);
            this.minngu.Name = "minngu";
            this.minngu.Size = new System.Drawing.Size(144, 20);
            this.minngu.TabIndex = 11;
            this.minngu.TabStop = true;
            this.minngu.Text = "Minggu, 13.00-20.00";
            this.minngu.UseVisualStyleBackColor = true;
            // 
            // checkSepakBola
            // 
            this.checkSepakBola.AutoSize = true;
            this.checkSepakBola.Location = new System.Drawing.Point(6, 25);
            this.checkSepakBola.Name = "checkSepakBola";
            this.checkSepakBola.Size = new System.Drawing.Size(100, 20);
            this.checkSepakBola.TabIndex = 12;
            this.checkSepakBola.Text = "Sepak Bola";
            this.checkSepakBola.UseVisualStyleBackColor = true;
            this.checkSepakBola.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkRenang
            // 
            this.checkRenang.AutoSize = true;
            this.checkRenang.Location = new System.Drawing.Point(6, 51);
            this.checkRenang.Name = "checkRenang";
            this.checkRenang.Size = new System.Drawing.Size(77, 20);
            this.checkRenang.TabIndex = 13;
            this.checkRenang.Text = "Renang";
            this.checkRenang.UseVisualStyleBackColor = true;
            this.checkRenang.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // buttonTampilkan
            // 
            this.buttonTampilkan.Location = new System.Drawing.Point(177, 367);
            this.buttonTampilkan.Name = "buttonTampilkan";
            this.buttonTampilkan.Size = new System.Drawing.Size(93, 23);
            this.buttonTampilkan.TabIndex = 14;
            this.buttonTampilkan.Text = "Tampilkan";
            this.buttonTampilkan.UseVisualStyleBackColor = true;
            this.buttonTampilkan.Click += new System.EventHandler(this.buttonTampilkan_Click);
            // 
            // checkYoga
            // 
            this.checkYoga.AutoSize = true;
            this.checkYoga.Location = new System.Drawing.Point(6, 105);
            this.checkYoga.Name = "checkYoga";
            this.checkYoga.Size = new System.Drawing.Size(62, 20);
            this.checkYoga.TabIndex = 15;
            this.checkYoga.Text = "Yoga";
            this.checkYoga.UseVisualStyleBackColor = true;
            // 
            // buttonSelesai
            // 
            this.buttonSelesai.Location = new System.Drawing.Point(315, 367);
            this.buttonSelesai.Name = "buttonSelesai";
            this.buttonSelesai.Size = new System.Drawing.Size(75, 23);
            this.buttonSelesai.TabIndex = 16;
            this.buttonSelesai.Text = "Selesai";
            this.buttonSelesai.UseVisualStyleBackColor = true;
            this.buttonSelesai.Click += new System.EventHandler(this.buttonSelesai_Click);
            // 
            // checkTenis
            // 
            this.checkTenis.AutoSize = true;
            this.checkTenis.Location = new System.Drawing.Point(6, 79);
            this.checkTenis.Name = "checkTenis";
            this.checkTenis.Size = new System.Drawing.Size(63, 20);
            this.checkTenis.TabIndex = 17;
            this.checkTenis.Text = "Tenis";
            this.checkTenis.UseVisualStyleBackColor = true;
            this.checkTenis.CheckedChanged += new System.EventHandler(this.checkTenis_CheckedChanged);
            // 
            // checkBasket
            // 
            this.checkBasket.AutoSize = true;
            this.checkBasket.Location = new System.Drawing.Point(109, 25);
            this.checkBasket.Name = "checkBasket";
            this.checkBasket.Size = new System.Drawing.Size(71, 20);
            this.checkBasket.TabIndex = 18;
            this.checkBasket.Text = "Basket";
            this.checkBasket.UseVisualStyleBackColor = true;
            // 
            // checkBuluTangkis
            // 
            this.checkBuluTangkis.AutoSize = true;
            this.checkBuluTangkis.Location = new System.Drawing.Point(109, 51);
            this.checkBuluTangkis.Name = "checkBuluTangkis";
            this.checkBuluTangkis.Size = new System.Drawing.Size(107, 20);
            this.checkBuluTangkis.TabIndex = 19;
            this.checkBuluTangkis.Text = "Bulu Tangkis";
            this.checkBuluTangkis.UseVisualStyleBackColor = true;
            // 
            // checkVoli
            // 
            this.checkVoli.AutoSize = true;
            this.checkVoli.Location = new System.Drawing.Point(109, 79);
            this.checkVoli.Name = "checkVoli";
            this.checkVoli.Size = new System.Drawing.Size(52, 20);
            this.checkVoli.TabIndex = 20;
            this.checkVoli.Text = "Voli";
            this.checkVoli.UseVisualStyleBackColor = true;
            // 
            // checkPanahan
            // 
            this.checkPanahan.AutoSize = true;
            this.checkPanahan.Location = new System.Drawing.Point(109, 105);
            this.checkPanahan.Name = "checkPanahan";
            this.checkPanahan.Size = new System.Drawing.Size(83, 20);
            this.checkPanahan.TabIndex = 21;
            this.checkPanahan.Text = "Panahan";
            this.checkPanahan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(193, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "FORM PENDAFTARAN";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSelesai);
            this.Controls.Add(this.buttonTampilkan);
            this.Controls.Add(this.pilihJdw);
            this.Controls.Add(this.pilihKelas);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.PilihJk);
            this.Controls.Add(this.nama1);
            this.Controls.Add(this.labelTL);
            this.Controls.Add(this.labelJK);
            this.Controls.Add(this.labelNama);
            this.Name = "Form1";
            this.Text = "ULBI SPORT SCHOOL";
            this.pilihKelas.ResumeLayout(false);
            this.pilihKelas.PerformLayout();
            this.pilihJdw.ResumeLayout(false);
            this.pilihJdw.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelJK;
        private System.Windows.Forms.Label labelTL;
        private System.Windows.Forms.TextBox nama1;
        private System.Windows.Forms.ComboBox PilihJk;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox pilihKelas;
        private System.Windows.Forms.GroupBox pilihJdw;
        private System.Windows.Forms.RadioButton seninRabu;
        private System.Windows.Forms.RadioButton selasaKamis;
        private System.Windows.Forms.RadioButton sabtuMinggu;
        private System.Windows.Forms.RadioButton minngu;
        private System.Windows.Forms.CheckBox checkSepakBola;
        private System.Windows.Forms.CheckBox checkRenang;
        private System.Windows.Forms.Button buttonTampilkan;
        private System.Windows.Forms.CheckBox checkYoga;
        private System.Windows.Forms.Button buttonSelesai;
        private System.Windows.Forms.CheckBox checkTenis;
        private System.Windows.Forms.CheckBox checkBasket;
        private System.Windows.Forms.CheckBox checkBuluTangkis;
        private System.Windows.Forms.CheckBox checkVoli;
        private System.Windows.Forms.CheckBox checkPanahan;
        private System.Windows.Forms.Label label1;
    }
}

