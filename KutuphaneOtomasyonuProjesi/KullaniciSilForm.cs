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
    public partial class KullaniciSilForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C7MKVLR\\SQLEXPRESS01; initial catalog=KutuphaneOtomasyon; Integrated Security=TRUE");
        public KullaniciSilForm()
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
        private void KullaniciSilForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silmek İstediğinizden Emin Misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (dialogResult==DialogResult.Yes)
            {
                int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE from Kullanicilar where kullanici_id=" + secilenId, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                conn.Close();
                Listele();
                MessageBox.Show("Silindi", "Uyarı");
            }
           
        }

    
    }
    
}
