namespace denemetelefonrehberi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.numaraEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçilenNumarayiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçilenNumarayiGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_AdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Numara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textAra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numaraEkleToolStripMenuItem,
            this.seçilenNumarayiSilToolStripMenuItem,
            this.seçilenNumarayiGuncelleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1158, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // numaraEkleToolStripMenuItem
            // 
            this.numaraEkleToolStripMenuItem.Name = "numaraEkleToolStripMenuItem";
            this.numaraEkleToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.numaraEkleToolStripMenuItem.Text = "Numara Ekle";
            this.numaraEkleToolStripMenuItem.Click += new System.EventHandler(this.numaraEkleToolStripMenuItem_Click);
            // 
            // seçilenNumarayiSilToolStripMenuItem
            // 
            this.seçilenNumarayiSilToolStripMenuItem.Name = "seçilenNumarayiSilToolStripMenuItem";
            this.seçilenNumarayiSilToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.seçilenNumarayiSilToolStripMenuItem.Text = "Seçilen Numarayı Sil";
            this.seçilenNumarayiSilToolStripMenuItem.Click += new System.EventHandler(this.seçilenNumarayiSilToolStripMenuItem_Click);
            // 
            // seçilenNumarayiGuncelleToolStripMenuItem
            // 
            this.seçilenNumarayiGuncelleToolStripMenuItem.Name = "seçilenNumarayiGuncelleToolStripMenuItem";
            this.seçilenNumarayiGuncelleToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.seçilenNumarayiGuncelleToolStripMenuItem.Text = "Seçilen Numarayı Güncelle";
            this.seçilenNumarayiGuncelleToolStripMenuItem.Click += new System.EventHandler(this.seçilenNumarayiGuncelleToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1158, 465);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıtlı Numaralar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Id,
            this.C_AdSoyad,
            this.C_Email,
            this.C_Numara});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1152, 444);
            this.dataGridView1.TabIndex = 0;
            // 
            // C_Id
            // 
            this.C_Id.HeaderText = "Id";
            this.C_Id.Name = "C_Id";
            this.C_Id.ReadOnly = true;
            this.C_Id.Visible = false;
            // 
            // C_AdSoyad
            // 
            this.C_AdSoyad.HeaderText = "Ad Soyad";
            this.C_AdSoyad.Name = "C_AdSoyad";
            this.C_AdSoyad.ReadOnly = true;
            // 
            // C_Email
            // 
            this.C_Email.HeaderText = "Mail";
            this.C_Email.Name = "C_Email";
            this.C_Email.ReadOnly = true;
            // 
            // C_Numara
            // 
            this.C_Numara.HeaderText = "Telefon Numarası";
            this.C_Numara.Name = "C_Numara";
            this.C_Numara.ReadOnly = true;
            // 
            // textAra
            // 
            this.textAra.Location = new System.Drawing.Point(502, 4);
            this.textAra.Name = "textAra";
            this.textAra.Size = new System.Drawing.Size(136, 22);
            this.textAra.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kişi Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(812, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kayıtlı Numaralar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 493);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textAra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem numaraEkleToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_AdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Numara;
        private System.Windows.Forms.ToolStripMenuItem seçilenNumarayiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçilenNumarayiGuncelleToolStripMenuItem;
        private System.Windows.Forms.TextBox textAra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

