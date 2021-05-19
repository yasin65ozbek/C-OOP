using System;
using System.Drawing;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();
        }

        private void GenerateButtons()//CTRL + R, CTRL + M ile metot yapıp çağırıyoruz
        {
            Button[,] buttons = new Button[8, 8]; 
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)//0. boyutun en büyük alacağı değer
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)//il satırda 8 buton oluşturulacak
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    if ((i + j) % 2 == 0)//2ye böleni sıfır ise
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;
                left = 0; //satır bittikten sonra lefti sıfırlıyıp soldan sağa devam etmesini sağlıyoruz
            }
        }
    }
}
