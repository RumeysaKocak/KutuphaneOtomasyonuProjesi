namespace KutuphaneOtomasyonuProjesi.Kaynak
{
    partial class KaynakGuncelleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.nudSayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.btnKaynakGuncelle = new System.Windows.Forms.Button();
            this.txtKaynakYayinevi = new System.Windows.Forms.TextBox();
            this.txtKaynakYazari = new System.Windows.Forms.TextBox();
            this.txtKaynakIsmi = new System.Windows.Forms.TextBox();
            this.lblYayinevi = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSayfa = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayfaSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(103, 170);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpTarih.TabIndex = 46;
            // 
            // nudSayfaSayisi
            // 
            this.nudSayfaSayisi.Location = new System.Drawing.Point(103, 142);
            this.nudSayfaSayisi.Name = "nudSayfaSayisi";
            this.nudSayfaSayisi.Size = new System.Drawing.Size(200, 22);
            this.nudSayfaSayisi.TabIndex = 45;
            // 
            // btnKaynakGuncelle
            // 
            this.btnKaynakGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKaynakGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaynakGuncelle.Location = new System.Drawing.Point(103, 216);
            this.btnKaynakGuncelle.Name = "btnKaynakGuncelle";
            this.btnKaynakGuncelle.Size = new System.Drawing.Size(200, 35);
            this.btnKaynakGuncelle.TabIndex = 44;
            this.btnKaynakGuncelle.Text = "GÜNCELLE";
            this.btnKaynakGuncelle.UseVisualStyleBackColor = false;
            this.btnKaynakGuncelle.Click += new System.EventHandler(this.btnKaynakGuncelle_Click);
            // 
            // txtKaynakYayinevi
            // 
            this.txtKaynakYayinevi.Location = new System.Drawing.Point(103, 114);
            this.txtKaynakYayinevi.Name = "txtKaynakYayinevi";
            this.txtKaynakYayinevi.Size = new System.Drawing.Size(200, 22);
            this.txtKaynakYayinevi.TabIndex = 43;
            // 
            // txtKaynakYazari
            // 
            this.txtKaynakYazari.Location = new System.Drawing.Point(103, 88);
            this.txtKaynakYazari.Name = "txtKaynakYazari";
            this.txtKaynakYazari.Size = new System.Drawing.Size(200, 22);
            this.txtKaynakYazari.TabIndex = 42;
            // 
            // txtKaynakIsmi
            // 
            this.txtKaynakIsmi.Location = new System.Drawing.Point(103, 60);
            this.txtKaynakIsmi.Name = "txtKaynakIsmi";
            this.txtKaynakIsmi.Size = new System.Drawing.Size(200, 22);
            this.txtKaynakIsmi.TabIndex = 41;
            // 
            // lblYayinevi
            // 
            this.lblYayinevi.AutoSize = true;
            this.lblYayinevi.Location = new System.Drawing.Point(28, 119);
            this.lblYayinevi.Name = "lblYayinevi";
            this.lblYayinevi.Size = new System.Drawing.Size(73, 17);
            this.lblYayinevi.TabIndex = 40;
            this.lblYayinevi.Text = "Yayınevi : ";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(44, 175);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(53, 17);
            this.lblTarih.TabIndex = 39;
            this.lblTarih.Text = "Tarih : ";
            // 
            // lblSayfa
            // 
            this.lblSayfa.AutoSize = true;
            this.lblSayfa.Location = new System.Drawing.Point(4, 144);
            this.lblSayfa.Name = "lblSayfa";
            this.lblSayfa.Size = new System.Drawing.Size(97, 17);
            this.lblSayfa.TabIndex = 38;
            this.lblSayfa.Text = "Sayfa Sayısı : ";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Location = new System.Drawing.Point(37, 87);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(57, 17);
            this.lblYazar.TabIndex = 37;
            this.lblYazar.Text = "Yazar : ";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(59, 60);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(37, 17);
            this.lblIsim.TabIndex = 36;
            this.lblIsim.Text = "Ad : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(332, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(841, 403);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // KaynakGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1194, 569);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.nudSayfaSayisi);
            this.Controls.Add(this.btnKaynakGuncelle);
            this.Controls.Add(this.txtKaynakYayinevi);
            this.Controls.Add(this.txtKaynakYazari);
            this.Controls.Add(this.txtKaynakIsmi);
            this.Controls.Add(this.lblYayinevi);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblSayfa);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.lblIsim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KaynakGuncelleForm";
            this.Text = "KaynakGuncelleForm";
            this.Load += new System.EventHandler(this.KaynakGuncelleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSayfaSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.NumericUpDown nudSayfaSayisi;
        private System.Windows.Forms.Button btnKaynakGuncelle;
        private System.Windows.Forms.TextBox txtKaynakYayinevi;
        private System.Windows.Forms.TextBox txtKaynakYazari;
        private System.Windows.Forms.TextBox txtKaynakIsmi;
        private System.Windows.Forms.Label lblYayinevi;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSayfa;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}