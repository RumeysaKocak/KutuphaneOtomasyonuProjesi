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

namespace KutuphaneOtomasyonuProjesi.Kayit
{
    public partial class OduncVerForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C7MKVLR\\SQLEXPRESS01; initial catalog=KutuphaneOtomasyon; Integrated Security=TRUE");
        public OduncVerForm()
        {
            InitializeComponent();
        }
        public void ListeleKayit()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kayitlar ", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        public void ListeleKaynak()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from Kaynaklar ", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dataGridView2.DataSource = dt;
            conn.Close();


        }
        private void OduncVerForm_Load(object sender, EventArgs e)
        {
            ListeleKayit();
            ListeleKaynak();
            //id kolonunu gizledim
            dataGridView1.Columns[0].Visible = false;

            dataGridView2.Columns[0].Visible = false;
           
            //kolon adları düzenledim
            dataGridView1.Columns[1].HeaderText = "Kullanıcı";
            dataGridView1.Columns[2].HeaderText = "Kaynak Adı";
            dataGridView1.Columns[3].HeaderText = "Alış Tarihi";
            dataGridView1.Columns[4].HeaderText = "Veriş Tarihi";

            dataGridView2.Columns[1].HeaderText = "Kaynak Adı";
            dataGridView2.Columns[2].HeaderText = "Yazar Adı";
            dataGridView2.Columns[3].HeaderText = "Yayınevi";
            dataGridView2.Columns[4].HeaderText = "Sayfa Sayısı";
            dataGridView2.Columns[5].HeaderText = "Basım Tarihi";
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            string arananSecilen = txtTcBul.Text;

            
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kullanicilar  WHERE  kullanici_tc='"+ arananSecilen+"'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            if (dt.Rows.Count > 0) {
                label1.Text = dt.Rows[0]["kullanici_ad"].ToString() + " " + dt.Rows[0]["kullanici_soyad"].ToString();

            }
            else
            {
                label1.Text = "Kullanıcı Bulunamadı";
            }

            conn.Close();
            ListeleKayit();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string gelenAd = textBox1.Text;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kaynaklar WHERE kaynak_id LIKE '%" + gelenAd + "%'"
                + "OR kaynak_ad LIKE '%" + gelenAd + "%'"
                + "OR kaynak_yazar LIKE '%" + gelenAd + "%'"
                + "OR kaynak_yayinci LIKE '%" + gelenAd + "%'"
                + "OR kaynak_sayfa_sayisi LIKE '%" + gelenAd + "%'"
                + "OR kaynak_basim_tarihi LIKE '%" + gelenAd + "%'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            //kişiyi aldım
            string secilenKisiTc = txtTcBul.Text;

            //kitabı aldım
            int secilenKitapId = Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Kaynaklar.kaynak_id  from  Kaynaklar WHERE  Kaynaklar.kaynak_id =" + secilenKitapId , conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            string kaynakId = dt.Rows[0]["kaynak_id"].ToString();
            conn.Close();



            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Select Kullanicilar.kullanici_id  from Kullanicilar WHERE Kullanicilar.kullanici_tc=" + secilenKisiTc , conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);
            string kullaniciId = dt2.Rows[0]["kullanici_id"].ToString();
            conn.Close();

            DateTime alisTarihiDT = DateTime.Now;
            DateTime verisTarihiDT = alisTarihiDT.AddDays(15);
            string alisTarihi = alisTarihiDT.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string verisTarihi = verisTarihiDT.ToString("yyyy-MM-dd HH:mm:ss.fff");
            var durum = false;
            conn.Open();
            SqlCommand cmdInsert = new SqlCommand("INSERT INTO Kayitlar (  kullanici_id, kaynak_id, alis_tarih, son_tarih, durum) VALUES('" + kullaniciId + "','" + kaynakId + "','" + alisTarihi + "','" + verisTarihi + "','" + durum + "' ); ", conn);
            SqlDataReader drInsert = cmdInsert.ExecuteReader();
            conn.Close();
            ListeleKayit();


        }
    }
    }
    
