namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnSil = new Button();
            btnGetir = new Button();
            btnGuncelle = new Button();
            btnFilmler = new Button();
            btnYonetmenler = new Button();
            gbYonetmenIslem = new GroupBox();
            txtYonetmenIDy = new TextBox();
            lblYonetmenIDy = new Label();
            label5 = new Label();
            txtYonetmenYas = new TextBox();
            txtYonetmenAd = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtYonetmenSoyad = new TextBox();
            btnYonetmenGuncelle = new Button();
            btnYonetmenSil = new Button();
            btnYonetmenEkle = new Button();
            gbFilmIslem = new GroupBox();
            txtFilmID = new TextBox();
            lblfilmID = new Label();
            btnFilmSil = new Button();
            btnFilmEkle = new Button();
            label6 = new Label();
            txtReleaseDate = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtYonetmenID = new TextBox();
            btnFilmiGuncelle = new Button();
            gbIslemler = new GroupBox();
            lblInfo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbYonetmenIslem.SuspendLayout();
            gbFilmIslem.SuspendLayout();
            gbIslemler.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(62, 344);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 228);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(34, 91);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(155, 40);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(250, 91);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(155, 40);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(682, 91);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(155, 40);
            btnGetir.TabIndex = 3;
            btnGetir.Text = "Listele";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(466, 91);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(155, 40);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnFilmler
            // 
            btnFilmler.Location = new Point(247, 12);
            btnFilmler.Name = "btnFilmler";
            btnFilmler.Size = new Size(155, 40);
            btnFilmler.TabIndex = 6;
            btnFilmler.Text = "Filmler";
            btnFilmler.UseVisualStyleBackColor = true;
            btnFilmler.Click += btnFilmler_Click;
            // 
            // btnYonetmenler
            // 
            btnYonetmenler.Location = new Point(439, 12);
            btnYonetmenler.Name = "btnYonetmenler";
            btnYonetmenler.Size = new Size(155, 40);
            btnYonetmenler.TabIndex = 7;
            btnYonetmenler.Text = "Yonetmenler";
            btnYonetmenler.UseVisualStyleBackColor = true;
            btnYonetmenler.Click += btnYonetmenler_Click;
            // 
            // gbYonetmenIslem
            // 
            gbYonetmenIslem.Controls.Add(txtYonetmenIDy);
            gbYonetmenIslem.Controls.Add(lblYonetmenIDy);
            gbYonetmenIslem.Controls.Add(label5);
            gbYonetmenIslem.Controls.Add(txtYonetmenYas);
            gbYonetmenIslem.Controls.Add(txtYonetmenAd);
            gbYonetmenIslem.Controls.Add(label3);
            gbYonetmenIslem.Controls.Add(label4);
            gbYonetmenIslem.Controls.Add(txtYonetmenSoyad);
            gbYonetmenIslem.Controls.Add(btnYonetmenGuncelle);
            gbYonetmenIslem.Controls.Add(btnYonetmenSil);
            gbYonetmenIslem.Controls.Add(btnYonetmenEkle);
            gbYonetmenIslem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            gbYonetmenIslem.Location = new Point(23, 13);
            gbYonetmenIslem.Name = "gbYonetmenIslem";
            gbYonetmenIslem.Size = new Size(716, 146);
            gbYonetmenIslem.TabIndex = 10;
            gbYonetmenIslem.TabStop = false;
            gbYonetmenIslem.Text = "Yonetmen işlemleri";
            gbYonetmenIslem.Visible = false;
            // 
            // txtYonetmenIDy
            // 
            txtYonetmenIDy.Location = new Point(487, 111);
            txtYonetmenIDy.Name = "txtYonetmenIDy";
            txtYonetmenIDy.Size = new Size(223, 29);
            txtYonetmenIDy.TabIndex = 18;
            // 
            // lblYonetmenIDy
            // 
            lblYonetmenIDy.AutoSize = true;
            lblYonetmenIDy.Location = new Point(380, 115);
            lblYonetmenIDy.Name = "lblYonetmenIDy";
            lblYonetmenIDy.Size = new Size(102, 21);
            lblYonetmenIDy.TabIndex = 19;
            lblYonetmenIDy.Text = "Yonetmen ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 95);
            label5.Name = "label5";
            label5.Size = new Size(114, 21);
            label5.TabIndex = 5;
            label5.Text = "Yonetmen Yaşı:";
            // 
            // txtYonetmenYas
            // 
            txtYonetmenYas.Location = new Point(151, 93);
            txtYonetmenYas.Name = "txtYonetmenYas";
            txtYonetmenYas.Size = new Size(223, 29);
            txtYonetmenYas.TabIndex = 4;
            // 
            // txtYonetmenAd
            // 
            txtYonetmenAd.Location = new Point(151, 25);
            txtYonetmenAd.Name = "txtYonetmenAd";
            txtYonetmenAd.Size = new Size(223, 29);
            txtYonetmenAd.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 66);
            label3.Name = "label3";
            label3.Size = new Size(130, 21);
            label3.TabIndex = 3;
            label3.Text = "Yonetmen Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 31);
            label4.Name = "label4";
            label4.Size = new Size(106, 21);
            label4.TabIndex = 1;
            label4.Text = "Yonetmen Ad:";
            // 
            // txtYonetmenSoyad
            // 
            txtYonetmenSoyad.Location = new Point(151, 58);
            txtYonetmenSoyad.Name = "txtYonetmenSoyad";
            txtYonetmenSoyad.Size = new Size(223, 29);
            txtYonetmenSoyad.TabIndex = 2;
            // 
            // btnYonetmenGuncelle
            // 
            btnYonetmenGuncelle.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btnYonetmenGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnYonetmenGuncelle.FlatStyle = FlatStyle.Flat;
            btnYonetmenGuncelle.Location = new Point(488, 57);
            btnYonetmenGuncelle.Name = "btnYonetmenGuncelle";
            btnYonetmenGuncelle.Size = new Size(176, 36);
            btnYonetmenGuncelle.TabIndex = 17;
            btnYonetmenGuncelle.Text = "Yönetmeni Güncelle";
            btnYonetmenGuncelle.UseVisualStyleBackColor = true;
            btnYonetmenGuncelle.Click += btnYonetmenGuncelle_Click;
            // 
            // btnYonetmenSil
            // 
            btnYonetmenSil.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btnYonetmenSil.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnYonetmenSil.FlatStyle = FlatStyle.Flat;
            btnYonetmenSil.Location = new Point(488, 57);
            btnYonetmenSil.Name = "btnYonetmenSil";
            btnYonetmenSil.Size = new Size(176, 36);
            btnYonetmenSil.TabIndex = 16;
            btnYonetmenSil.Text = "Yönetmeni Sil";
            btnYonetmenSil.UseVisualStyleBackColor = true;
            btnYonetmenSil.Click += btnYonetmenSil_Click;
            // 
            // btnYonetmenEkle
            // 
            btnYonetmenEkle.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnYonetmenEkle.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnYonetmenEkle.FlatStyle = FlatStyle.Flat;
            btnYonetmenEkle.Location = new Point(488, 57);
            btnYonetmenEkle.Name = "btnYonetmenEkle";
            btnYonetmenEkle.Size = new Size(176, 36);
            btnYonetmenEkle.TabIndex = 12;
            btnYonetmenEkle.Text = "Yönetmeni Ekle";
            btnYonetmenEkle.UseVisualStyleBackColor = true;
            btnYonetmenEkle.Click += btnYonetmenEkle_Click;
            // 
            // gbFilmIslem
            // 
            gbFilmIslem.Controls.Add(txtFilmID);
            gbFilmIslem.Controls.Add(lblfilmID);
            gbFilmIslem.Controls.Add(label6);
            gbFilmIslem.Controls.Add(txtReleaseDate);
            gbFilmIslem.Controls.Add(txtName);
            gbFilmIslem.Controls.Add(label2);
            gbFilmIslem.Controls.Add(label1);
            gbFilmIslem.Controls.Add(txtYonetmenID);
            gbFilmIslem.Controls.Add(btnFilmiGuncelle);
            gbFilmIslem.Controls.Add(btnFilmSil);
            gbFilmIslem.Controls.Add(btnFilmEkle);
            gbFilmIslem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            gbFilmIslem.Location = new Point(23, 13);
            gbFilmIslem.Name = "gbFilmIslem";
            gbFilmIslem.Size = new Size(716, 146);
            gbFilmIslem.TabIndex = 9;
            gbFilmIslem.TabStop = false;
            gbFilmIslem.Text = "Film işlemleri";
            gbFilmIslem.Visible = false;
            // 
            // txtFilmID
            // 
            txtFilmID.Location = new Point(455, 107);
            txtFilmID.Name = "txtFilmID";
            txtFilmID.Size = new Size(223, 29);
            txtFilmID.TabIndex = 16;
            // 
            // lblfilmID
            // 
            lblfilmID.AutoSize = true;
            lblfilmID.Location = new Point(387, 111);
            lblfilmID.Name = "lblfilmID";
            lblfilmID.Size = new Size(62, 21);
            lblfilmID.TabIndex = 17;
            lblfilmID.Text = "Film ID:";
            // 
            // btnFilmSil
            // 
            btnFilmSil.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btnFilmSil.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnFilmSil.FlatStyle = FlatStyle.Flat;
            btnFilmSil.Location = new Point(488, 57);
            btnFilmSil.Name = "btnFilmSil";
            btnFilmSil.Size = new Size(176, 36);
            btnFilmSil.TabIndex = 14;
            btnFilmSil.Text = "Filmi Sil";
            btnFilmSil.UseVisualStyleBackColor = true;
            btnFilmSil.Click += btnFilmSil_Click;
            // 
            // btnFilmEkle
            // 
            btnFilmEkle.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnFilmEkle.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnFilmEkle.FlatStyle = FlatStyle.Flat;
            btnFilmEkle.Location = new Point(488, 57);
            btnFilmEkle.Name = "btnFilmEkle";
            btnFilmEkle.Size = new Size(176, 36);
            btnFilmEkle.TabIndex = 13;
            btnFilmEkle.Text = "Filmi Ekle";
            btnFilmEkle.UseVisualStyleBackColor = true;
            btnFilmEkle.Click += btnFilmEkle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 103);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 5;
            label6.Text = "ÇıkışTarihi:";
            // 
            // txtReleaseDate
            // 
            txtReleaseDate.Location = new Point(117, 100);
            txtReleaseDate.Name = "txtReleaseDate";
            txtReleaseDate.Size = new Size(223, 29);
            txtReleaseDate.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(117, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 29);
            txtName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 68);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 3;
            label2.Text = "YonetmenID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 36);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 1;
            label1.Text = "İsim:";
            // 
            // txtYonetmenID
            // 
            txtYonetmenID.Location = new Point(117, 65);
            txtYonetmenID.Name = "txtYonetmenID";
            txtYonetmenID.Size = new Size(223, 29);
            txtYonetmenID.TabIndex = 2;
            // 
            // btnFilmiGuncelle
            // 
            btnFilmiGuncelle.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            btnFilmiGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnFilmiGuncelle.FlatStyle = FlatStyle.Flat;
            btnFilmiGuncelle.Location = new Point(488, 57);
            btnFilmiGuncelle.Name = "btnFilmiGuncelle";
            btnFilmiGuncelle.Size = new Size(176, 36);
            btnFilmiGuncelle.TabIndex = 15;
            btnFilmiGuncelle.Text = "Filmi Guncelle";
            btnFilmiGuncelle.UseVisualStyleBackColor = true;
            btnFilmiGuncelle.Click += btnFilmiGuncelle_Click;
            // 
            // gbIslemler
            // 
            gbIslemler.Controls.Add(lblInfo);
            gbIslemler.Controls.Add(gbYonetmenIslem);
            gbIslemler.Controls.Add(gbFilmIslem);
            gbIslemler.Location = new Point(39, 146);
            gbIslemler.Name = "gbIslemler";
            gbIslemler.Size = new Size(799, 192);
            gbIslemler.TabIndex = 11;
            gbIslemler.TabStop = false;
            gbIslemler.Text = "işlemler";
            gbIslemler.Visible = false;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblInfo.ForeColor = Color.Black;
            lblInfo.Location = new Point(23, 164);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(216, 21);
            lblInfo.TabIndex = 11;
            lblInfo.Text = "infolar burada gösterilecek";
            lblInfo.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 620);
            Controls.Add(btnYonetmenler);
            Controls.Add(btnFilmler);
            Controls.Add(btnGuncelle);
            Controls.Add(btnGetir);
            Controls.Add(btnSil);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(gbIslemler);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbYonetmenIslem.ResumeLayout(false);
            gbYonetmenIslem.PerformLayout();
            gbFilmIslem.ResumeLayout(false);
            gbFilmIslem.PerformLayout();
            gbIslemler.ResumeLayout(false);
            gbIslemler.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnSil;
        private Button btnGetir;
        private Button btnGuncelle;
        private Button btnFilmler;
        private Button btnYonetmenler;
        private Label label2;
        private TextBox txtYonetmenID;
        private Label label1;
        private TextBox txtName;
        private GroupBox gbFilmIslem;
        private GroupBox gbYonetmenIslem;
        private TextBox txtYonetmenAd;
        private Label label3;
        private Label label4;
        private TextBox txtYonetmenSoyad;
        private GroupBox gbIslemler;
        private Label label5;
        private TextBox txtYonetmenYas;
        private Button btnYonetmenEkle;
        private Button btnFilmEkle;
        private Label label6;
        private TextBox txtReleaseDate;
        private Label lblInfo;
        private System.Windows.Forms.Timer timer1;
        private Button btnFilmSil;
        private Button btnFilmiGuncelle;
        private Button btnYonetmenGuncelle;
        private Button btnYonetmenSil;
        private TextBox txtFilmID;
        private Label lblfilmID;
        private TextBox txtYonetmenIDy;
        private Label lblYonetmenIDy;
    }
}
