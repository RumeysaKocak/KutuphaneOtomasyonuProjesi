namespace KutuphaneOtomasyonuProjesi.Kaynak
{
    partial class KaynakEkleForm
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
            this.btnKaynakEkle = new System.Windows.Forms.Button();
            this.txtKaynakYayinevi = new System.Windows.Forms.TextBox();
            this.txtKaynakYazari = new System.Windows.Forms.TextBox();
            this.txtKaynakIsmi = new System.Windows.Forms.TextBox();
            this.lblYayinevi = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSayfa = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nudSayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayfaSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaynakEkle
            // 
            this.btnKaynakEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKaynakEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaynakEkle.Location = new System.Drawing.Point(96, 199);
            this.btnKaynakEkle.Name = "btnKaynakEkle";
            this.btnKaynakEkle.Size = new System.Drawing.Size(200, 35);
            this.btnKaynakEkle.TabIndex = 32;
            this.btnKaynakEkle.Text = "EKLE";
            this.btnKaynakEkle.UseVisualStyleBackColor = false;
            this.btnKaynakEkle.Click += new System.EventHandler(this.btnKaynakEkle_Click);
            // 
            // txtKaynakYayinevi
            // 
            this.txtKaynakYayinevi.Location = new System.Drawing.Point(96, 97);
            this.txtKaynakYayinevi.Name = "txtKaynakYayinevi";
            this.txtKaynakYayinevi.Size = new System.Drawing.Size(200, 22);
            this.txtKaynakYayinevi.TabIndex = 26;
           
            // 
            // txtKaynakYazari
            // 
            this.txtKaynakYazari.Location = new System.Drawing.Point(96, 71);
            this.txtKaynakYazari.Name = "txtKaynakYazari";
            this.txtKaynakYazari.Size = new System.Drawing.Size(200, 22);
            this.txtKaynakYazari.TabIndex = 25;
          
            // 
            // txtKaynakIsmi
            // 
            this.txtKaynakIsmi.Location = new System.Drawing.Point(96, 43);
            this.txtKaynakIsmi.Name = "txtKaynakIsmi";
            this.txtKaynakIsmi.Size = new System.Drawing.Size(200, 22);
            this.txtKaynakIsmi.TabIndex = 24;
            
            // 
            // lblYayinevi
            // 
            this.lblYayinevi.AutoSize = true;
            this.lblYayinevi.Location = new System.Drawing.Point(21, 102);
            this.lblYayinevi.Name = "lblYayinevi";
            this.lblYayinevi.Size = new System.Drawing.Size(73, 17);
            this.lblYayinevi.TabIndex = 23;
            this.lblYayinevi.Text = "Yayınevi : ";
         
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(37, 158);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(53, 17);
            this.lblTarih.TabIndex = 20;
            this.lblTarih.Text = "Tarih : ";
         
            // 
            // lblSayfa
            // 
            this.lblSayfa.AutoSize = true;
            this.lblSayfa.Location = new System.Drawing.Point(-3, 127);
            this.lblSayfa.Name = "lblSayfa";
            this.lblSayfa.Size = new System.Drawing.Size(97, 17);
            this.lblSayfa.TabIndex = 19;
            this.lblSayfa.Text = "Sayfa Sayısı : ";
        
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Location = new System.Drawing.Point(30, 70);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(57, 17);
            this.lblYazar.TabIndex = 18;
            this.lblYazar.Text = "Yazar : ";
        
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(52, 43);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(37, 17);
            this.lblIsim.TabIndex = 17;
            this.lblIsim.Text = "Ad : ";
        
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(317, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 428);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nudSayfaSayisi
            // 
            this.nudSayfaSayisi.Location = new System.Drawing.Point(96, 125);
            this.nudSayfaSayisi.Name = "nudSayfaSayisi";
            this.nudSayfaSayisi.Size = new System.Drawing.Size(200, 22);
            this.nudSayfaSayisi.TabIndex = 34;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(96, 153);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpTarih.TabIndex = 35;
            // 
            // KaynakEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1069, 525);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.nudSayfaSayisi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKaynakEkle);
            this.Controls.Add(this.txtKaynakYayinevi);
            this.Controls.Add(this.txtKaynakYazari);
            this.Controls.Add(this.txtKaynakIsmi);
            this.Controls.Add(this.lblYayinevi);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblSayfa);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.lblIsim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KaynakEkleForm";
            this.Text = "KaynakEkleForm";
            this.Load += new System.EventHandler(this.KaynakEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayfaSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaynakEkle;
        private System.Windows.Forms.TextBox txtKaynakYayinevi;
        private System.Windows.Forms.TextBox txtKaynakYazari;
        private System.Windows.Forms.TextBox txtKaynakIsmi;
        private System.Windows.Forms.Label lblYayinevi;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSayfa;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown nudSayfaSayisi;
        private System.Windows.Forms.DateTimePicker dtpTarih;
    }
}