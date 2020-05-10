using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Not_Defteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string openedfile = "";
        public void save() // Dosya Kaydetme
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.GetEncoding("ISO-8859-9"));
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();
                    this.Text = "Not Defteri - " + Path.GetFileName(saveFileDialog1.FileName);
                    openedfile = saveFileDialog1.FileName;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Dosya kaydedilemedi. Hata:" + error.Message, "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e) // Yeni
        {
            if (richTextBox1.Text.Length > 0)
            {
                DialogResult warning = MessageBox.Show("Bu notu kaydetmediniz. Yeni bir not açmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (warning == DialogResult.Yes)
                {
                    this.Text = "Not Defteri - Yeni Not";
                    richTextBox1.Text = "";
                }
            }
            else
            {
                this.Text = "Not Defteri - Yeni Not";
                richTextBox1.Text = "";
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e) // Aç
        {
            openFileDialog1.ShowDialog();
            if (File.Exists(openFileDialog1.FileName))
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                this.Text = "Not Defteri - " + Path.GetFileName(openFileDialog1.FileName);
                openedfile = openFileDialog1.FileName;
                sr.Close();
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e) // Kaydet
        {
            save();
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e) // Farklı Kaydet
        {
            save();
        }

        private void sayfaYapısıToolStripMenuItem_Click(object sender, EventArgs e) // Sayfa Yapısı
        {
            pageSetupDialog1.ShowDialog();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e) // Yazdır
        {
            printDialog1.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e) // Çıkış
        {
            Close();
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e) // Geri Al
        {
            richTextBox1.Undo();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e) // Kes
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e) // Kopyala
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e) // Yapıştır
        {
            richTextBox1.Paste();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e) // Sil
        {
            richTextBox1.Clear();
        }

        private void bulToolStripMenuItem_Click(object sender, EventArgs e) // Bul
        {
        }

        private void sonrakiniBulToolStripMenuItem_Click(object sender, EventArgs e) // Sonrakini Bul
        {
        }

        private void değiştirToolStripMenuItem_Click(object sender, EventArgs e) // Değiştir
        {
        }

        private void gitToolStripMenuItem_Click(object sender, EventArgs e) // Git
        {
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e) // Tümünü Seç
        {
            richTextBox1.SelectAll();
        }

        private void saatTarihToolStripMenuItem_Click(object sender, EventArgs e) // Saat/Tarih
        {
            richTextBox1.Text = string.Format("{0}", DateTime.Now);
        }

        private void sözcükKaydırToolStripMenuItem_Click(object sender, EventArgs e) // Sözcük Kaydır
        {
            if (richTextBox1.WordWrap == true)
            {
                richTextBox1.WordWrap = false;
                sözcükKaydırToolStripMenuItem.Checked = true;
            }
            else
            {
                richTextBox1.WordWrap = true;
                sözcükKaydırToolStripMenuItem.Checked = false;
            }
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e) // Yazı Tipi
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e) // Yazı Rengi
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void sayfaRengiToolStripMenuItem_Click(object sender, EventArgs e) // Sayfa Rengi
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void görevÇubuğuRengiToolStripMenuItem_Click(object sender, EventArgs e) // Görev Çubuğu Rengi
        {
            colorDialog1.ShowDialog();
            menuStrip1.BackColor = colorDialog1.Color;
        }

        private void sağaHizalaToolStripMenuItem_Click(object sender, EventArgs e) // Sağa Hizala
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox1.DeselectAll();
            sağaHizalaToolStripMenuItem.Checked = true;
            solaHizalaToolStripMenuItem.Checked = false;
            ortayaHizalaToolStripMenuItem.Checked = false;
        }

        private void solaHizalaToolStripMenuItem_Click(object sender, EventArgs e) // Sola Hizala
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox1.DeselectAll();
            sağaHizalaToolStripMenuItem.Checked = false;
            solaHizalaToolStripMenuItem.Checked = true;
            ortayaHizalaToolStripMenuItem.Checked = false;
        }

        private void ortayaHizalaToolStripMenuItem_Click(object sender, EventArgs e) // Ortaya Hizala
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();
            sağaHizalaToolStripMenuItem.Checked = false;
            solaHizalaToolStripMenuItem.Checked = false;
            ortayaHizalaToolStripMenuItem.Checked = true;
        }

        private void geriAlToolStripMenuItem1_Click(object sender, EventArgs e) // Sağ Tık Geri Al
        {
            richTextBox1.Undo();
        }

        private void kesToolStripMenuItem1_Click(object sender, EventArgs e) // Sağ Tık Kes
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e) // Sağ Tık Kopyala
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem1_Click(object sender, EventArgs e) // Sağ Tık Yapıştır
        {
            richTextBox1.Paste();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e) // Sağ Tık Sil
        {
            richTextBox1.Clear();
        }
    }
}