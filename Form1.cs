using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satranc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yerlestir();
        }
        private void Yerlestir()
        {
            Button[,] buttons = new Button[9, 9];
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 60;
                    buttons[i, j].Height = 60;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 60;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.DarkGray;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);

                    Point koordinat = new Point();
                    koordinat.X = i;
                    koordinat.Y = j;
                    buttons[i, j].Tag = (Object)koordinat;
                    if (i == 7 && j == 6)
                    {
                        buttons[i, j].Click += AtHareketGoster_Click;
                    }
                    else if (i == 7 && j == 1)
                    {
                        buttons[i, j].Click += AtHareketGoster_Click;
                    }
                    else if (i == 0 && j == 1)
                    {
                        buttons[i, j].Click += AtHareketGoster_Click;
                    }
                    else if (i == 0 && j == 6)
                    {
                        buttons[i, j].Click += AtHareketGoster_Click;
                    }

                }
                top += 50;
                left = 0;


            }

            // Piyonlar:
            for (int j = 0; j < 8; j++)
            {
                buttons[1, j].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Adem\Desktop\strnç\Satranc\Satranc\ımage\Piyon_Siyah.png");
            }
            for (int j = 0; j < 8; j++)
            {
                buttons[6, j].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Adem\Desktop\strnç\Satranc\Satranc\ımage\Piyon_Beyaz.png");
            }

            // Atlar:
            buttons[0, 1].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Adem\Desktop\strnç\Satranc\Satranc\ımage\At_Siyah.png");
            buttons[0, 6].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Adem\Desktop\strnç\Satranc\Satranc\ımage\At_Siyah.png");
            buttons[7, 1].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Adem\Desktop\strnç\Satranc\Satranc\ımage\At_Beyaz.png");
            buttons[7, 6].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Adem\Desktop\strnç\Satranc\Satranc\ımage\At_Beyaz.png");
            // kale
            buttons[0, 0].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Adem\Desktop\strnç\Satranc\Satranc\ımage\Kale_Siyah.png");
            buttons[0, 7].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Adem\Desktop\strnç\Satranc\Satranc\ımage\Kale_Siyah.png");
            buttons[7, 0].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Adem\Desktop\strnç\Satranc\Satranc\ımage\Kale_Beyaz.png");
            buttons[7, 7].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Adem\Desktop\strnç\Satranc\Satranc\ımage\Kale_Beyaz.png");
            // Filler:
            buttons[0, 2].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Adem\Desktop\strnç\Satranc\Satranc\ımage\Fil_Siyah.png");
            buttons[0, 5].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Adem\Desktop\strnç\Satranc\Satranc\ımage\Fil_Siyah.png");
            buttons[7, 2].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Adem\Desktop\strnç\Satranc\Satranc\ımage\Fil_Beyaz.png");
            buttons[7, 5].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Adem\Desktop\strnç\Satranc\Satranc\ımage\Fil_Beyaz.png");
            // Vezir ve Şah:
            buttons[0, 3].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Adem\Desktop\strnç\Satranc\Satranc\ımage\Vezir_Siyah.png");
            buttons[0, 4].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Adem\Desktop\strnç\Satranc\Satranc\ımage\Sah_Siyah.png");
            buttons[7, 3].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Adem\Desktop\strnç\Satranc\Satranc\ımage\Vezir_Beyaz.png");
            buttons[7, 4].BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Adem\Desktop\strnç\Satranc\Satranc\ımage\Sah_Beyaz.png");

            void Bsag()
            {
                buttons[7, 6].BackColor = Color.Green; //merkez
                buttons[6, 6].BackColor = Color.Green; // bir tık üstü
                buttons[5, 6].BackColor = Color.Green; // bir tık üstü
                buttons[5, 5].BackColor = Color.Green; // bir tık üstü


            }
            void Bsol()
            {
                buttons[7, 1].BackColor = Color.Green; //merkez
                buttons[6, 1].BackColor = Color.Green; // bir tık üstü
                buttons[5, 1].BackColor = Color.Green; // bir tık üstü
                buttons[5, 0].BackColor = Color.Green; // bir tık üstü


            }
            void Siyahsol()
            {
                buttons[0, 6].BackColor = Color.Green; //merkez
                buttons[1, 6].BackColor = Color.Green; // bir tık üstü
                buttons[2, 6].BackColor = Color.Green; // bir tık üstü
                buttons[2, 5].BackColor = Color.Green; // bir tık üstü


            }
            void Siyahsag()
            {
                buttons[0, 1].BackColor = Color.Green; //merkez
                buttons[1, 1].BackColor = Color.Green; // bir tık üstü
                buttons[2, 1].BackColor = Color.Green; // bir tık üstü
                buttons[2, 0].BackColor = Color.Green; // bir tık üstü


            }


            void AtHareketGoster_Click(object sender, EventArgs e)
            {
                Point kare = (Point)((Button)sender).Tag;


                if (kare.X == 7 && kare.Y == 6)
                {
                    Bsag();
                }
                else if (kare.X == 7 && kare.Y == 1)
                {
                    Bsol();
                }
                else if (kare.X == 0 && kare.Y == 6)
                {
                    Siyahsol();
                }
                else if (kare.X == 0 && kare.Y == 1)
                {
                    Siyahsag();
                }



            }


        }


    }

}


