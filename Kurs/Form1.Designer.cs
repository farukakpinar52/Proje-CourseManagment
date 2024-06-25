namespace Kurs
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
            dataGridView1 = new DataGridView();
            btn_ogrListele = new Button();
            Btn_Kaydet = new Button();
            Btn_Sil = new Button();
            Btn_Guncelle = new Button();
            Btn_Bul = new Button();
            gb1 = new GroupBox();
            txt_ogr_foto = new TextBox();
            label3 = new Label();
            txt_ogr_soyadi = new TextBox();
            label2 = new Label();
            txt_ogr_adi = new TextBox();
            label1 = new Label();
            txt_ogr_id = new TextBox();
            label_ID = new Label();
            groupBox1 = new GroupBox();
            txt_dersadi = new TextBox();
            lbl_dersAdi = new Label();
            txt_dersid = new TextBox();
            lbl_dersid = new Label();
            groupBox2 = new GroupBox();
            btn_Sinav_notu_guncelle = new Button();
            btn_ort_hesapla = new Button();
            txt_Durum = new TextBox();
            txt_Ort = new TextBox();
            label8 = new Label();
            label4 = new Label();
            txt_Sinav3 = new TextBox();
            label5 = new Label();
            txt_Sinav2 = new TextBox();
            label6 = new Label();
            txt_Sinav1 = new TextBox();
            label7 = new Label();
            Btn_DersListesi = new Button();
            Btn_NotListele = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gb1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, -2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(863, 300);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btn_ogrListele
            // 
            btn_ogrListele.Location = new Point(-2, 304);
            btn_ogrListele.Name = "btn_ogrListele";
            btn_ogrListele.Size = new Size(143, 44);
            btn_ogrListele.TabIndex = 1;
            btn_ogrListele.Text = "Öğrenci Listele";
            btn_ogrListele.UseVisualStyleBackColor = true;
            btn_ogrListele.Click += btn_ogrListele_Click;
            // 
            // Btn_Kaydet
            // 
            Btn_Kaydet.Location = new Point(-2, 509);
            Btn_Kaydet.Name = "Btn_Kaydet";
            Btn_Kaydet.Size = new Size(143, 44);
            Btn_Kaydet.TabIndex = 2;
            Btn_Kaydet.Text = "Kaydet";
            Btn_Kaydet.UseVisualStyleBackColor = true;
            Btn_Kaydet.Click += Btn_Kaydet_Click;
            // 
            // Btn_Sil
            // 
            Btn_Sil.Location = new Point(-2, 563);
            Btn_Sil.Name = "Btn_Sil";
            Btn_Sil.Size = new Size(143, 44);
            Btn_Sil.TabIndex = 3;
            Btn_Sil.Text = "Sil";
            Btn_Sil.UseVisualStyleBackColor = true;
            Btn_Sil.Click += Btn_Sil_Click;
            // 
            // Btn_Guncelle
            // 
            Btn_Guncelle.Location = new Point(-2, 613);
            Btn_Guncelle.Name = "Btn_Guncelle";
            Btn_Guncelle.Size = new Size(143, 44);
            Btn_Guncelle.TabIndex = 4;
            Btn_Guncelle.Text = "Güncelle";
            Btn_Guncelle.UseVisualStyleBackColor = true;
            Btn_Guncelle.Click += Btn_Guncelle_Click;
            // 
            // Btn_Bul
            // 
            Btn_Bul.Location = new Point(-2, 664);
            Btn_Bul.Name = "Btn_Bul";
            Btn_Bul.Size = new Size(143, 44);
            Btn_Bul.TabIndex = 5;
            Btn_Bul.Text = "Bul";
            Btn_Bul.UseVisualStyleBackColor = true;
            Btn_Bul.Click += Btn_Bul_Click;
            // 
            // gb1
            // 
            gb1.Controls.Add(txt_ogr_foto);
            gb1.Controls.Add(label3);
            gb1.Controls.Add(txt_ogr_soyadi);
            gb1.Controls.Add(label2);
            gb1.Controls.Add(txt_ogr_adi);
            gb1.Controls.Add(label1);
            gb1.Controls.Add(txt_ogr_id);
            gb1.Controls.Add(label_ID);
            gb1.Location = new Point(147, 306);
            gb1.Name = "gb1";
            gb1.Size = new Size(417, 165);
            gb1.TabIndex = 6;
            gb1.TabStop = false;
            gb1.Text = "Öğrenci Bilgi";
            // 
            // txt_ogr_foto
            // 
            txt_ogr_foto.Location = new Point(94, 121);
            txt_ogr_foto.Name = "txt_ogr_foto";
            txt_ogr_foto.Size = new Size(309, 26);
            txt_ogr_foto.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 124);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 20;
            label3.Text = "Fotosu";
            // 
            // txt_ogr_soyadi
            // 
            txt_ogr_soyadi.Location = new Point(94, 89);
            txt_ogr_soyadi.Name = "txt_ogr_soyadi";
            txt_ogr_soyadi.Size = new Size(309, 26);
            txt_ogr_soyadi.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 92);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 18;
            label2.Text = "Soyadı";
            // 
            // txt_ogr_adi
            // 
            txt_ogr_adi.Location = new Point(94, 57);
            txt_ogr_adi.Name = "txt_ogr_adi";
            txt_ogr_adi.Size = new Size(309, 26);
            txt_ogr_adi.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 60);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 16;
            label1.Text = "Adı";
            // 
            // txt_ogr_id
            // 
            txt_ogr_id.Enabled = false;
            txt_ogr_id.Location = new Point(94, 25);
            txt_ogr_id.Name = "txt_ogr_id";
            txt_ogr_id.Size = new Size(309, 26);
            txt_ogr_id.TabIndex = 15;
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Location = new Point(48, 28);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(28, 20);
            label_ID.TabIndex = 14;
            label_ID.Text = "ID";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_dersadi);
            groupBox1.Controls.Add(lbl_dersAdi);
            groupBox1.Controls.Add(txt_dersid);
            groupBox1.Controls.Add(lbl_dersid);
            groupBox1.Location = new Point(147, 502);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 123);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ders Bilgi";
            // 
            // txt_dersadi
            // 
            txt_dersadi.Location = new Point(94, 57);
            txt_dersadi.Name = "txt_dersadi";
            txt_dersadi.Size = new Size(309, 26);
            txt_dersadi.TabIndex = 17;
            // 
            // lbl_dersAdi
            // 
            lbl_dersAdi.AutoSize = true;
            lbl_dersAdi.Location = new Point(11, 60);
            lbl_dersAdi.Name = "lbl_dersAdi";
            lbl_dersAdi.Size = new Size(35, 20);
            lbl_dersAdi.TabIndex = 16;
            lbl_dersAdi.Text = "Adı";
            // 
            // txt_dersid
            // 
            txt_dersid.Enabled = false;
            txt_dersid.Location = new Point(94, 25);
            txt_dersid.Name = "txt_dersid";
            txt_dersid.Size = new Size(309, 26);
            txt_dersid.TabIndex = 15;
            // 
            // lbl_dersid
            // 
            lbl_dersid.AutoSize = true;
            lbl_dersid.Location = new Point(18, 28);
            lbl_dersid.Name = "lbl_dersid";
            lbl_dersid.Size = new Size(28, 20);
            lbl_dersid.TabIndex = 14;
            lbl_dersid.Text = "ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Sinav_notu_guncelle);
            groupBox2.Controls.Add(btn_ort_hesapla);
            groupBox2.Controls.Add(txt_Durum);
            groupBox2.Controls.Add(txt_Ort);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_Sinav3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_Sinav2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_Sinav1);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(579, 306);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(282, 321);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "NOT Bilgi";
            // 
            // btn_Sinav_notu_guncelle
            // 
            btn_Sinav_notu_guncelle.Location = new Point(32, 257);
            btn_Sinav_notu_guncelle.Name = "btn_Sinav_notu_guncelle";
            btn_Sinav_notu_guncelle.Size = new Size(175, 49);
            btn_Sinav_notu_guncelle.TabIndex = 22;
            btn_Sinav_notu_guncelle.Text = "Sınav Notu Güncelle";
            btn_Sinav_notu_guncelle.UseVisualStyleBackColor = true;
            // 
            // btn_ort_hesapla
            // 
            btn_ort_hesapla.Location = new Point(35, 209);
            btn_ort_hesapla.Name = "btn_ort_hesapla";
            btn_ort_hesapla.Size = new Size(172, 42);
            btn_ort_hesapla.TabIndex = 11;
            btn_ort_hesapla.Text = "Ortalama Hesapla";
            btn_ort_hesapla.UseVisualStyleBackColor = true;
            // 
            // txt_Durum
            // 
            txt_Durum.Location = new Point(145, 157);
            txt_Durum.Name = "txt_Durum";
            txt_Durum.Size = new Size(62, 26);
            txt_Durum.TabIndex = 17;
            // 
            // txt_Ort
            // 
            txt_Ort.Location = new Point(145, 124);
            txt_Ort.Name = "txt_Ort";
            txt_Ort.Size = new Size(62, 26);
            txt_Ort.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 160);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 16;
            label8.Text = "DURUM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 127);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 20;
            label4.Text = "ORTALAMA";
            // 
            // txt_Sinav3
            // 
            txt_Sinav3.Location = new Point(145, 92);
            txt_Sinav3.Name = "txt_Sinav3";
            txt_Sinav3.Size = new Size(62, 26);
            txt_Sinav3.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 95);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 18;
            label5.Text = "3.SINAV";
            // 
            // txt_Sinav2
            // 
            txt_Sinav2.Location = new Point(145, 60);
            txt_Sinav2.Name = "txt_Sinav2";
            txt_Sinav2.Size = new Size(62, 26);
            txt_Sinav2.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 63);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 16;
            label6.Text = "2.SINAV";
            // 
            // txt_Sinav1
            // 
            txt_Sinav1.Location = new Point(145, 28);
            txt_Sinav1.Name = "txt_Sinav1";
            txt_Sinav1.Size = new Size(62, 26);
            txt_Sinav1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 31);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 14;
            label7.Text = "1.SINAV";
            // 
            // Btn_DersListesi
            // 
            Btn_DersListesi.Location = new Point(-2, 354);
            Btn_DersListesi.Name = "Btn_DersListesi";
            Btn_DersListesi.Size = new Size(143, 44);
            Btn_DersListesi.TabIndex = 9;
            Btn_DersListesi.Text = "Ders Listele";
            Btn_DersListesi.UseVisualStyleBackColor = true;
            Btn_DersListesi.Click += Btn_DersListesi_Click;
            // 
            // Btn_NotListele
            // 
            Btn_NotListele.Location = new Point(-2, 413);
            Btn_NotListele.Name = "Btn_NotListele";
            Btn_NotListele.Size = new Size(143, 44);
            Btn_NotListele.TabIndex = 10;
            Btn_NotListele.Text = "Not Listele";
            Btn_NotListele.UseVisualStyleBackColor = true;
            Btn_NotListele.Click += Btn_NotListele_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 717);
            Controls.Add(Btn_NotListele);
            Controls.Add(Btn_DersListesi);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(gb1);
            Controls.Add(Btn_Bul);
            Controls.Add(Btn_Guncelle);
            Controls.Add(Btn_Sil);
            Controls.Add(Btn_Kaydet);
            Controls.Add(btn_ogrListele);
            Controls.Add(dataGridView1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.CornflowerBlue;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_ogrListele;
        private Button Btn_Kaydet;
        private Button Btn_Sil;
        private Button Btn_Guncelle;
        private Button Btn_Bul;
        private GroupBox gb1;
        private TextBox txt_ogr_foto;
        private Label label3;
        private TextBox txt_ogr_soyadi;
        private Label label2;
        private TextBox txt_ogr_adi;
        private Label label1;
        private TextBox txt_ogr_id;
        private Label label_ID;
        private GroupBox groupBox1;
        private TextBox txt_dersadi;
        private Label lbl_dersAdi;
        private TextBox txt_dersid;
        private Label lbl_dersid;
        private GroupBox groupBox2;
        private TextBox txt_Durum;
        private TextBox txt_Ort;
        private Label label8;
        private Label label4;
        private TextBox txt_Sinav3;
        private Label label5;
        private TextBox txt_Sinav2;
        private Label label6;
        private TextBox txt_Sinav1;
        private Label label7;
        private Button Btn_DersListesi;
        private Button Btn_NotListele;
        private Button btn_Sinav_notu_guncelle;
        private Button btn_ort_hesapla;
    }
}
