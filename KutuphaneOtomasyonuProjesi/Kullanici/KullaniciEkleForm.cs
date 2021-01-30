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


namespace KutuphaneOtomasyonuProjesi.Kullanici
{
    public partial class KullaniciEkleForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C7MKVLR\\SQLEXPRESS01; initial catalog=KutuphaneOtomasyon; Integrated Security=TRUE");
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kullanicilar ", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.Close();

            //id kolonunu gizledim
            dataGridView1.Columns[0].Visible = false;

            //kalan kolonların isimlerini düzenledim
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "TC";
            dataGridView1.Columns[4].HeaderText = "Mail";
            dataGridView1.Columns[5].HeaderText = "Telefon No";
            dataGridView1.Columns[6].HeaderText = "Ceza";
            dataGridView1.Columns[7].HeaderText = "Cinsiyet";

        }


        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void rbtnK_CheckedChanged(object sender, EventArgs e)
        {

        }

    

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string kullanici_ad = txtKullaniciAd.Text;
            string kullanici_soyad = txtKullaniciSoyad.Text;
            string kullanici_tc = txtKullaniciTc.Text;
            string kullanici_mail = txtKullaniciMail.Text;
            string kullanici_tel = txtKullaniciTel.Text;
            string kullanici_ceza = txtKullaniciCeza.Text;
            string kullanici_cinsiyet = "K";
            if (rbtnE.Checked==true)
            {
                kullanici_cinsiyet = "E";
            }else if (rbtnK.Checked == true)
            {
                kullanici_cinsiyet = "K";
            }
            else
            {
                MessageBox.Show(text: "Lütfen Cinsiyetinizi Seçiniz");
            }


                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Kullanicilar ( kullanici_ad, kullanici_soyad, kullanici_tc, kullanici_mail, kullanici_tel, kullanici_ceza, kullanici_cinsiyet) VALUES('" + kullanici_ad + "','" + kullanici_soyad + "','" + kullanici_tc + "','" + kullanici_mail + "','" + kullanici_tel + "','" + kullanici_ceza + "','" + kullanici_cinsiyet + "' ); ", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                conn.Close();
                Listele();



        }

       
    }
}
