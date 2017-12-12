namespace AkilliSulamaSistemi
{
    partial class bilgiEkrani
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bilgiEkrani));
            this.isim = new System.Windows.Forms.Label();
            this.baslat = new System.Windows.Forms.Button();
            this.toprakNem = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.suSeviyesi = new System.Windows.Forms.ProgressBar();
            this.suMotoruCalistir = new System.Windows.Forms.Button();
            this.cikisYap = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nemDegeri = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.suDegeri = new System.Windows.Forms.Label();
            this.degerlerListesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nemListesi = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.portCombobox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.durdur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.BackColor = System.Drawing.Color.White;
            this.isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim.Location = new System.Drawing.Point(320, 26);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(232, 25);
            this.isim.TabIndex = 0;
            this.isim.Text = "Akıllı Sulama Sistemi";
            // 
            // baslat
            // 
            this.baslat.BackColor = System.Drawing.Color.Lime;
            this.baslat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.baslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslat.ForeColor = System.Drawing.Color.Black;
            this.baslat.Location = new System.Drawing.Point(54, 95);
            this.baslat.Name = "baslat";
            this.baslat.Size = new System.Drawing.Size(128, 41);
            this.baslat.TabIndex = 1;
            this.baslat.Text = "Başlat";
            this.baslat.UseVisualStyleBackColor = false;
            this.baslat.Click += new System.EventHandler(this.baslat_Click);
            // 
            // toprakNem
            // 
            this.toprakNem.BackColor = System.Drawing.Color.White;
            this.toprakNem.Location = new System.Drawing.Point(54, 196);
            this.toprakNem.Name = "toprakNem";
            this.toprakNem.Size = new System.Drawing.Size(285, 23);
            this.toprakNem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toprak Nem Seviyesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(371, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Su Seviyesi";
            // 
            // suSeviyesi
            // 
            this.suSeviyesi.BackColor = System.Drawing.Color.White;
            this.suSeviyesi.Location = new System.Drawing.Point(375, 196);
            this.suSeviyesi.Name = "suSeviyesi";
            this.suSeviyesi.Size = new System.Drawing.Size(285, 23);
            this.suSeviyesi.TabIndex = 5;
            // 
            // suMotoruCalistir
            // 
            this.suMotoruCalistir.BackColor = System.Drawing.Color.Lime;
            this.suMotoruCalistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.suMotoruCalistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.suMotoruCalistir.ForeColor = System.Drawing.Color.Black;
            this.suMotoruCalistir.Location = new System.Drawing.Point(362, 95);
            this.suMotoruCalistir.Name = "suMotoruCalistir";
            this.suMotoruCalistir.Size = new System.Drawing.Size(190, 41);
            this.suMotoruCalistir.TabIndex = 6;
            this.suMotoruCalistir.Text = "Su Motorunu Çalıştır";
            this.suMotoruCalistir.UseVisualStyleBackColor = false;
            this.suMotoruCalistir.Click += new System.EventHandler(this.suMotoruCalistir_Click);
            // 
            // cikisYap
            // 
            this.cikisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikisYap.BackgroundImage")));
            this.cikisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikisYap.Location = new System.Drawing.Point(714, 442);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(75, 68);
            this.cikisYap.TabIndex = 8;
            this.cikisYap.UseVisualStyleBackColor = true;
            this.cikisYap.Click += new System.EventHandler(this.cikisYap_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeri.Location = new System.Drawing.Point(714, 354);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 68);
            this.btnGeri.TabIndex = 9;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Toprak Nem Degeri:";
            // 
            // nemDegeri
            // 
            this.nemDegeri.AutoSize = true;
            this.nemDegeri.BackColor = System.Drawing.Color.Transparent;
            this.nemDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nemDegeri.Location = new System.Drawing.Point(255, 238);
            this.nemDegeri.Name = "nemDegeri";
            this.nemDegeri.Size = new System.Drawing.Size(32, 24);
            this.nemDegeri.TabIndex = 11;
            this.nemDegeri.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(371, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Su Seviyesi Degeri:";
            // 
            // suDegeri
            // 
            this.suDegeri.AutoSize = true;
            this.suDegeri.BackColor = System.Drawing.Color.Transparent;
            this.suDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.suDegeri.Location = new System.Drawing.Point(569, 238);
            this.suDegeri.Name = "suDegeri";
            this.suDegeri.Size = new System.Drawing.Size(32, 24);
            this.suDegeri.TabIndex = 13;
            this.suDegeri.Text = "00";
            // 
            // degerlerListesi
            // 
            this.degerlerListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.degerlerListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.degerlerListesi.FullRowSelect = true;
            this.degerlerListesi.GridLines = true;
            this.degerlerListesi.Location = new System.Drawing.Point(68, 313);
            this.degerlerListesi.Name = "degerlerListesi";
            this.degerlerListesi.Size = new System.Drawing.Size(333, 219);
            this.degerlerListesi.TabIndex = 16;
            this.degerlerListesi.UseCompatibleStateImageBehavior = false;
            this.degerlerListesi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Toprak Nem";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Su Seviyesi";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tarih";
            this.columnHeader3.Width = 310;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(50, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ölçülen Değerlerin Listesi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(371, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(406, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Su Motoru Aktifken Ölçülen Nem Değerleri";
            // 
            // nemListesi
            // 
            this.nemListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.nemListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nemListesi.FullRowSelect = true;
            this.nemListesi.GridLines = true;
            this.nemListesi.Location = new System.Drawing.Point(407, 313);
            this.nemListesi.Name = "nemListesi";
            this.nemListesi.Size = new System.Drawing.Size(253, 219);
            this.nemListesi.TabIndex = 19;
            this.nemListesi.UseCompatibleStateImageBehavior = false;
            this.nemListesi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Toprak Nem";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tarih";
            this.columnHeader5.Width = 310;
            // 
            // portCombobox
            // 
            this.portCombobox.FormattingEnabled = true;
            this.portCombobox.Location = new System.Drawing.Point(111, 26);
            this.portCombobox.Name = "portCombobox";
            this.portCombobox.Size = new System.Drawing.Size(121, 21);
            this.portCombobox.TabIndex = 20;
            this.portCombobox.SelectedIndexChanged += new System.EventHandler(this.portCombobox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(50, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Port:";
            // 
            // timer1
            // 
            this.timer1.Interval = 305;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // durdur
            // 
            this.durdur.BackColor = System.Drawing.Color.Red;
            this.durdur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.durdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durdur.ForeColor = System.Drawing.Color.Black;
            this.durdur.Location = new System.Drawing.Point(204, 95);
            this.durdur.Name = "durdur";
            this.durdur.Size = new System.Drawing.Size(135, 41);
            this.durdur.TabIndex = 22;
            this.durdur.Text = "Durdur";
            this.durdur.UseVisualStyleBackColor = false;
            this.durdur.Click += new System.EventHandler(this.durdur_Click);
            // 
            // bilgiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(819, 554);
            this.Controls.Add(this.durdur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.portCombobox);
            this.Controls.Add(this.nemListesi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.degerlerListesi);
            this.Controls.Add(this.suDegeri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nemDegeri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.cikisYap);
            this.Controls.Add(this.suMotoruCalistir);
            this.Controls.Add(this.suSeviyesi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toprakNem);
            this.Controls.Add(this.baslat);
            this.Controls.Add(this.isim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bilgiEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bilgiEkrani";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.bilgiEkrani_FormClosed);
            this.Load += new System.EventHandler(this.bilgiEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.Button baslat;
        private System.Windows.Forms.ProgressBar toprakNem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar suSeviyesi;
        private System.Windows.Forms.Button suMotoruCalistir;
        private System.Windows.Forms.Button cikisYap;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nemDegeri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label suDegeri;
        private System.Windows.Forms.ListView degerlerListesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView nemListesi;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox portCombobox;
        private System.Windows.Forms.Label label7;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button durdur;
    }
}