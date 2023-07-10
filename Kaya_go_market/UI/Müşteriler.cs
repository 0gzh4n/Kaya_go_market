using Kaya_go_market.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaya_go_market.UI
{
    public partial class Müşteriler : Form
    {
        public Müşteriler()
        {
            InitializeComponent();
        }

        private void btnMüşteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "Musteri Ekle",
                Musteri = new Musteri() { ID = Guid.NewGuid() },
            };

        tekrar:

            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriEkle(frmMusteri.Musteri);

                if (b)
                {
                    DataSet ds = BLogic.Satislarigetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    goto tekrar;
                }
            }

        }

        private void btnMüşteriDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "Musteri Guncelle",
                Guncelleme = true,
                Musteri = new Musteri()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Mail = row.Cells[4].Value.ToString(),
                    Adres = row.Cells[5].Value.ToString(),
                },

            };

            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriGüncelle(frmMusteri.Musteri);

                if (b)
                {
                    row.Cells[1].Value = frmMusteri.Musteri.Ad;
                    row.Cells[2].Value = frmMusteri.Musteri.Soyad;
                    row.Cells[3].Value = frmMusteri.Musteri.Telefon;
                    row.Cells[4].Value = frmMusteri.Musteri.Mail;
                    row.Cells[5].Value = frmMusteri.Musteri.Adres;
                }
            }


        }

        private void btnMüşteriBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.Satislarigetir(toolStripTextBox1.Text);
            if (ds != null)

                dataGridView1.DataSource = ds.Tables[0];

        }

        private void btnMüşteriSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Secili Kayit Silinsin Mi?", "Silmeyi Onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriSil(ID);

                if (b)
                {
                    if (b)
                    {
                        DataSet ds = BLogic.Satislarigetir("");
                        if (ds != null)
                            dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }

        }

        private void Müşteriler_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.Satislarigetir("");
            if (ds1 != null)

                dataGridView1.DataSource = ds1.Tables[0];

        }
        public Musteri Musteri { get; set; }    
        private void btnOk_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            Musteri = new Musteri()
            {
                
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Mail = row.Cells[4].Value.ToString(),
                    Adres = row.Cells[5].Value.ToString(),
            };

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
