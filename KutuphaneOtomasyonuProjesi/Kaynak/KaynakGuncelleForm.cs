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
    public partial class KaynakGuncelleForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C7MKVLR\\SQLEXPRESS01; initial catalog=KutuphaneOtomasyon; Integrated Security=TRUE");




        public KaynakGuncelleForm()
        {
            InitializeComponent();
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
        private void btnKaynakGuncelle_Click(object sender, EventArgs e)
        {
            string kaynak_ad = txtKaynakIsmi.Text;
            string kaynak_yazar = txtKaynakYazari.Text;
            string kaynak_yayinci = txtKaynakYayinevi.Text;
            int kaynak_sayfa_sayisi = Convert.ToInt16(nudSayfaSayisi.Value);
            string kaynak_basim_tarihi = dtpTarih.Value.Year + "-" + dtpTarih.Value.Month + "-" + dtpTarih.Value.Day;


            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Kaynaklar SET kaynak_ad='" + kaynak_ad + "', kaynak_yazar='" + kaynak_yazar + "', kaynak_yayinci='" + kaynak_yayinci + "', kaynak_sayfa_sayisi='" + kaynak_sayfa_sayisi + "', kaynak_basim_tarihi='" + kaynak_basim_tarihi + "' where kaynak_id='" + secilenId+"';", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            conn.Close();
            ListeleKaynak();



        }

        private void KaynakGuncelleForm_Load(object sender, EventArgs e)
        {
            ListeleKaynak();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtKaynakIsmi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtKaynakYazari.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtKaynakYayinevi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            nudSayfaSayisi.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
            dtpTarih.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
        }
    }
}

