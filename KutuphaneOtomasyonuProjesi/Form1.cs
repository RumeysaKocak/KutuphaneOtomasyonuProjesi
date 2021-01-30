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
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C7MKVLR\\SQLEXPRESS01; initial catalog=KutuphaneOtomasyon; Integrated Security=TRUE");
        public Form1()
        {
            InitializeComponent();
        }

        

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtKullaniciAdi.Text;
            string password = txtSifre.Text;
            password = CreateMD5(password);

            bool kayitli_mi = false;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Id from login where K_Adi='" + name + "' AND Sifre='" + password + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            kayitli_mi = dr.HasRows;
            conn.Close();

            if (kayitli_mi)
            {
                IslemPaneli panel = new IslemPaneli();
                if (beniAnimsa.Checked)
                {
                    Properties.Settings.Default.username = txtKullaniciAdi.Text;
                    Properties.Settings.Default.password = txtSifre.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.username = null;
                    Properties.Settings.Default.password = null;
                    Properties.Settings.Default.Save();
                }
                panel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }

        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.username != "")
            {
                txtKullaniciAdi.Text = Properties.Settings.Default.username;
                txtSifre.Text = Properties.Settings.Default.password;
                beniAnimsa.Checked = true;
            }

        }

        private void lblKullaniciAdi_Click(object sender, EventArgs e)
        {

        }

        private void lblSifre_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult1 = MessageBox.Show("Program Kapanacak", "Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult1 == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void minisizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
