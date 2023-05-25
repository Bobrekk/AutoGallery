using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Oto_Galeri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OleDb.12.0; Data Source = " + Application.StartupPath + "\\OtoGaleri.accdb");
        
        private void kayitlarilistele()
        {
            try
            {
                conn.Open();
                OleDbDataAdapter list = new OleDbDataAdapter("SELECT * FROM araclar", conn);
                DataSet dataa = new DataSet();
                list.Fill(dataa);
                data.DataSource = dataa.Tables[0];
                conn.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata Mesajı");
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kayitlarilistele();
        }

        private void cBox_marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBox_model.Items.Clear();
            String marka = cBox_marka.SelectedItem.ToString();
            if (marka == "Toyota")
            {
                String[] toyota = { "Auris", "Corolla", "Yaris" };
                cBox_model.Items.AddRange(toyota);

            }
            else if (marka == "Honda")
            {
                String[] honda = { "Civic", "Accord" };
                cBox_model.Items.AddRange(honda);
            }
            else if (marka == "Opel")
            {
                String[] opel = { "Astra", "Vectra", "Corsa" };
                cBox_model.Items.AddRange(opel);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataAdapter save = new OleDbDataAdapter("INSERT INTO araclar (RuhsatNo,Marka,Model,YakıtTipi,KasaTipi,Kilometre,Fiyat) VALUES ('" + tBox_ruhsat.Text + "','" + cBox_marka.SelectedItem.ToString() + "','" + cBox_model.SelectedItem.ToString() + "','" + cBox_yakıttipi.SelectedItem.ToString() + "','" + cBox_kasatipi.SelectedItem.ToString() + "','" + tBox_km.Text + "','" + tBox_fiyat.Text + "')", conn);
                DataSet getData = new DataSet();
                save.Fill(getData);
                conn.Close();
                MessageBox.Show("Kayıt başarıyla oluşturuldu !", "Veritabanı İşlemleri");
                tBox_ruhsat.Clear();
                tBox_km.Clear();
                tBox_fiyat.Clear();
                kayitlarilistele();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata Mesajı");
                conn.Close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataAdapter delete = new OleDbDataAdapter("DELETE FROM araclar WHERE RuhsatNo = '" + tBox_ruhsat.Text + "'", conn);
                DataSet deletedata = new DataSet();
                delete.Fill(deletedata);
                conn.Close();
                MessageBox.Show(tBox_ruhsat.Text + " Ruhsat No'lu araç başarıyla silindi !", "Veritabanı İşlemleri");
                kayitlarilistele();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata Mesajı");
                conn.Close();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataAdapter update = new OleDbDataAdapter("UPDATE araclar set Fiyat = '" + tBox_fiyat.Text + "'" + "WHERE RuhsatNo = '" + tBox_ruhsat.Text + "'", conn);
                DataSet dataupdate = new DataSet();
                update.Fill(dataupdate);
                conn.Close();
                MessageBox.Show("Kayıt başarıyla güncellendi !", "Veritabanı İşlemleri");
                kayitlarilistele();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata Mesajı");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataAdapter search = new OleDbDataAdapter("SELECT * FROM araclar WHERE RuhsatNo = '" + tBox_ruhsat.Text + "'", conn);
                DataSet searchdata = new DataSet();
                search.Fill(searchdata);
                data.DataSource = searchdata.Tables[0];
                conn.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata Mesajı");
                conn.Close();
            }
        }
    }
}
