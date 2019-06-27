namespace takip1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izinKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtToolStripMenuItem,
            this.raporlamaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // kayıtToolStripMenuItem
            // 
            this.kayıtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtEkleToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.düzenlemeToolStripMenuItem});
            this.kayıtToolStripMenuItem.Name = "kayıtToolStripMenuItem";
            this.kayıtToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.kayıtToolStripMenuItem.Text = "Kayıt";
            // 
            // kayıtEkleToolStripMenuItem
            // 
            this.kayıtEkleToolStripMenuItem.Name = "kayıtEkleToolStripMenuItem";
            this.kayıtEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kayıtEkleToolStripMenuItem.Text = "İşe Giriş";
            this.kayıtEkleToolStripMenuItem.Click += new System.EventHandler(this.kayıtEkleToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.düzenleToolStripMenuItem.Text = "İşten Çıkış";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // düzenlemeToolStripMenuItem
            // 
            this.düzenlemeToolStripMenuItem.Name = "düzenlemeToolStripMenuItem";
            this.düzenlemeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.düzenlemeToolStripMenuItem.Text = "Düzenleme";
            this.düzenlemeToolStripMenuItem.Click += new System.EventHandler(this.düzenlemeToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izinKayıtToolStripMenuItem,
            this.raporlamaToolStripMenuItem1});
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.raporlamaToolStripMenuItem.Text = "İzin İşlemleri";
            this.raporlamaToolStripMenuItem.Click += new System.EventHandler(this.raporlamaToolStripMenuItem_Click);
            // 
            // izinKayıtToolStripMenuItem
            // 
            this.izinKayıtToolStripMenuItem.Name = "izinKayıtToolStripMenuItem";
            this.izinKayıtToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.izinKayıtToolStripMenuItem.Text = "İzin Kayıt";
            this.izinKayıtToolStripMenuItem.Click += new System.EventHandler(this.izinKayıtToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem1
            // 
            this.raporlamaToolStripMenuItem1.Name = "raporlamaToolStripMenuItem1";
            this.raporlamaToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.raporlamaToolStripMenuItem1.Text = "Raporlama";
            this.raporlamaToolStripMenuItem1.Click += new System.EventHandler(this.raporlamaToolStripMenuItem1_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Location = new System.Drawing.Point(181, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightBlue;
            this.textBox1.Location = new System.Drawing.Point(181, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Kullancı Adı";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightBlue;
            this.textBox2.Location = new System.Drawing.Point(181, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(171, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Şifre";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(544, 413);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "BİTES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izinKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

