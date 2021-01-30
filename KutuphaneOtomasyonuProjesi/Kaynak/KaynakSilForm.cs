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
    public partial class KaynakSilForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C7MKVLR\\SQLEXPRESS01; initial catalog=KutuphaneOtomasyon; Integrated Security=TRUE");
        public KaynakSilForm()
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

        private void KaynakSilForm_Load(object sender, EventArgs e)
        {
            ListeleKaynak();
        }

        private void btnKaynakSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silmek İstediğinizden Emin Misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE from Kaynaklar where kaynak_id=" + secilenId, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("Silindi", "Uyarı");
            }


           
        }

        
    }
}
