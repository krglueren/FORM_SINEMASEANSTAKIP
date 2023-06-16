using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SİNEMASEANSTAKİP
{
    public partial class HzlVKoltukSecimi : Form
    {
        public HzlVKoltukSecimi()
        {
            InitializeComponent();
        }

        public string a, b;

        private void button11_Click(object sender, EventArgs e)
        {
            var context = new MOVIETICKETSEntities1();

            //Burada yeni öğrenci ekledik. değişkenlerin karşılığı olarak textbox değerlerini girdik. 
            var yeni = new musteriler()
            {
                Ad = textBox4.Text,
                Soyad = textBox5.Text,
                Film= textBox6.Text,
                Tarih = DateTime.Parse(textBox1.Text),
                Saat = textBox2.Text,
                Koltuk = textBox3.Text
            };
            context.musteriler.Add(yeni);
            context.SaveChanges();

            MessageBox.Show("İŞLEM TAMAMLANDI...");

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Red)
            {
                string message = "DOLU KOLTUK!";
                MessageBox.Show(message);
            }
            else
            {
                textBox3.Text = string.Empty;

                textBox3.Text = button1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Red)
            {
                string message = "DOLU KOLTUK!";
                MessageBox.Show(message);
            }
            else
            {
                textBox3.Text = string.Empty;

                textBox3.Text = button2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Red)
            {
                string message = "DOLU KOLTUK!";
                MessageBox.Show(message);
            }
            else
            {
                textBox3.Text = string.Empty;

                textBox3.Text = button3.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(button4.BackColor==Color.Red)
            {
                string message = "DOLU KOLTUK!";
                MessageBox.Show(message);
            }
            else
            {
                textBox3.Text = string.Empty;

                textBox3.Text = button4.Text;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.Red)
            {
                string message = "DOLU KOLTUK!";
                MessageBox.Show(message);
            }
            else
            {
                textBox3.Text = string.Empty;

                textBox3.Text = button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.Red)
            {
                string message = "DOLU KOLTUK!";
                MessageBox.Show(message);
            }
            else
            {
                textBox3.Text = string.Empty;

                textBox3.Text = button6.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.Red)
            {
                string message = "DOLU KOLTUK!";
                MessageBox.Show(message);
            }
            else
            {
                textBox3.Text = string.Empty;

                textBox3.Text = button7.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.Red)
            {
                string message = "DOLU KOLTUK!";
                MessageBox.Show(message);
            }
            else
            {
                textBox3.Text = string.Empty;

                textBox3.Text = button8.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.Red)
            {
                string message = "DOLU KOLTUK!";
                MessageBox.Show(message);
            }
            else
            {
                textBox3.Text = string.Empty;

                textBox3.Text = button9.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.Red)
            {
                string message = "DOLU KOLTUK!";
                MessageBox.Show(message);
            }
            else
            {
                textBox3.Text = string.Empty;

                textBox3.Text = button10.Text;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font font = new Font("Arial", 14);
                SolidBrush firca = new SolidBrush(Color.Black);

                e.Graphics.DrawString($"Tarih={DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}", font, firca, 50, 25);


                font = new Font("Arial", 20, FontStyle.Bold);
                e.Graphics.DrawString("Sinema Bilet Fişi", font, firca, 270, 75);
                e.Graphics.DrawString("*************************", font, firca, 240, 115);

                font = new Font("Arial", 15, FontStyle.Bold);
                e.Graphics.DrawString("Ad : ", font, firca, 60, 150);
                e.Graphics.DrawString("Soyad : ", font, firca, 60, 200);
                e.Graphics.DrawString("Film : ", font, firca, 60, 250);
                e.Graphics.DrawString("Tarih : ", font, firca, 60, 300);
                e.Graphics.DrawString("Saat : ", font, firca, 60, 350);
                e.Graphics.DrawString("Koltuk : ", font, firca, 60, 400);

                font = new Font("Arial", 15, FontStyle.Bold);
                e.Graphics.DrawString(textBox4.Text, font, firca, 200, 150);
                e.Graphics.DrawString(textBox5.Text, font, firca, 200, 200);
                e.Graphics.DrawString(textBox6.Text, font, firca, 200, 250);
                e.Graphics.DrawString(textBox1.Text, font, firca, 200, 300);
                e.Graphics.DrawString(textBox2.Text, font, firca, 200, 350);
                e.Graphics.DrawString(textBox3.Text, font, firca, 200, 400);

                font = new Font("Arial", 20, FontStyle.Bold);
                e.Graphics.DrawString("BİLETİNİZ OLUŞTURULMUŞTUR", font, firca, 180, 500);
                e.Graphics.DrawString("------------------------------", font, firca, 240, 550);
                e.Graphics.DrawString("KEYİFLİ SEYİRLER", font, firca, 270, 600);


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }

        Bitmap bmp;

        private void button14_Click(object sender, EventArgs e)
        {
            Graphics g=this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height,g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog2.ShowDialog();
        }

        private void HzlVKoltukSecimi_Load(object sender, EventArgs e)
        {
            textBox1.Text = a;
            textBox2.Text = b;
            textBox6.Text = "HIZLI VE ÖFKELİ";

            var context = new MOVIETICKETSEntities1();
            var mstr = context.musteriler.ToList();

            var bindingList = new BindingList<musteriler>(mstr);
            bindingSource1 = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource1;

            var koltuklar = context.musteriler.Where(k => k.Koltuk == "A4" && k.Film == "HIZLI VE ÖFKELİ").ToList(); // Koltuk numarası 5 olan satırları seçiniz

            foreach (Control control in Controls)
            {
                if (control is Button button) // Eğer kontrol bir butonsa
                {
                    if (button4.Text == "A4") // Butonun text'i 5'e eşitse
                    {
                        foreach (var koltuk in koltuklar)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["Koltuk"].Value.ToString() == koltuk.Koltuk.ToString()) // Koltuk numarası koltuklar listesindeki bir koltuk numarasına eşitse
                                {
                                    button4.BackColor = Color.Red; // Butonun arka plan rengini kırmızıya boyayınız
                                    break;
                                }
                            }

                            break;
                        }
                    }
                }
            }


            var koltukl = context.musteriler.Where(k => k.Koltuk == "A1" && k.Film == "HIZLI VE ÖFKELİ").ToList(); // Koltuk numarası 5 olan satırları seçiniz

            foreach (Control control in Controls)
            {
                if (control is Button button) // Eğer kontrol bir butonsa
                {
                    if (button1.Text == "A1") // Butonun text'i 5'e eşitse
                    {
                        foreach (var koltuk in koltukl)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["Koltuk"].Value.ToString() == koltuk.Koltuk.ToString()) // Koltuk numarası koltuklar listesindeki bir koltuk numarasına eşitse
                                {
                                    button1.BackColor = Color.Red; // Butonun arka plan rengini kırmızıya boyayınız
                                    break;
                                }
                            }

                            break;
                        }
                    }
                }
            }
            var koltu = context.musteriler.Where(k => k.Koltuk == "A2" && k.Film == "HIZLI VE ÖFKELİ").ToList(); // Koltuk numarası 5 olan satırları seçiniz

            foreach (Control control in Controls)
            {
                if (control is Button button) // Eğer kontrol bir butonsa
                {
                    if (button2.Text == "A2") // Butonun text'i 5'e eşitse
                    {
                        foreach (var koltuk in koltu)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["Koltuk"].Value.ToString() == koltuk.Koltuk.ToString()) // Koltuk numarası koltuklar listesindeki bir koltuk numarasına eşitse
                                {
                                    button2.BackColor = Color.Red; // Butonun arka plan rengini kırmızıya boyayınız
                                    break;
                                }
                            }

                            break;
                        }
                    }
                }
            }

            var kolt = context.musteriler.Where(k => k.Koltuk == "A3" && k.Film == "HIZLI VE ÖFKELİ").ToList(); // Koltuk numarası 5 olan satırları seçiniz

            foreach (Control control in Controls)
            {
                if (control is Button button) // Eğer kontrol bir butonsa
                {
                    if (button3.Text == "A3") // Butonun text'i 5'e eşitse
                    {
                        foreach (var koltuk in kolt)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["Koltuk"].Value.ToString() == koltuk.Koltuk.ToString()) // Koltuk numarası koltuklar listesindeki bir koltuk numarasına eşitse
                                {
                                    button3.BackColor = Color.Red; // Butonun arka plan rengini kırmızıya boyayınız
                                    break;
                                }
                            }

                            break;
                        }
                    }
                }
            }

            var kol = context.musteriler.Where(k => k.Koltuk == "A5" && k.Film == "HIZLI VE ÖFKELİ").ToList(); // Koltuk numarası 5 olan satırları seçiniz

            foreach (Control control in Controls)
            {
                if (control is Button button) // Eğer kontrol bir butonsa
                { 
                    if (button5.Text == "A5") // Butonun text'i 5'e eşitse
                    {
                        foreach (var koltuk in kol)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["Koltuk"].Value.ToString() == koltuk.Koltuk.ToString()) // Koltuk numarası koltuklar listesindeki bir koltuk numarasına eşitse
                                {
                                    button5.BackColor = Color.Red; // Butonun arka plan rengini kırmızıya boyayınız
                                    break;
                                }
                            }

                            break;
                        }
                    }
                }
            }

            var kltt = context.musteriler.Where(k => k.Koltuk == "B1" && k.Film == "HIZLI VE ÖFKELİ").ToList(); // Koltuk numarası 5 olan satırları seçiniz

            foreach (Control control in Controls)
            {
                if (control is Button button) // Eğer kontrol bir butonsa
                {
                    if (button6.Text == "B1") // Butonun text'i 5'e eşitse
                    {
                        foreach (var koltuk in kltt)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["Koltuk"].Value.ToString() == koltuk.Koltuk.ToString()) // Koltuk numarası koltuklar listesindeki bir koltuk numarasına eşitse
                                {
                                    button6.BackColor = Color.Red; // Butonun arka plan rengini kırmızıya boyayınız
                                    break;
                                }
                            }

                            break;
                        }
                    }
                }
            }

            var klt = context.musteriler.Where(k => k.Koltuk == "B2" && k.Film == "HIZLI VE ÖFKELİ").ToList(); // Koltuk numarası 5 olan satırları seçiniz

            foreach (Control control in Controls)
            {
                if (control is Button button) // Eğer kontrol bir butonsa
                {
                    if (button7.Text == "B2") // Butonun text'i 5'e eşitse
                    {
                        foreach (var koltuk in klt)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["Koltuk"].Value.ToString() == koltuk.Koltuk.ToString()) // Koltuk numarası koltuklar listesindeki bir koltuk numarasına eşitse
                                {
                                    button7.BackColor = Color.Red; // Butonun arka plan rengini kırmızıya boyayınız
                                    break;
                                }
                            }

                            break;
                        }
                    }
                }
            }

            var kltklr = context.musteriler.Where(k => k.Koltuk == "B3" && k.Film == "HIZLI VE ÖFKELİ").ToList(); // Koltuk numarası 5 olan satırları seçiniz

            foreach (Control control in Controls)
            {
                if (control is Button button) // Eğer kontrol bir butonsa
                {
                    if (button8.Text == "B3") // Butonun text'i 5'e eşitse
                    {
                        foreach (var koltuk in kltklr)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["Koltuk"].Value.ToString() == koltuk.Koltuk.ToString()) // Koltuk numarası koltuklar listesindeki bir koltuk numarasına eşitse
                                {
                                    button8.BackColor = Color.Red; // Butonun arka plan rengini kırmızıya boyayınız
                                    break;
                                }
                            }

                            break;
                        }
                    }
                }
            }

            var kltklrr = context.musteriler.Where(k => k.Koltuk == "B4" && k.Film == "HIZLI VE ÖFKELİ").ToList(); // Koltuk numarası 5 olan satırları seçiniz

            foreach (Control control in Controls)
            {
                if (control is Button button) // Eğer kontrol bir butonsa
                {
                    if (button9.Text == "B4") // Butonun text'i 5'e eşitse
                    {
                        foreach (var koltuk in kltklrr)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["Koltuk"].Value.ToString() == koltuk.Koltuk.ToString()) // Koltuk numarası koltuklar listesindeki bir koltuk numarasına eşitse
                                {
                                    button9.BackColor = Color.Red; // Butonun arka plan rengini kırmızıya boyayınız
                                    break;
                                }
                            }

                            break;
                        }
                    }
                }
            }

            var kltklrrr = context.musteriler.Where(k => k.Koltuk == "B5" && k.Film == "HIZLI VE ÖFKELİ").ToList(); // Koltuk numarası 5 olan satırları seçiniz

            foreach (Control control in Controls)
            {
                if (control is Button button) // Eğer kontrol bir butonsa
                {
                    if (button10.Text == "B5") // Butonun text'i 5'e eşitse
                    {
                        foreach (var koltuk in kltklrrr)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["Koltuk"].Value.ToString() == koltuk.Koltuk.ToString()) // Koltuk numarası koltuklar listesindeki bir koltuk numarasına eşitse
                                {
                                    button10.BackColor = Color.Red; // Butonun arka plan rengini kırmızıya boyayınız
                                    break;
                                }
                            }

                            break;
                        }
                    }
                }
            }
        }
    }
}
