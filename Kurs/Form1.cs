using Kurs.Models;
using Microsoft.EntityFrameworkCore;

namespace Kurs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            DbKursContext _db = DbKursContext.GetInstance;
            List<TblDersler> dersListesi = await _db.TblDerslers.ToListAsync();
            dataGridView1.DataSource = dersListesi;

        }

        private async void Btn_NotListele_Click(object sender, EventArgs e)
        {
            DbKursContext _db = DbKursContext.GetInstance;
            
            dataGridView1.DataSource =await _db.TblNotlars.Select(p=> new { 
                OgrenciId =p.Id
                ,p.Sinav1
                ,p.Sinav2
                ,p.Sinav3
                ,p.Ortalama
                ,p.Ders.Adi}).ToListAsync();

        }
    }
}
