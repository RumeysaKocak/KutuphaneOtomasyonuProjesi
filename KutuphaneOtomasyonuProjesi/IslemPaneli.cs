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
    public partial class IslemPaneli : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C7MKVLR\\SQLEXPRESS01; initial catalog=KutuphaneOtomasyon; Integrated Security=TRUE");

        public IslemPaneli()
        {
            InitializeComponent();
        }

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            //Kullanıcı butonları girişte kapalıdır.(ekle-güncelle-sil)
            btnKullaniciEkle.Visible = false;
            btnKullaniciGuncelle.Visible = false;
            btnKullaniciSil.Visible = false;

            //Kaynak butonları girişte kapalıdır.(ekle-güncelle-sil)
            btnKaynakEkle.Visible = false;
            btnKaynakGuncelle.Visible = false;
            btnKaynakSil.Visible = false;
        }

        private KullaniciListeForm kListeForm;

        //Kullanıcı Liste Ve Butonları Açar
        private void btnKullanici_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kullanicilar ", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            conn.Close();

            if (btnKullaniciEkle.Visible == false)
            {
                btnKullaniciEkle.Visible = true;
                btnKullaniciGuncelle.Visible = true;
                btnKullaniciSil.Visible = true;
                kListeForm = new KullaniciListeForm();
                kListeForm.MdiParent = this;
                kListeForm.Show();

            }
            else
            {
                btnKullaniciEkle.Visible = false;
                btnKullaniciGuncelle.Visible = false;
                btnKullaniciSil.Visible = false;
                kListeForm.Close();
            }



        }
        private Kullanici.KullaniciEkleForm ekleForm;
        private bool ekleKullaniciDurum = false;
        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (ekleKullaniciDurum == false)
            {
                ekleForm = new Kullanici.KullaniciEkleForm();
                ekleForm.MdiParent = this;
                ekleForm.Show();
                ekleKullaniciDurum = true;
            }
            else
            {
                ekleForm.Close();
                ekleKullaniciDurum = false;
            }
        }


        private KullaniciSilForm kSil;
        private bool silKullaniciDurum = false;
        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (silKullaniciDurum == false)
            {
                kSil = new KullaniciSilForm();
                kSil.MdiParent = this;
                kSil.Show();
                silKullaniciDurum = true;
            }
            else
            {
                kSil.Close();
                silKullaniciDurum = false;
            }
        }




        private KullaniciGuncelleForm kGuncel;
        private bool guncelleKullaniciDurum = false;

        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            if (guncelleKullaniciDurum == false)
            {
                kGuncel = new KullaniciGuncelleForm();
                kGuncel.MdiParent = this;
                kGuncel.Show();
                guncelleKullaniciDurum = true;
            }
            else
            {
                kGuncel.Close();
                guncelleKullaniciDurum = false;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private Kaynak.KaynakListeForm kListe;
        private void btnKaynak_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kaynaklar ", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            conn.Close();

            if (btnKaynakEkle.Visible == false)
            {
                btnKaynakEkle.Visible = true;
                btnKaynakGuncelle.Visible = true;
                btnKaynakSil.Visible = true;
                kListe = new Kaynak.KaynakListeForm();
                kListe.MdiParent = this;
                kListe.Show();
            }
            else
            {
                btnKaynakEkle.Visible = false;
                btnKaynakGuncelle.Visible = false;
                btnKaynakSil.Visible = false;
                kListe.Close();
            }


        }




        private void pnlKullaniciBilgi_Paint(object sender, PaintEventArgs e)
        {

        }


        private Kaynak.KaynakEkleForm kEkle;
        private bool ekleKaynakDurum = false;

        private void btnKaynakEkle_Click(object sender, EventArgs e)
        {
            if (ekleKaynakDurum == false)
            {
                kEkle = new Kaynak.KaynakEkleForm();
                kEkle.MdiParent = this;
                kEkle.Show();
                ekleKaynakDurum = true;
            }
            else
            {
                kEkle.Close();
                ekleKaynakDurum = false;
            }
        }



        private Kaynak.KaynakGuncelleForm kGuncelle;
        private bool guncelleKaynakDurum = false;

        private void btnKaynakGuncelle_Click(object sender, EventArgs e)
        {
            if (guncelleKaynakDurum == false)
            {

                kGuncelle = new Kaynak.KaynakGuncelleForm();
                kGuncelle.MdiParent = this;
                kGuncelle.Show();
                guncelleKaynakDurum = true;

            }
            else
            {
                kGuncelle.Close();
                guncelleKaynakDurum = false;
            }
        }



        private Kaynak.KaynakSilForm kaSil;
        private bool silKaynakDurum = false;

        private void btnKaynakSil_Click(object sender, EventArgs e)
        {
            if (silKaynakDurum == false)
            {

                kaSil = new Kaynak.KaynakSilForm();
                kaSil.MdiParent = this;
                kaSil.Show();
                silKaynakDurum = true;
            }
            else
            {
                kaSil.Close();
                silKaynakDurum = false;
            }
        }


        private Kayit.OduncVerForm oduncVer;
        private bool oduncVerDurum = false;
        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            if (oduncVerDurum == false)
            {
                oduncVer = new Kayit.OduncVerForm();
                oduncVer.MdiParent = this;
                oduncVer.Show();
                oduncVerDurum = true;
            }
            else
            {
                oduncVer.Close();
                oduncVerDurum = false;
            }

        }



        private Kayit.GeriAlForm geriAlForm;
        private bool geriAlDurum = false;
        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            if (geriAlDurum == false)
            {
                geriAlForm = new Kayit.GeriAlForm();
                geriAlForm.MdiParent = this;
                geriAlForm.Show();
                geriAlDurum = true;
            }
            else
            {
                geriAlForm.Close();
                geriAlDurum = false;
            }

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

        private void IslemPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void IslemPaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
