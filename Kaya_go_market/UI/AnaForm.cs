using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kaya_go_market.BL;
using Kaya_go_market.UI;

namespace Kaya_go_market
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Müşteriler mf = new Müşteriler();
        Ürünler uf = new Ürünler();

        private void btnMüşteriler_Click(object sender, EventArgs e)
        {
            mf.ShowDialog(); 
        }

        private void btnÜrünler_Click(object sender, EventArgs e)
        {
            uf.ShowDialog(); 
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            FrmSatis frm = new FrmSatis()
            {
                Text = "Satis Yap",
                Satis = new Satis()
                {
                    ID = Guid.NewGuid(),
                }
            };

            if(frm.ShowDialog() == DialogResult.OK)
            {
            tekrar:

                var sonuc = frm.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    bool b = BLogic.SatisEkle(frm.Satis);

                    if (b)
                    {
                        DataSet ds1 = BLogic.SatisDetay("");
                        if (ds1 != null)

                            dataGridView1.DataSource = ds1.Tables[0];

                    }
                    else
                    {
                       goto tekrar;
                    }
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.SatisDetay("");
            if (ds1 != null)

                dataGridView1.DataSource = ds1.Tables[0];

        }

        private void btnSatisDüzenle_Click(object sender, EventArgs e)
        {
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                FrmSatis frm = new FrmSatis()
                {
                    Text = "Satis Guncelle",
                    Guncelleme = true,
                    Satis = new Satis()

                    {
                        ID = Guid.Parse(row.Cells[0].Value.ToString()),
                        MusteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                        UrunID = Guid.Parse(row.Cells[2].Value.ToString()),
                        Fiyat = double.Parse(row.Cells[3].Value.ToString()),
                        Tarih = DateTime.Parse(row.Cells[4].Value.ToString()),
                    },

                };

                var sonuc = frm.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    bool b = BLogic.SatisGuncelle(frm.Satis);

                    if (b)
                    {
                        row.Cells[1].Value = frm.Satis.MusteriID;
                        row.Cells[2].Value = frm.Satis.UrunID;
                        row.Cells[3].Value = frm.Satis.Fiyat;
                        row.Cells[4].Value = frm.Satis.Tarih;
                    }
                }


            }

        }
    }
}
