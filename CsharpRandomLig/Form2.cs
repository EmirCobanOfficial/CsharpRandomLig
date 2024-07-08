using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpRandomLig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int gspuan = 0;
        int fbpuan = 0;
        int trbpuan = 0;
        int bjkpuan = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label4.Text = a.ToString();
            label5.Text = b.ToString();
            label6.Text = c.ToString();
            label7.Text = d.ToString();

            if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label5.Text))
            {
                gspuan = gspuan + 3;
                gslabel.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label5.Text) > Convert.ToInt32(label4.Text))
            {
                fbpuan = fbpuan + 3;
                fblabel.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label4.Text) == Convert.ToInt32(label5.Text))
            {
                gspuan = gspuan + 1;
                gslabel.Text = gspuan.ToString();

                fbpuan = fbpuan + 1;
                fblabel.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label7.Text))
            {
                bjkpuan = bjkpuan + 3;
                bjklabel.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label6.Text))
            {
                trbpuan = trbpuan + 3;
                tblabel.Text = trbpuan.ToString();
            }
            if (Convert.ToInt32(label6.Text) == Convert.ToInt32(label7.Text))
            {
                trbpuan = trbpuan + 1;
                bjkpuan = bjkpuan + 1;

                bjklabel.Text = bjkpuan.ToString();
                tblabel.Text = trbpuan.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            gs1.Text = a.ToString();
            fb1.Text = b.ToString();
            bjk1.Text = c.ToString();
            trb1.Text = d.ToString();

            if (Convert.ToInt32(gs1.Text) > Convert.ToInt32(fb1.Text))
            {
                gspuan = gspuan + 3;
                gslabel.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(fb1.Text) > Convert.ToInt32(gs1.Text))
            {
                fbpuan = fbpuan + 3;
                fblabel.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(fb1.Text) == Convert.ToInt32(gs1.Text))
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;

                fblabel.Text = fbpuan.ToString();
                gslabel.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(bjk1.Text) > Convert.ToInt32(trb1.Text))
            {
                bjkpuan = bjkpuan + 3;
                bjklabel.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(trb1.Text) > Convert.ToInt32(bjk1.Text))
            {
                trbpuan = trbpuan + 3;
                tblabel.Text = trbpuan.ToString();
            }
            if (Convert.ToInt32(bjk1.Text) == Convert.ToInt32(trb1.Text))
            {
                trbpuan = trbpuan + 1;
                bjkpuan = bjkpuan + 1;

                bjklabel.Text = bjkpuan.ToString();
                tblabel.Text = trbpuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Visible = true;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            gs2.Text = a.ToString();
            fb2.Text = b.ToString();
            bjk2.Text = c.ToString();
            trb2.Text = d.ToString();

            if (Convert.ToInt32(fb2.Text) > Convert.ToInt32(bjk2.Text))
            {
                fbpuan = fbpuan + 3;
                fblabel.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(bjk2.Text) > Convert.ToInt32(fb2.Text))
            {
                bjkpuan = bjkpuan + 3;
                bjklabel.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(bjk2.Text) == Convert.ToInt32(fb2.Text))
            {
                bjkpuan = bjkpuan + 1;
                fbpuan = fbpuan + 1;

                bjklabel.Text = bjkpuan.ToString();
                fblabel.Text = bjkpuan.ToString();
            }

            if (Convert.ToInt32(trb2.Text) > Convert.ToInt32(gs2.Text))
            {
                trbpuan = trbpuan + 3;
                tblabel.Text = trbpuan.ToString();
            }
            if (Convert.ToInt32(gs2.Text) > Convert.ToInt32(trb2.Text))
            {
                gspuan = gspuan + 3;
                gslabel.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(trb2.Text) == Convert.ToInt32(gs2.Text))
            {
                trbpuan = trbpuan + 1;
                gspuan = gspuan + 1;

                tblabel.Text = trbpuan.ToString();
                gslabel.Text = gspuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32 (fblabel.Text) > Convert.ToInt32 (gslabel.Text) && Convert.ToInt32 (fblabel.Text) > Convert.ToInt32 (bjklabel.Text) && Convert.ToInt32 (fblabel.Text) > Convert.ToInt32 (tblabel.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotoları\\fb.mp3";
                label1.Text = "fenerbahce kazandı";
                pictureBox1.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotoları\\Fenerbahçe.png";
            }
            if (Convert.ToInt32(gslabel.Text) > Convert.ToInt32(fblabel.Text) && Convert.ToInt32(gslabel.Text) > Convert.ToInt32(bjklabel.Text) && Convert.ToInt32(gslabel.Text) > Convert.ToInt32(tblabel.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotoları\\gs.mp3";
                label1.Text = "Galatasaray kazandı";
                pictureBox1.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotoları\\Galatasaray.png";
            }
            if (Convert.ToInt32(tblabel.Text) > Convert.ToInt32(fblabel.Text) && Convert.ToInt32(tblabel.Text) > Convert.ToInt32(gslabel.Text) && Convert.ToInt32(tblabel.Text) > Convert.ToInt32(bjklabel.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotoları\\trb.mp3";
                label1.Text = "TrabzonSpor kazandı";
                pictureBox1.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotoları\\Trabzonspor.png";
            }
            if (Convert.ToInt32(bjklabel.Text) > Convert.ToInt32(fblabel.Text) && Convert.ToInt32(bjklabel.Text) > Convert.ToInt32(gslabel.Text) && Convert.ToInt32(bjklabel.Text) > Convert.ToInt32(tblabel.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotoları\\bjk.mp3";
                label1.Text = "Beşiktaş kazandı";
                pictureBox1.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotoları\\Beşiktaş.png";
            }
        }
    }
}
