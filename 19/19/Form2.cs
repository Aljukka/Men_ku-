using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19
{
    public partial class Form2 : Form
    {
        int AktuellesBewerten;
        string[] Beschriftung = {@"C:\Users\Пользователь\Desktop\Учёба\ОАИП\19\Seig.png", @"C:\Users\Пользователь\Desktop\Учёба\ОАИП\19\Verlieren.png", @"C:\Users\Пользователь\Desktop\Учёба\ОАИП\19\NuzhnoBolsheZolota.png"};
        string[] Zahlen = {@"C:\Users\Пользователь\Desktop\Учёба\ОАИП\19\Eins.png", @"C:\Users\Пользователь\Desktop\Учёба\ОАИП\19\Zwei.png", @"C:\Users\Пользователь\Desktop\Учёба\ОАИП\19\Drei.png", @"C:\Users\Пользователь\Desktop\Учёба\ОАИП\19\Vier.png", @"C:\Users\Пользователь\Desktop\Учёба\ОАИП\19\Funf.png", @"C:\Users\Пользователь\Desktop\Учёба\ОАИП\19\Sechs.png", @"C:\Users\Пользователь\Desktop\Учёба\ОАИП\19\Sieben.png", @"C:\Users\Пользователь\Desktop\Учёба\ОАИП\19\Acht.png", @"C:\Users\Пользователь\Desktop\Учёба\ОАИП\19\Neun.png"};
        public Form2(string imja, string geld)
        {
            InitializeComponent();
            Imja2.Text = imja;
            Geld2.Text = geld;
        }
        private void Imja2_Click(object sender, EventArgs e)
        {
            //Tut nichego net
        }
        private void Drehen_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            pictureBox1.Image = null;
            AktuellesBewerten = Convert.ToInt32(BewertenTextBox.Text);
            int AktuellesGeld = Convert.ToInt32(Geld2.Text);
            if (AktuellesBewerten > 0)
            {
                if (AktuellesBewerten <= AktuellesGeld)
                {
                    AktuellesGeld -= AktuellesBewerten;
                    Geld2.Text = AktuellesGeld.ToString();
                    var r = new Random();                                   
                    int a = r.Next(0, 9);
                    Zahl1.ImageLocation = Zahlen[a];
                    int b = r.Next(0, 9);
                    Zahl2.ImageLocation = Zahlen[b];
                    int c = r.Next(0, 9);
                    Zahl3.ImageLocation = Zahlen[c];
                    Uberprufen(a, b, c);
                }
                else
                {
                    pictureBox1.ImageLocation=Beschriftung[2];
                }
            }
            else 
            {
                label4.Text = "Ты что творишь, читер?";
            }
        }
        public void Uberprufen(int a, int b, int c)
        {
            int AktuellesGeld= Convert.ToInt32(Geld2.Text);
            if (a==b&&b==c&&a==c)
            {
                pictureBox1.ImageLocation = Beschriftung[0];
                Geld2.Text = (AktuellesGeld + 2 * AktuellesBewerten).ToString();
            }
            else
            {
                pictureBox1.ImageLocation = Beschriftung[1];
            }
        }
    }
}