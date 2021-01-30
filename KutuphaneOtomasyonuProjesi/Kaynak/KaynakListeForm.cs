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
    public partial class KaynakListeForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C7MKVLR\\SQLEXPRESS01; initial catalog=KutuphaneOtomasyon; Integrated Security=TRUE");
        public KaynakListeForm()
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


   
        private void KaynakListeForm_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kaynaklar ", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.Close();

            ListeleKaynak();

        }
    }
}
