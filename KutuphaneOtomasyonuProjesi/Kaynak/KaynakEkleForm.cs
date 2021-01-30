using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KutuphaneOtomasyonuProjesi.Kaynak
{
    public partial class KaynakEkleForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C7MKVLR\\SQLEXPRESS01; initial catalog=KutuphaneOtomasyon; Integrated Security=TRUE");
        public KaynakEkleForm()
        {
            InitializeComponent();
        }

        private void txtKullaniciTc_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void lblIsim_Click(object sender, EventArgs e)
        {

        }

        private void lblYazar_Click(object sender, EventArgs e)
        {

        }

        private void lblYayinevi_Click(object sender, EventArgs e)
        {

        }

        private void lblSayfa_Click(object sender, EventArgs e)
        {

        }

        private void lblTarih_Click(object sender, EventArgs e)
        {

        }

        private void txtKaynakIsmi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKaynakYazari_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKaynakEkle_Click(object sender, EventArgs e)
        {
            string kaynak_ad = txtKaynakIsmi.Text;
            string kaynak_yazar = txtKaynakYazari.Text;
            string kaynak_yayinci = txtKaynakYayinevi.Text;
            int kaynak_sayfa_sayisi = Convert.ToInt16(nudSayfaSayisi.Value);
            string kaynak_basim_tarihi = dtpTarih.Value.Year + "-" + dtpTarih.Value.Month + "-" + dtpTarih.Value.Day;
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Kaynaklar ( kaynak_ad, kaynak_yazar, kaynak_yayinci, kaynak_sayfa_sayisi, kaynak_basim_tarihi) VALUES('" + kaynak_ad + "','" + kaynak_yazar + "','" + kaynak_yayinci + "'," + kaynak_sayfa_sayisi + ",'" + kaynak_basim_tarihi +  "' ); ", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            conn.Close();
            ListeleKaynak();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void ListeleKaynak()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kaynaklar ", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.Close();

           

                //id kolonunu gizledim
                dataGridView1.Columns[0].Visible = false;

                //kalan kolonların isimlerini düzenledim
                dataGridView1.Columns[1].HeaderText = "Kaynak Adı";
                dataGridView1.Columns[2].HeaderText = "Yazar Adı";
                dataGridView1.Columns[3].HeaderText = "Yayınevi";
                dataGridView1.Columns[4].HeaderText = "Sayfa Sayısı";
                dataGridView1.Columns[5].HeaderText = "Basım Tarihi";
                



            


        }
        private void KaynakEkleForm_Load(object sender, EventArgs e)
        {
            ListeleKaynak();
        }
    }
    }

