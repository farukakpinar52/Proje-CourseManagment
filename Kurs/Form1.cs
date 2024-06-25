using Kurs.Data;
using Kurs.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kurs
{
    public partial class Form1 : Form
    {
        DbKursContext _db = DbKursContext.GetInstance;


        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //2.yöntem ise bir LINQ sorgusu yazarak select ile belirli kolonlarý gösterebiliriz.
            var query = from dersler in _db.TblDerslers
                        select new { DersID = dersler.Id, DersAdý = dersler.Adi };
            //List<TblDersler> dersListesi = await _db.TblDerslers.ToListAsync();
            dataGridView1.DataSource = await query.ToListAsync();


            //1.Yöntem : Tablolarýn istenmeyen sütunlarýný gizleme
            //dataGridView1.Columns[2].Visible = false;

        }

        private async void Btn_NotListele_Click(object sender, EventArgs e)
        {
            await NotListele();

        }

        private async Task NotListele()
        {
            //dataGridView1.DataSource = await _db.TblNotlars.
            //    Select(p => new
            //{
            //    NotId = p.Id,
            //    OgrenciId = p.OgrId,
            //    p.Ogr.Ad,
            //    p.Ogr.Soyad,
            //    p.Sinav1,
            //    p.Sinav2,
            //    p.Sinav3,
            //    p.Ortalama,
            //    p.Ders.Adi
            //}).ToListAsync();

            var query = from not in _db.TblNotlars
                        join ogrenci in _db.TblOgrencilers
                        on not.OgrId equals ogrenci.Id
                        join ders in _db.TblDerslers
                        on not.DersId equals ders.Id
                        select new
                        {
                            OGRENCI =ogrenci.Ad + " " + ogrenci.Soyad,
                            DERS = ders.Adi,
                            Sýnav1 =not.Sinav1,
                            Sýnav2 =not.Sinav2,
                            Sýnav3 =not.Sinav3,
                            Ortalama = (not.Sinav1+not.Sinav2+not.Sinav3)/3,

                            

                        };
            dataGridView1.DataSource=await query.ToListAsync();
        }

        private async void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            //Textbox'lar üzerinden girilen deðerler için öðrenci ekleme
            TblOgrenciler newStudent = new();
            newStudent.Ad = txt_ogr_adi.Text;
            newStudent.Soyad = txt_ogr_soyadi.Text;
            if (newStudent.Ad.Length > 1 && newStudent.Soyad.Length > 1)
            {
                _db.TblOgrencilers.Add(newStudent);
                _db.SaveChanges();
                await OgrenciListele();
                MessageBox.Show("Öðrenci baþarýyla eklendi.");


            }


            else if (txt_dersadi.Text.Length > 2)
            {
                TblDersler newDers = new();
                newDers.Adi = txt_dersadi.Text;
                _db.TblDerslers.Add(newDers);
                _db.SaveChanges();
                await DersListele();
                MessageBox.Show("Yeni ders eklendi");

            }
            else MessageBox.Show("Öðrenci,ders ya da not bilgisi giriniz.");

        }

        private async void btn_ogrListele_Click(object sender, EventArgs e)
        {
            await OgrenciListele();
        }

        private async Task OgrenciListele()
        {
            dataGridView1.DataSource = await _db.TblOgrencilers.Select(o => new { OgrenciId = o.Id, o.Ad, o.Soyad }).ToListAsync();
        }

        private async void Btn_DersListesi_Click(object sender, EventArgs e)
        {
            await DersListele();
        }

        private async Task DersListele()
        {
            dataGridView1.DataSource = await _db.TblDerslers.Select(x => new { DersId = x.Id, x.Adi }).ToListAsync();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Týklanan hücrenin bulunduðu satýrýn ID sütunundaki deðerini alýn.
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                IdGetir(row);

            }
        }

        private void IdGetir(DataGridViewRow row)
        {
            if (dataGridView1.Columns.Contains("OgrenciId"))
            {
                txt_ogr_id.Text = row.Cells["OgrenciId"].Value.ToString();
                txt_dersid.Clear();
            }

            else if (dataGridView1.Columns.Contains("DersId"))
            {
                txt_dersid.Text = row.Cells["DersId"].Value.ToString();
                txt_ogr_id.Clear();
            }

            else
                MessageBox.Show("devam");
        }

        private async void Btn_Sil_Click(object sender, EventArgs e)
        {

            string ogrId = txt_ogr_id.Text.Trim();
            string dersId = txt_dersid.Text.Trim();
            if (ogrId != "" && ogrId.Length > 0)
            {
                int id = Convert.ToInt32(ogrId);
                TblOgrenciler? silinecekOgrenci = _db.TblOgrencilers.Find(id);
                _db.TblOgrencilers.Remove(silinecekOgrenci);
                _db.SaveChanges();
                await OgrenciListele();

            }
            else if (dersId != "" && dersId.Length > 0)
            {
                int id = Convert.ToInt32(dersId);
                TblDersler silinecekDers = _db.TblDerslers.Find(id);
                _db.TblDerslers.Remove(silinecekDers);
                _db.SaveChanges();
                await DersListele();

            }

            else
                MessageBox.Show("silme iþlemi gerçekleþmedi");

        }

        private async void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            string ogrId = txt_ogr_id.Text.Trim();
            string dersId = txt_dersid.Text.Trim();
            if (ogrId != "" && ogrId.Length > 0 && (txt_ogr_adi.Text != "" && txt_ogr_soyadi.Text != ""))
            {
                int id = Convert.ToInt32(ogrId);
                TblOgrenciler? guncellenecekOgrenci = _db.TblOgrencilers.Find(id);
                guncellenecekOgrenci.Ad = txt_ogr_adi.Text;
                guncellenecekOgrenci.Soyad = txt_ogr_soyadi.Text;
                guncellenecekOgrenci.Foto = txt_ogr_foto.Text;
                _db.SaveChanges();
                await OgrenciListele();

            }
            else if (dersId != "" && dersId.Length > 0 && txt_dersadi.Text != "")
            {
                int id = Convert.ToInt32(dersId);
                TblDersler? guncellenecekDers = _db.TblDerslers.Find(id);
                guncellenecekDers.Adi = txt_dersadi.Text;
                _db.SaveChanges();
                await DersListele();

            }

            else
                MessageBox.Show("Güncelleme iþlemi gerçekleþmedi");
        }



        private void Btn_Bul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.TblOgrencilers.Where(o => o.Ad == txt_ogr_adi.Text).ToList();
        }

        private void btn_StoredProcedure_Click(object sender, EventArgs e)
        {
            var datas = _db.SPEntities.FromSqlRaw($"exec DurumTablo").ToList();
            dataGridView1.DataSource = datas;
        }

        private void txt_ogr_adi_TextChanged(object sender, EventArgs e)
        {
            string search = txt_ogr_adi.Text;
            var degerler = from data in _db.TblOgrencilers
                           where data.Ad.Contains(search)
                           select data;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void btn_linqEntity_Click(object sender, EventArgs e)
        {
            var ogrenciListe = _db.TblOgrencilers.OrderBy(p => p.Ad);

            if (rb_A_Z.Checked)
            {
                dataGridView1.DataSource = ogrenciListe.ToList();
            }
            else if (rb_Z_A.Checked)
            {
                dataGridView1.DataSource = ogrenciListe.OrderByDescending(p=>p.Ad).ToList();
            }
            else if (rb_Top3.Checked)
            {
                dataGridView1.DataSource = ogrenciListe.Take(3).ToList();
            }
            else if (rb_Sinav1Ort.Checked) 
            {
                var data = _db.TblNotlars.Average(ort => ort.Sinav1);
                MessageBox.Show($"Ortalama puan ={data}","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_A_Z_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
