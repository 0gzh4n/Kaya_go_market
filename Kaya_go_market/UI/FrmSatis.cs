﻿using System;
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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }

        public Satis Satis { get; set; }
        public bool Guncelleme { get; set; }  =  false;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (nmFiyat.Value == 0)
            {
                errorProvider1.SetError(nmFiyat, "Lutfen Fiyat Giriniz!");
                nmFiyat.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmFiyat, "");
            }
            
            Satis.Tarih = dtTarih.Value;
            Satis.Fiyat = (double)nmFiyat.Value;
            Satis.UrunID = Guid.Parse(txtUrun.Text);
            Satis.MusteriID = Guid.Parse(txtMusteri.Text);

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
          txtID.Text = Satis.ID.ToString();
            if (Guncelleme)
            {
                txtMusteri.Text = Satis.MusteriID.ToString();
                txtUrun.Text = Satis.UrunID.ToString();
                nmFiyat.Value = (decimal)Satis.Fiyat;
                dtTarih.Value = Satis.Tarih;
            }
        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Müşteriler frm = new Müşteriler();
            if(frm.ShowDialog() == DialogResult.OK)
            {
              //  Musteri = frm.Musteri;           
                txtMusteri.Text = frm.Musteri.ID.ToString();

            }
        }

        private void btnÜrünSeç_Click(object sender, EventArgs e)
        {
            Ürünler frm = new Ürünler();
            if(frm.ShowDialog()== DialogResult.OK)
            {
            //    Urun = frm.Urun; 
                txtUrun.Text = frm.Urun.ID.ToString();
            }
        }
    }
}
