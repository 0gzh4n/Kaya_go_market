using Kaya_go_market.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaya_go_market.BL
{
    public static class BLogic
    {
        public static bool MüşteriEkle(Musteri m)
        {
            try
            {
                int res = DataLayer.MüşteriEKle(m);

                return (res > 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }

        }

        internal static DataSet Satislarigetir(string filtre)
        {

            try
            {


                DataSet ds = DataLayer.Müşterigetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return null;
            }

        }

        internal static bool MüşteriGüncelle(Musteri m)
        {
            try
            {


                int res = DataLayer.MüşteriGüncelle(m);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }
        }

        internal static bool MüşteriSil(string id)
        {
            try
            {


                int res = DataLayer.MüşteriSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }
        }

        internal static bool SatisEkle(Satis s)
        {
            try
            {
                int res = DataLayer.SatisEKle(s);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }
        }

        internal static bool UrunEkle(Urun u)
        {
            try
            {
                int res = DataLayer.UrunEkle(u);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }
        }

        internal static DataSet UrunGetir(string filtre)
        {
            try
            {


                DataSet ds = DataLayer.Urungetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return null;
            }
        }

        internal static bool UrunGüncelle(Urun u)
        {
            try
            {


                int res = DataLayer.UrunGüncelle(u);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }
        }

        internal static bool UrunSil(string ıD)
        {
            try
            {
                int res = DataLayer.UrunSil(ıD);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }
        }

        internal static DataSet SatisDetay(string v)
        {
            try
            {


                DataSet ds = DataLayer.SatisDetay();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return null;
            }
        }

        internal static bool SatisGuncelle(Satis satis)
        {
            throw new NotImplementedException();
        }
    }
}
