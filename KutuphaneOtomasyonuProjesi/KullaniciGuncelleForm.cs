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
namespace KutuphaneOtomasyonuProjesi
{
    public partial class KullaniciGuncelleForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C7MKVLR\\SQLEXPRESS01; initial catalog=KutuphaneOtomasyon; Integrated Security=TRUE");
        private string kullanici_ad;
        private string kullanici_soyad;
        private string kullanici_tc;
        private string kullanici_mail;
        private string kullanici_tel;
        private string kullanici_ceza;
        private string kullanici_cinsiyet;

        public KullaniciGuncelleForm()
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
        private void KullaniciGuncelleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {


          kullanici_ad = txtKullaniciAd.Text;
          kullanici_soyad = txtKullaniciSoyad.Text;
          kullanici_tc = txtKullaniciTc.Text;
          kullanici_mail = txtKullaniciMail.Text;
          kullanici_tel = txtKullaniciTel.Text;
          kullanici_ceza = txtKullaniciCeza.Text;
          kullanici_cinsiyet = "K";
            if (rbtnE.Checked == true)
            {
                kullanici_cinsiyet = "E";
            }
            else if (rbtnK.Checked == true)
            {
                kullanici_cinsiyet = "K";
            }
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET kullanici_ad='" + kullanici_ad + "', kullanici_soyad='" + kullanici_soyad + "', kullanici_tc='" + kullanici_tc + "', kullanici_mail='" + kullanici_mail + "', kullanici_tel='" + kullanici_tel + "', kullanici_ceza='" + kullanici_ceza + "', kullanici_cinsiyet='" + kullanici_cinsiyet + "' where kullanici_id=" + secilenId, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            conn.Close();
            Listele();




        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKullaniciAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtKullaniciSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtKullaniciTc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtKullaniciTel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtKullaniciMail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtKullaniciCeza.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[7].Value.ToString().Equals("E"))
                rbtnE.Checked = true;
            else
                rbtnK.Checked = true;
        }

      
    }
    }

