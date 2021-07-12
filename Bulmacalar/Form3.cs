using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulmacalar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox2.Controls.Add(pictureBox1);
            pictureBox1.Location = new Point(100, 10);
            pictureBox1.BackColor = Color.Transparent;

            pictureBox3.Controls.Add(pictureBox8);
            pictureBox8.Location = new Point(100, 10);
            pictureBox8.BackColor = Color.Transparent;

            pictureBox5.Controls.Add(pictureBox10);
            pictureBox10.Location = new Point(100, 10);
            pictureBox10.BackColor = Color.Transparent;

            pictureBox4.Controls.Add(pictureBox9);
            pictureBox9.Location = new Point(100, 10);
            pictureBox9.BackColor = Color.Transparent;

            pictureBox6.Controls.Add(pictureBox11);
            pictureBox11.Location = new Point(100, 10);
            pictureBox11.BackColor = Color.Transparent;

            pictureBox2.Controls.Add(pictureBox21);
            pictureBox21.Location = new Point(0, 75);
            pictureBox21.BackColor = Color.Transparent;

            pictureBox3.Controls.Add(pictureBox22);
            pictureBox22.Location = new Point(0, 75);
            pictureBox22.BackColor = Color.Transparent;

            pictureBox5.Controls.Add(pictureBox23);
            pictureBox23.Location = new Point(0, 75);
            pictureBox23.BackColor = Color.Transparent;

            pictureBox4.Controls.Add(pictureBox24);
            pictureBox24.Location = new Point(0, 75);
            pictureBox24.BackColor = Color.Transparent;

            pictureBox6.Controls.Add(pictureBox25);
            pictureBox25.Location = new Point(0, 75);
            pictureBox25.BackColor = Color.Transparent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Fildişi.png";
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Kırmızı.png";
            }
            else if (comboBox4.SelectedIndex == 2)
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Yeşil.png";
            }
            else if (comboBox4.SelectedIndex == 3)
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Sarı.png";
            }
            else if (comboBox4.SelectedIndex == 4)
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Mavi.png";
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Fildişi.png";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Kırmızı.png";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Yeşil.png";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Sarı.png";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Mavi.png";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
            {
                pictureBox5.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Fildişi.png";
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                pictureBox5.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Kırmızı.png";
            }
            else if (comboBox5.SelectedIndex == 2)
            {
                pictureBox5.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Yeşil.png";
            }
            else if (comboBox5.SelectedIndex == 3)
            {
                pictureBox5.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Sarı.png";
            }
            else if (comboBox5.SelectedIndex == 4)
            {
                pictureBox5.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Mavi.png";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                pictureBox4.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Fildişi.png";
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                pictureBox4.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Kırmızı.png";
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                pictureBox4.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Yeşil.png";
            }
            else if (comboBox3.SelectedIndex == 3)
            {
                pictureBox4.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Sarı.png";
            }
            else if (comboBox3.SelectedIndex == 4)
            {
                pictureBox4.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Mavi.png";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                pictureBox6.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Fildişi.png";
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                pictureBox6.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Kırmızı.png";
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                pictureBox6.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Yeşil.png";
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                pictureBox6.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Sarı.png";
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                pictureBox6.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Renkler\\Mavi.png";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox10.SelectedIndex == 0)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\ingiliz.png";
            }
            else if (comboBox10.SelectedIndex == 1)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\japon.png";
            }
            else if (comboBox10.SelectedIndex == 2)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\ispanyol.png";
            }
            else if (comboBox10.SelectedIndex == 3)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\ukrayna.png";
            }
            else if (comboBox10.SelectedIndex == 4)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\norveç.png";
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox8.SelectedIndex == 0)
            {
                pictureBox8.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\ingiliz.png";
            }
            else if (comboBox8.SelectedIndex == 1)
            {
                pictureBox8.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\japon.png";
            }
            else if (comboBox8.SelectedIndex == 2)
            {
                pictureBox8.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\ispanyol.png";
            }
            else if (comboBox8.SelectedIndex == 3)
            {
                pictureBox8.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\ukrayna.png";
            }
            else if (comboBox8.SelectedIndex == 4)
            {
                pictureBox8.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\norveç.png";
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == 0)
            {
                pictureBox10.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\ingiliz.png";
            }
            else if (comboBox6.SelectedIndex == 1)
            {
                pictureBox10.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\japon.png";
            }
            else if (comboBox6.SelectedIndex == 2)
            {
                pictureBox10.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\ispanyol.png";
            }
            else if (comboBox6.SelectedIndex == 3)
            {
                pictureBox10.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\ukrayna.png";
            }
            else if (comboBox6.SelectedIndex == 4)
            {
                pictureBox10.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\norveç.png";
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox9.SelectedIndex == 0)
            {
                pictureBox9.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\ingiliz.png";
            }
            else if (comboBox9.SelectedIndex == 1)
            {
                pictureBox9.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\japon.png";
            }
            else if (comboBox9.SelectedIndex == 2)
            {
                pictureBox9.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\ispanyol.png";
            }
            else if (comboBox9.SelectedIndex == 3)
            {
                pictureBox9.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\ukrayna.png";
            }
            else if (comboBox9.SelectedIndex == 4)
            {
                pictureBox9.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\norveç.png";
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox7.SelectedIndex == 0)
            {
                pictureBox11.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\ingiliz.png";
            }
            else if (comboBox7.SelectedIndex == 1)
            {
                pictureBox11.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\japon.png";
            }
            else if (comboBox7.SelectedIndex == 2)
            {
                pictureBox11.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\ispanyol.png";
            }
            else if (comboBox7.SelectedIndex == 3)
            {
                pictureBox11.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\ukrayna.png";
            }
            else if (comboBox7.SelectedIndex == 4)
            {
                pictureBox11.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Bayraklar\\norveç.png";
            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox15.SelectedIndex == 0)
            {
                pictureBox7.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\su.png";
            }
            else if (comboBox15.SelectedIndex == 1)
            {
                pictureBox7.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\süt.png";
            }
            else if (comboBox15.SelectedIndex == 2)
            {
                pictureBox7.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\çay.png";
            }
            else if (comboBox15.SelectedIndex == 3)
            {
                pictureBox7.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\kahve.png";
            }
            else if (comboBox15.SelectedIndex == 4)
            {
                pictureBox7.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\portaka_suy.png";
            }
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox13.SelectedIndex == 0)
            {
                pictureBox12.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\su.png";
            }
            else if (comboBox13.SelectedIndex == 1)
            {
                pictureBox12.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\süt.png";
            }
            else if (comboBox13.SelectedIndex == 2)
            {
                pictureBox12.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\çay.png";
            }
            else if (comboBox13.SelectedIndex == 3)
            {
                pictureBox12.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\kahve.png";
            }
            else if (comboBox13.SelectedIndex == 4)
            {
                pictureBox12.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\portaka_suy.png";
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox11.SelectedIndex == 0)
            {
                pictureBox13.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\su.png";
            }
            else if (comboBox11.SelectedIndex == 1)
            {
                pictureBox13.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\süt.png";
            }
            else if (comboBox11.SelectedIndex == 2)
            {
                pictureBox13.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\çay.png";
            }
            else if (comboBox11.SelectedIndex == 3)
            {
                pictureBox13.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\kahve.png";
            }
            else if (comboBox11.SelectedIndex == 4)
            {
                pictureBox13.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\portaka_suy.png";
            }
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox14.SelectedIndex == 0)
            {
                pictureBox15.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\su.png";
            }
            else if (comboBox14.SelectedIndex == 1)
            {
                pictureBox15.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\süt.png";
            }
            else if (comboBox14.SelectedIndex == 2)
            {
                pictureBox15.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\çay.png";
            }
            else if (comboBox14.SelectedIndex == 3)
            {
                pictureBox15.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\kahve.png";
            }
            else if (comboBox14.SelectedIndex == 4)
            {
                pictureBox15.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\portaka_suy.png";
            }
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox12.SelectedIndex == 0)
            {
                pictureBox14.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\su.png";
            }
            else if (comboBox12.SelectedIndex == 1)
            {
                pictureBox14.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\süt.png";
            }
            else if (comboBox12.SelectedIndex == 2)
            {
                pictureBox14.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\çay.png";
            }
            else if (comboBox12.SelectedIndex == 3)
            {
                pictureBox14.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\kahve.png";
            }
            else if (comboBox12.SelectedIndex == 4)
            {
                pictureBox14.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\İçecek\\portaka_suy.png";
            }
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox20.SelectedIndex == 0)
            {
                pictureBox16.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Chesterfield.png";
            }
            else if (comboBox20.SelectedIndex == 1)
            {
                pictureBox16.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Parliament.png";
            }
            else if (comboBox20.SelectedIndex == 2)
            {
                pictureBox16.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Old_Gold.png";
            }
            else if (comboBox20.SelectedIndex == 3)
            {
                pictureBox16.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Kools.png";
            }
            else if (comboBox20.SelectedIndex == 4)
            {
                pictureBox16.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Lucky_Strike.png";
            }
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox18.SelectedIndex == 0)
            {
                pictureBox17.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Chesterfield.png";
            }
            else if (comboBox18.SelectedIndex == 1)
            {
                pictureBox17.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Parliament.png";
            }
            else if (comboBox18.SelectedIndex == 2)
            {
                pictureBox17.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Old_Gold.png";
            }
            else if (comboBox18.SelectedIndex == 3)
            {
                pictureBox17.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Kools.png";
            }
            else if (comboBox18.SelectedIndex == 4)
            {
                pictureBox17.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Lucky_Strike.png";
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox16.SelectedIndex == 0)
            {
                pictureBox18.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Chesterfield.png";
            }
            else if (comboBox16.SelectedIndex == 1)
            {
                pictureBox18.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Parliament.png";
            }
            else if (comboBox16.SelectedIndex == 2)
            {
                pictureBox18.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Old_Gold.png";
            }
            else if (comboBox16.SelectedIndex == 3)
            {
                pictureBox18.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Kools.png";
            }
            else if (comboBox16.SelectedIndex == 4)
            {
                pictureBox18.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Lucky_Strike.png";
            }
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox19.SelectedIndex == 0)
            {
                pictureBox19.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Chesterfield.png";
            }
            else if (comboBox19.SelectedIndex == 1)
            {
                pictureBox19.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Parliament.png";
            }
            else if (comboBox19.SelectedIndex == 2)
            {
                pictureBox19.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Old_Gold.png";
            }
            else if (comboBox19.SelectedIndex == 3)
            {
                pictureBox19.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Kools.png";
            }
            else if (comboBox19.SelectedIndex == 4)
            {
                pictureBox19.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Lucky_Strike.png";
            }
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox17.SelectedIndex == 0)
            {
                pictureBox20.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Chesterfield.png";
            }
            else if (comboBox17.SelectedIndex == 1)
            {
                pictureBox20.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Parliament.png";
            }
            else if (comboBox17.SelectedIndex == 2)
            {
                pictureBox20.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Old_Gold.png";
            }
            else if (comboBox17.SelectedIndex == 3)
            {
                pictureBox20.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Kools.png";
            }
            else if (comboBox17.SelectedIndex == 4)
            {
                pictureBox20.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Sigaralar\\Lucky_Strike.png";
            }
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox25.SelectedIndex == 0)
            {
                pictureBox21.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\köpek.png";
            }
            else if (comboBox25.SelectedIndex == 1)
            {
                pictureBox21.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\at.png";
            }
            else if (comboBox25.SelectedIndex == 2)
            {
                pictureBox21.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\balık.png";
            }
            else if (comboBox25.SelectedIndex == 3)
            {
                pictureBox21.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\tilki.png";
            }
            else if (comboBox25.SelectedIndex == 4)
            {
                pictureBox21.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\salyangoz.png";
            }
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox23.SelectedIndex == 0)
            {
                pictureBox22.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\köpek.png";
            }
            else if (comboBox23.SelectedIndex == 1)
            {
                pictureBox22.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\at.png";
            }
            else if (comboBox23.SelectedIndex == 2)
            {
                pictureBox22.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\balık.png";
            }
            else if (comboBox23.SelectedIndex == 3)
            {
                pictureBox22.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\tilki.png";
            }
            else if (comboBox23.SelectedIndex == 4)
            {
                pictureBox22.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\salyangoz.png";
            }
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox21.SelectedIndex == 0)
            {
                pictureBox23.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\köpek.png";
            }
            else if (comboBox21.SelectedIndex == 1)
            {
                pictureBox23.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\at.png";
            }
            else if (comboBox21.SelectedIndex == 2)
            {
                pictureBox23.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\balık.png";
            }
            else if (comboBox21.SelectedIndex == 3)
            {
                pictureBox23.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\tilki.png";
            }
            else if (comboBox21.SelectedIndex == 4)
            {
                pictureBox23.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\salyangoz.png";
            }
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox24.SelectedIndex == 0)
            {
                pictureBox24.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\köpek.png";
            }
            else if (comboBox24.SelectedIndex == 1)
            {
                pictureBox24.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\at.png";
            }
            else if (comboBox24.SelectedIndex == 2)
            {
                pictureBox24.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\balık.png";
            }
            else if (comboBox24.SelectedIndex == 3)
            {
                pictureBox24.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\tilki.png";
            }
            else if (comboBox24.SelectedIndex == 4)
            {
                pictureBox24.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\salyangoz.png";
            }
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox22.SelectedIndex == 0)
            {
                pictureBox25.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\köpek.png";
            }
            else if (comboBox22.SelectedIndex == 1)
            {
                pictureBox25.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\at.png";
            }
            else if (comboBox22.SelectedIndex == 2)
            {
                pictureBox25.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\balık.png";
            }
            else if (comboBox22.SelectedIndex == 3)
            {
                pictureBox25.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\tilki.png";
            }
            else if (comboBox22.SelectedIndex == 4)
            {
                pictureBox25.ImageLocation = Directory.GetCurrentDirectory() + "\\..\\..\\Hayvanlar\\salyangoz.png";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;

            if (comboBox1.SelectedIndex == 1 && comboBox10.SelectedIndex == 0) // 1. soru başlangıç
            {
                checkBox1.Checked = true;
            }
            else if (comboBox4.SelectedIndex == 1 && comboBox8.SelectedIndex == 0)
            {
                checkBox1.Checked = true;
            }
            else if (comboBox5.SelectedIndex == 1 && comboBox6.SelectedIndex == 0)
            {
                checkBox1.Checked = true;
            }
            else if (comboBox3.SelectedIndex == 1 && comboBox9.SelectedIndex == 0)
            {
                checkBox1.Checked = true;
            }
            else if (comboBox2.SelectedIndex == 1 && comboBox7.SelectedIndex == 0)
            {
                checkBox1.Checked = true;
            }                                                                 // 1. soru tamamlandı

            if (comboBox10.SelectedIndex == 2 && comboBox25.SelectedIndex == 0) // 2. soru başlangıç
            {
                checkBox2.Checked = true;
            }
            else if (comboBox8.SelectedIndex == 2 && comboBox23.SelectedIndex == 0)
            {
                checkBox2.Checked = true;
            }
            else if (comboBox6.SelectedIndex == 2 && comboBox21.SelectedIndex == 0)
            {
                checkBox2.Checked = true;
            }
            else if (comboBox9.SelectedIndex == 2 && comboBox24.SelectedIndex == 0)
            {
                checkBox2.Checked = true;
            }
            else if (comboBox2.SelectedIndex == 2 && comboBox22.SelectedIndex == 0)
            {
                checkBox2.Checked = true;
            }                                                                       // 2. soru tamamlandı

            if (comboBox1.SelectedIndex == 2 && comboBox15.SelectedIndex == 3) // 3. soru başlangıç
            {
                checkBox4.Checked = true;
            }
            else if (comboBox4.SelectedIndex == 2 && comboBox13.SelectedIndex == 3)
            {
                checkBox4.Checked = true;
            }
            else if (comboBox5.SelectedIndex == 2 && comboBox11.SelectedIndex == 3)
            {
                checkBox4.Checked = true;
            }
            else if (comboBox3.SelectedIndex == 2 && comboBox14.SelectedIndex == 3)
            {
                checkBox4.Checked = true;
            }
            else if (comboBox2.SelectedIndex == 2 && comboBox12.SelectedIndex == 3)
            {
                checkBox4.Checked = true;
            }                                                                 // 3. soru tamamlandı

            if (comboBox10.SelectedIndex == 3 && comboBox15.SelectedIndex == 2) // 4. soru başlangıç
            {
                checkBox3.Checked = true;
            }
            else if (comboBox8.SelectedIndex == 3 && comboBox13.SelectedIndex == 2)
            {
                checkBox3.Checked = true;
            }
            else if (comboBox6.SelectedIndex == 3 && comboBox11.SelectedIndex == 2)
            {
                checkBox3.Checked = true;
            }
            else if (comboBox9.SelectedIndex == 3 && comboBox14.SelectedIndex == 2)
            {
                checkBox3.Checked = true;
            }
            else if (comboBox7.SelectedIndex == 3 && comboBox12.SelectedIndex == 2)
            {
                checkBox3.Checked = true;
            }                                                                 // 4. soru tamamlandı

            if (comboBox1.SelectedIndex == 0 && comboBox4.SelectedIndex == 2) // 5. soru başlangıç
            {
                checkBox5.Checked = true;
            }
            else if (comboBox4.SelectedIndex == 0 && comboBox5.SelectedIndex == 2)
            {
                checkBox5.Checked = true;
            }
            else if (comboBox5.SelectedIndex == 0 && comboBox3.SelectedIndex == 2)
            {
                checkBox5.Checked = true;
            }
            else if (comboBox3.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                checkBox5.Checked = true;
            }                                                                    // 5 soru tamamlandı

            if (comboBox20.SelectedIndex == 2 && comboBox25.SelectedIndex == 4) // 6. soru başlangıç
            {
                checkBox6.Checked = true;
            }
            else if (comboBox18.SelectedIndex == 2 && comboBox23.SelectedIndex == 4)
            {
                checkBox6.Checked = true;
            }
            else if (comboBox16.SelectedIndex == 2 && comboBox21.SelectedIndex == 4)
            {
                checkBox6.Checked = true;
            }
            else if (comboBox19.SelectedIndex == 2 && comboBox24.SelectedIndex == 4)
            {
                checkBox6.Checked = true;
            }
            else if (comboBox17.SelectedIndex == 2 && comboBox22.SelectedIndex == 4)
            {
                checkBox6.Checked = true;
            }                                                                       // 6. soru tamamlandı

            if (comboBox1.SelectedIndex == 3 && comboBox20.SelectedIndex == 3)     // 7. soru başlangıç
            {
                checkBox7.Checked = true;
            }
            else if (comboBox4.SelectedIndex == 3 && comboBox18.SelectedIndex == 3)
            {
                checkBox7.Checked = true;
            }
            else if (comboBox5.SelectedIndex == 3 && comboBox16.SelectedIndex == 3)
            {
                checkBox7.Checked = true;
            }
            else if (comboBox3.SelectedIndex == 3 && comboBox19.SelectedIndex == 3)
            {
                checkBox7.Checked = true;
            }
            else if (comboBox2.SelectedIndex == 3 && comboBox17.SelectedIndex == 3)
            {
                checkBox7.Checked = true;
            }                                                                       // 7. soru tamamlandı

            if (comboBox11.SelectedIndex == 1 )                                      // 8. soru başlangıç
            {
                checkBox14.Checked = true;
            }                                                                       // 8. soru tamamlandı

            if (comboBox10.SelectedIndex == 4)                                      // 9. soru başlangıç
            {
                checkBox13.Checked = true;
            }                                                                       // 9.  soru tamamlandı

            if (comboBox25.SelectedIndex == 3 && comboBox18.SelectedIndex == 0)     // 10. soru başlangıç
            {
                checkBox12.Checked = true;
            }
            else if (comboBox23.SelectedIndex == 3 && comboBox20.SelectedIndex == 0 || comboBox23.SelectedIndex == 3 && comboBox16.SelectedIndex == 0)
            {
                checkBox12.Checked = true;
            }
            else if (comboBox21.SelectedIndex == 3 && comboBox18.SelectedIndex == 0 || comboBox21.SelectedIndex == 3 && comboBox19.SelectedIndex == 0)
            {
                checkBox12.Checked = true;
            }
            else if (comboBox24.SelectedIndex == 3 && comboBox16.SelectedIndex == 0 || comboBox24.SelectedIndex == 3 && comboBox17.SelectedIndex == 0)
            {
                checkBox12.Checked = true;
            }
            else if (comboBox22.SelectedIndex == 3 && comboBox19.SelectedIndex == 0)
            {
                checkBox12.Checked = true;
            }                                                                       // 10. soru tamamlandı

            if (comboBox25.SelectedIndex == 1 && comboBox18.SelectedIndex == 3)     // 11. soru başlangıç
            {
                checkBox11.Checked = true;
            }
            else if (comboBox23.SelectedIndex == 1 && comboBox20.SelectedIndex == 3 || comboBox23.SelectedIndex == 1 && comboBox16.SelectedIndex == 3)
            {
                checkBox11.Checked = true;
            }
            else if (comboBox21.SelectedIndex == 1 && comboBox18.SelectedIndex == 3 || comboBox21.SelectedIndex == 1 && comboBox19.SelectedIndex == 3)
            {
                checkBox11.Checked = true;
            }
            else if (comboBox24.SelectedIndex == 1 && comboBox16.SelectedIndex == 3 || comboBox24.SelectedIndex == 1 && comboBox17.SelectedIndex == 3)
            {
                checkBox11.Checked = true;
            }
            else if (comboBox22.SelectedIndex == 1 && comboBox19.SelectedIndex == 3)
            {
                checkBox11.Checked = true;
            }                                                                       // 11. soru tamamlandı

            if (comboBox20.SelectedIndex == 4 && comboBox15.SelectedIndex == 4)    // 12. soru başlangıç
            {
                checkBox10.Checked = true;
            }
            else if (comboBox18.SelectedIndex == 4 && comboBox13.SelectedIndex == 4)
            {
                checkBox10.Checked = true;
            }
            else if (comboBox16.SelectedIndex == 4 && comboBox11.SelectedIndex == 4)
            {
                checkBox10.Checked = true;
            }
            else if (comboBox19.SelectedIndex == 4 && comboBox14.SelectedIndex == 4)
            {
                checkBox10.Checked = true;
            }
            else if (comboBox17.SelectedIndex == 4 && comboBox12.SelectedIndex == 4)
            {
                checkBox10.Checked = true;
            }                                                                       // 12. soru tamamlandı

            if (comboBox20.SelectedIndex == 1 && comboBox10.SelectedIndex == 1)    // 13. soru başlangıç
            {
                checkBox9.Checked = true;
            }
            else if (comboBox18.SelectedIndex == 1 && comboBox8.SelectedIndex == 1)
            {
                checkBox9.Checked = true;
            }
            else if (comboBox16.SelectedIndex == 1 && comboBox6.SelectedIndex == 1)
            {
                checkBox9.Checked = true;
            }
            else if (comboBox19.SelectedIndex == 1 && comboBox9.SelectedIndex == 1)
            {
                checkBox9.Checked = true;
            }
            else if (comboBox17.SelectedIndex == 1 && comboBox7.SelectedIndex == 1)
            {
                checkBox9.Checked = true;
            }                                                                       // 13. soru tamamlandı

            if (comboBox10.SelectedIndex == 4 && comboBox4.SelectedIndex == 4)     // 14. soru başlangıç
            {
                checkBox8.Checked = true;
            }
            else if (comboBox8.SelectedIndex == 4 && comboBox1.SelectedIndex == 4 || comboBox8.SelectedIndex == 4 && comboBox5.SelectedIndex == 4)
            {
                checkBox8.Checked = true;
            }
            else if (comboBox6.SelectedIndex == 4 && comboBox4.SelectedIndex == 4 || comboBox6.SelectedIndex == 4 && comboBox3.SelectedIndex == 4)
            {
                checkBox8.Checked = true;
            }
            else if (comboBox9.SelectedIndex == 4 && comboBox5.SelectedIndex == 4 || comboBox9.SelectedIndex == 4 && comboBox2.SelectedIndex == 4)
            {
                checkBox8.Checked = true;
            }
            else if (comboBox7.SelectedIndex == 4 && comboBox3.SelectedIndex == 4)
            {
                checkBox8.Checked = true;
            }                                                                                   // 14. soru tamamlandı

            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true && checkBox6.Checked == true && checkBox7.Checked == true && checkBox8.Checked == true && checkBox9.Checked == true && checkBox10.Checked == true && checkBox11.Checked == true && checkBox12.Checked == true && checkBox13.Checked == true && checkBox14.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Sonucu kaydetmek ister misin?", "Tebirkler!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-C17ULPC\\SQLEXPRESS;Initial Catalog=Kullanici;Integrated Security=True");



                    this.Close();
                
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void sıfırlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void uygulamayıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Show();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
