using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17
{
    public partial class Form1 : Form
    {      
        Zahlen z;
        public Form1()
        {
            InitializeComponent();
            z = new Zahlen();
            label1.Text = "0";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }       
        private void RichtigeZahlen()
        {
            if (label1.Text.IndexOf("∞") != -1)
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
            if (label1.Text[0] == '0' && (label1.Text.IndexOf(",") != 1))
            {
                label1.Text = label1.Text.Remove(0, 1);
            }
            if (label1.Text[0] == '-')
            {
                if (label1.Text[1] == '0' && (label1.Text.IndexOf(",") != 2))
                {
                    label1.Text = label1.Text.Remove(1, 1);
                }
            }
        }
        private bool Achtung()
        {
            if (!Multiplizieren.Enabled)
                return false;
            if (!Trennung.Enabled)
                return false;
            if (!Summe.Enabled)
                return false;
            if (!Subtraktion.Enabled)
                return false;
            if (!Grad.Enabled)
                return false;
            if (!Rest.Enabled)
                return false;
            return true;
        }
        private void Freiheit()
        {
            Multiplizieren.Enabled = true;
            Trennung.Enabled = true;
            Summe.Enabled = true;
            Subtraktion.Enabled = true;
            Grad.Enabled = true;
            Rest.Enabled = true;
        }
        private void Klar_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            z.Klar_A();
            Freiheit();
        }
        private void NegativPozitiv_Click(object sender, EventArgs e)
        {
            if (label1.Text[0] == '-')
            {
                label1.Text = label1.Text.Remove(0, 1);
            }
            else
            {
                label1.Text = "-" + label1.Text;
            }
        }
        private void Dezimalzahl_Click(object sender, EventArgs e)
        {
            if ((label1.Text.IndexOf(",") == -1) && (label1.Text.IndexOf("∞") == -1))
            {
                label1.Text += ",";
            }
        }
        private void Null_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
            RichtigeZahlen();
        }
        private void Eins_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
            RichtigeZahlen();
        }
        private void Zwei_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
            RichtigeZahlen();
        }
        private void Drei_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
            RichtigeZahlen();
        }
        private void Vier_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
            RichtigeZahlen();
        }
        private void Funf_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
            RichtigeZahlen();
        }
        private void Sechs_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
            RichtigeZahlen();
        }
        private void Sieben_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
            RichtigeZahlen();
        }
        private void Acht_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
            RichtigeZahlen();
        }
        private void Neun_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
            RichtigeZahlen();
        }
        private void Gleich_Click(object sender, EventArgs e)
        {
            if (!Multiplizieren.Enabled)
                label1.Text = z.Multiplizieren(Convert.ToDouble(label1.Text)).ToString();
            if (!Trennung.Enabled)
                label1.Text = z.Trennung(Convert.ToDouble(label1.Text)).ToString();
            if (!Summe.Enabled)
                label1.Text = z.Summe(Convert.ToDouble(label1.Text)).ToString();
            if (!Subtraktion.Enabled)
                label1.Text = z.Subtraktion(Convert.ToDouble(label1.Text)).ToString();
            if (!Grad.Enabled)
                label1.Text = z.Grad(Convert.ToDouble(label1.Text)).ToString();
            if (!Rest.Enabled)
                label1.Text = z.Rest(Convert.ToDouble(label1.Text)).ToString();
            z.Klar_A();
            Freiheit();
        }
        private void Multiplizieren_Click(object sender, EventArgs e)
        {
            if (Achtung())
            {
                z.Setzen_A(Convert.ToDouble(label1.Text));
                Multiplizieren.Enabled = false;
                label1.Text = "0";
            }
        }
        private void Trennung_Click(object sender, EventArgs e)
        {
            if (Achtung())
            {
                z.Setzen_A(Convert.ToDouble(label1.Text));
                Trennung.Enabled = false;
                label1.Text = "0";
            }
        }
        private void Summe_Click(object sender, EventArgs e)
        {
            if (Achtung())
            {
                z.Setzen_A(Convert.ToDouble(label1.Text));
                Summe.Enabled = false;
                label1.Text = "0";
            }
        }
        private void Subtraktion_Click(object sender, EventArgs e)
        {
            if (Achtung())
            {
                z.Setzen_A(Convert.ToDouble(label1.Text));
                Subtraktion.Enabled = false;
                label1.Text = "0";
            }
        }
        private void Grad_Click(object sender, EventArgs e)
        {
            if (Achtung())
            {
                z.Setzen_A(Convert.ToDouble(label1.Text));
                Grad.Enabled = false;
                label1.Text = "0";
            }
        }
        private void Rest_Click(object sender, EventArgs e)
        {
            if (Achtung())
            {
                z.Setzen_A(Convert.ToDouble(label1.Text));
                Rest.Enabled = false;
                label1.Text = "0";
            }
        }
        private void Wurzel_Click(object sender, EventArgs e)
        {
            if (Achtung())
            {
                z.Setzen_A(Convert.ToDouble(label1.Text));
                label1.Text = z.Wurzel().ToString();
                z.Klar_A();
                Freiheit();
            }
        }
        private void Factorial_Click(object sender, EventArgs e)
        {
            if (Achtung())
            {
                if ((Convert.ToDouble(label1.Text) == (int)(Convert.ToDouble(label1.Text))) &&
                    ((Convert.ToDouble(label1.Text) >= 0.0)))
                {
                    z.Setzen_A(Convert.ToDouble(label1.Text));
                    label1.Text = z.Factorial().ToString();
                    z.Klar_A();
                    Freiheit();
                }
                else
                    MessageBox.Show("Число должно быть >= 0 и целым!");
            }
        }
    }
}