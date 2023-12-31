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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            txtID.Text = Urun.ID.ToString();

            if (Güncelleme)
            {
                txtUrun.Text = Urun.Ad;
                cbKategori.Text = Urun.Kategori;
                nmFiyat.Value = (decimal)Urun.Fiyat;
                nmStok.Value = (decimal)Urun.Stok;
                cbBrim.Text = Urun.Birim;
                txtAciklama.Text = Urun.Detay;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Urun Urun { get; set; }
        public bool Güncelleme { get; set; } = false;


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtUrun)) return;
            if (!ErrorControl(cbKategori)) return;
            if (!ErrorControl(nmFiyat)) return;
            if (!ErrorControl(nmStok)) return;
            if (!ErrorControl(cbBrim)) return;
            if (!ErrorControl(txtAciklama)) return;

            Urun.Ad = txtUrun.Text;
            Urun.Kategori = cbKategori.Text;
            Urun.Fiyat = (double)nmFiyat.Value;
            Urun.Stok = (double)nmStok.Value;
            Urun.Birim = cbBrim.Text;
            Urun.Detay = txtAciklama.Text;

            DialogResult = DialogResult.OK;
        }

        public bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik Veya Hatali Giris!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }

            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value == 0)
                {
                    errorProvider1.SetError(c, "Eksik Veya Hatali Giris!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }

            return true;
        }
    }
}
