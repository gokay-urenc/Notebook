namespace Not_Defteri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sayfaYapısıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonrakiniBulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.değiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saatTarihToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biçimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sözcükKaydırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayfaRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görevÇubuğuRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metniHizalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sağaHizalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solaHizalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortayaHizalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.geriAlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.biçimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem,
            this.toolStripSeparator1,
            this.sayfaYapısıToolStripMenuItem,
            this.yazdırToolStripMenuItem,
            this.toolStripSeparator2,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.yeniToolStripMenuItem.Text = "Yeni                   .";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.açToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            this.farklıKaydetToolStripMenuItem.Click += new System.EventHandler(this.farklıKaydetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // sayfaYapısıToolStripMenuItem
            // 
            this.sayfaYapısıToolStripMenuItem.Name = "sayfaYapısıToolStripMenuItem";
            this.sayfaYapısıToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.sayfaYapısıToolStripMenuItem.Text = "Sayfa Yapısı";
            this.sayfaYapısıToolStripMenuItem.Click += new System.EventHandler(this.sayfaYapısıToolStripMenuItem_Click);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlToolStripMenuItem,
            this.toolStripSeparator3,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.silToolStripMenuItem,
            this.toolStripSeparator4,
            this.bulToolStripMenuItem,
            this.sonrakiniBulToolStripMenuItem,
            this.değiştirToolStripMenuItem,
            this.gitToolStripMenuItem,
            this.toolStripSeparator5,
            this.tümünüSeçToolStripMenuItem,
            this.saatTarihToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.geriAlToolStripMenuItem.Text = "Geri Al                       .";
            this.geriAlToolStripMenuItem.Click += new System.EventHandler(this.geriAlToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(219, 6);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.silToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(219, 6);
            // 
            // bulToolStripMenuItem
            // 
            this.bulToolStripMenuItem.Name = "bulToolStripMenuItem";
            this.bulToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.bulToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.bulToolStripMenuItem.Text = "Bul";
            this.bulToolStripMenuItem.Click += new System.EventHandler(this.bulToolStripMenuItem_Click);
            // 
            // sonrakiniBulToolStripMenuItem
            // 
            this.sonrakiniBulToolStripMenuItem.Name = "sonrakiniBulToolStripMenuItem";
            this.sonrakiniBulToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.sonrakiniBulToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.sonrakiniBulToolStripMenuItem.Text = "Sonrakini Bul";
            this.sonrakiniBulToolStripMenuItem.Click += new System.EventHandler(this.sonrakiniBulToolStripMenuItem_Click);
            // 
            // değiştirToolStripMenuItem
            // 
            this.değiştirToolStripMenuItem.Name = "değiştirToolStripMenuItem";
            this.değiştirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.değiştirToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.değiştirToolStripMenuItem.Text = "Değiştir";
            this.değiştirToolStripMenuItem.Click += new System.EventHandler(this.değiştirToolStripMenuItem_Click);
            // 
            // gitToolStripMenuItem
            // 
            this.gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            this.gitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.gitToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.gitToolStripMenuItem.Text = "Git";
            this.gitToolStripMenuItem.Click += new System.EventHandler(this.gitToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(219, 6);
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.tümünüSeçToolStripMenuItem.Text = "Tümünü Seç";
            this.tümünüSeçToolStripMenuItem.Click += new System.EventHandler(this.tümünüSeçToolStripMenuItem_Click);
            // 
            // saatTarihToolStripMenuItem
            // 
            this.saatTarihToolStripMenuItem.Name = "saatTarihToolStripMenuItem";
            this.saatTarihToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.saatTarihToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.saatTarihToolStripMenuItem.Text = "Saat/Tarih";
            this.saatTarihToolStripMenuItem.Click += new System.EventHandler(this.saatTarihToolStripMenuItem_Click);
            // 
            // biçimToolStripMenuItem
            // 
            this.biçimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sözcükKaydırToolStripMenuItem,
            this.yazıTipiToolStripMenuItem,
            this.yazıRengiToolStripMenuItem,
            this.sayfaRengiToolStripMenuItem,
            this.görevÇubuğuRengiToolStripMenuItem,
            this.metniHizalaToolStripMenuItem});
            this.biçimToolStripMenuItem.Name = "biçimToolStripMenuItem";
            this.biçimToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.biçimToolStripMenuItem.Text = "Biçim";
            // 
            // sözcükKaydırToolStripMenuItem
            // 
            this.sözcükKaydırToolStripMenuItem.Name = "sözcükKaydırToolStripMenuItem";
            this.sözcükKaydırToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.sözcükKaydırToolStripMenuItem.Text = "Sözcük Kaydır";
            this.sözcükKaydırToolStripMenuItem.Click += new System.EventHandler(this.sözcükKaydırToolStripMenuItem_Click);
            // 
            // yazıTipiToolStripMenuItem
            // 
            this.yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            this.yazıTipiToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.yazıTipiToolStripMenuItem.Text = "Yazı Tipi";
            this.yazıTipiToolStripMenuItem.Click += new System.EventHandler(this.yazıTipiToolStripMenuItem_Click);
            // 
            // yazıRengiToolStripMenuItem
            // 
            this.yazıRengiToolStripMenuItem.Name = "yazıRengiToolStripMenuItem";
            this.yazıRengiToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.yazıRengiToolStripMenuItem.Text = "Yazı Rengi";
            this.yazıRengiToolStripMenuItem.Click += new System.EventHandler(this.yazıRengiToolStripMenuItem_Click);
            // 
            // sayfaRengiToolStripMenuItem
            // 
            this.sayfaRengiToolStripMenuItem.Name = "sayfaRengiToolStripMenuItem";
            this.sayfaRengiToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.sayfaRengiToolStripMenuItem.Text = "Sayfa Rengi";
            this.sayfaRengiToolStripMenuItem.Click += new System.EventHandler(this.sayfaRengiToolStripMenuItem_Click);
            // 
            // görevÇubuğuRengiToolStripMenuItem
            // 
            this.görevÇubuğuRengiToolStripMenuItem.Name = "görevÇubuğuRengiToolStripMenuItem";
            this.görevÇubuğuRengiToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.görevÇubuğuRengiToolStripMenuItem.Text = "Görev Çubuğu Rengi";
            this.görevÇubuğuRengiToolStripMenuItem.Click += new System.EventHandler(this.görevÇubuğuRengiToolStripMenuItem_Click);
            // 
            // metniHizalaToolStripMenuItem
            // 
            this.metniHizalaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sağaHizalaToolStripMenuItem,
            this.solaHizalaToolStripMenuItem,
            this.ortayaHizalaToolStripMenuItem});
            this.metniHizalaToolStripMenuItem.Name = "metniHizalaToolStripMenuItem";
            this.metniHizalaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.metniHizalaToolStripMenuItem.Text = "Metni Hizala";
            // 
            // sağaHizalaToolStripMenuItem
            // 
            this.sağaHizalaToolStripMenuItem.Name = "sağaHizalaToolStripMenuItem";
            this.sağaHizalaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.sağaHizalaToolStripMenuItem.Text = "Sağa Hizala";
            this.sağaHizalaToolStripMenuItem.Click += new System.EventHandler(this.sağaHizalaToolStripMenuItem_Click);
            // 
            // solaHizalaToolStripMenuItem
            // 
            this.solaHizalaToolStripMenuItem.Name = "solaHizalaToolStripMenuItem";
            this.solaHizalaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.solaHizalaToolStripMenuItem.Text = "Sola Hizala";
            this.solaHizalaToolStripMenuItem.Click += new System.EventHandler(this.solaHizalaToolStripMenuItem_Click);
            // 
            // ortayaHizalaToolStripMenuItem
            // 
            this.ortayaHizalaToolStripMenuItem.Name = "ortayaHizalaToolStripMenuItem";
            this.ortayaHizalaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.ortayaHizalaToolStripMenuItem.Text = "Ortaya Hizala";
            this.ortayaHizalaToolStripMenuItem.Click += new System.EventHandler(this.ortayaHizalaToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.PrintToFile = true;
            this.printDialog1.ShowHelp = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 426);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlToolStripMenuItem1,
            this.kesToolStripMenuItem1,
            this.kopyalaToolStripMenuItem1,
            this.yapıştırToolStripMenuItem1,
            this.silToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 114);
            // 
            // geriAlToolStripMenuItem1
            // 
            this.geriAlToolStripMenuItem1.Name = "geriAlToolStripMenuItem1";
            this.geriAlToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.geriAlToolStripMenuItem1.Text = "Geri Al";
            this.geriAlToolStripMenuItem1.Click += new System.EventHandler(this.geriAlToolStripMenuItem1_Click);
            // 
            // kesToolStripMenuItem1
            // 
            this.kesToolStripMenuItem1.Name = "kesToolStripMenuItem1";
            this.kesToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.kesToolStripMenuItem1.Text = "Kes";
            this.kesToolStripMenuItem1.Click += new System.EventHandler(this.kesToolStripMenuItem1_Click);
            // 
            // kopyalaToolStripMenuItem1
            // 
            this.kopyalaToolStripMenuItem1.Name = "kopyalaToolStripMenuItem1";
            this.kopyalaToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.kopyalaToolStripMenuItem1.Text = "Kopyala";
            this.kopyalaToolStripMenuItem1.Click += new System.EventHandler(this.kopyalaToolStripMenuItem1_Click);
            // 
            // yapıştırToolStripMenuItem1
            // 
            this.yapıştırToolStripMenuItem1.Name = "yapıştırToolStripMenuItem1";
            this.yapıştırToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.yapıştırToolStripMenuItem1.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem1.Click += new System.EventHandler(this.yapıştırToolStripMenuItem1_Click);
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem1.Text = "Sil";
            this.silToolStripMenuItem1.Click += new System.EventHandler(this.silToolStripMenuItem1_Click);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Not Defteri";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biçimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sayfaYapısıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem bulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonrakiniBulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem değiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saatTarihToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sözcükKaydırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem yazıRengiToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem sayfaRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metniHizalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sağaHizalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solaHizalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortayaHizalaToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem görevÇubuğuRengiToolStripMenuItem;
    }
}

