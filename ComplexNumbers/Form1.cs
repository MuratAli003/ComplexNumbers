using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            complex obj = new complex();

            if (obj.sayiKontrol(gercek1.Text) || obj.sayiKontrol(sanal1.Text) || obj.sayiKontrol(sanal2.Text) || obj.sayiKontrol(gercek2.Text))
            {
                MessageBox.Show("Sayı dışında değer girmeyiniz!");
            }
            else
            {
                if (gercek1.Text != "" && sanal1.Text != "" && sanal2.Text != "" && gercek2.Text != "")
                {
                    double aGercek = Convert.ToDouble(gercek1.Text);
                    double aSanal = Convert.ToDouble(sanal1.Text);

                    double bGercek = Convert.ToDouble(gercek2.Text);
                    double bSanal = Convert.ToDouble(sanal2.Text);

                    complex num1 = new complex(aGercek, aSanal);
                    complex num2 = new complex(bGercek, bSanal);

                    complex sonuc = num1 + num2;

                    
                    sonuc_alan.Text = sonuc.yaz(sonuc);
                    gercek1.Text = sanal1.Text = sanal2.Text = gercek2.Text = "";

                }
                else
                {
                    MessageBox.Show("Sayı kutularını doldurunuz!");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            complex obj = new complex();

            if (obj.sayiKontrol(gercek1.Text) || obj.sayiKontrol(sanal1.Text) || obj.sayiKontrol(sanal2.Text) || obj.sayiKontrol(gercek2.Text))
            {
                MessageBox.Show("Sayı dışında değer girmeyiniz!");
            }
            else
            {
                if (gercek1.Text != "" && sanal1.Text != "" && sanal2.Text != "" && gercek2.Text != "")
                {
                    double aGercek = Convert.ToDouble(gercek1.Text);
                    double aSanal = Convert.ToDouble(sanal1.Text);

                    double bGercek = Convert.ToDouble(gercek2.Text);
                    double bSanal = Convert.ToDouble(sanal2.Text);

                    complex num1 = new complex(aGercek, aSanal);
                    complex num2 = new complex(bGercek, bSanal);

                    complex sonuc = num1 - num2;

                    sonuc_alan.Text = sonuc.yaz(sonuc);
                    gercek1.Text = sanal1.Text = sanal2.Text = gercek2.Text = "";

                }
                else
                {
                    MessageBox.Show("Sayı kutularını doldurunuz!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            complex obj = new complex();

            if (obj.sayiKontrol(gercek1.Text) || obj.sayiKontrol(sanal1.Text) || obj.sayiKontrol(sanal2.Text) || obj.sayiKontrol(gercek2.Text))
            {
                MessageBox.Show("Sayı dışında değer girmeyiniz!");
            }
            else
            {
                if (gercek1.Text != "" && sanal1.Text != "" && sanal2.Text != "" && gercek2.Text != "")
                {
                    double aGercek = Convert.ToDouble(gercek1.Text);
                    double aSanal = Convert.ToDouble(sanal1.Text);

                    double bGercek = Convert.ToDouble(gercek2.Text);
                    double bSanal = Convert.ToDouble(sanal2.Text);

                    complex num1 = new complex(aGercek, aSanal);
                    complex num2 = new complex(bGercek, bSanal);

                    complex sonuc = num1 * num2;

                    sonuc_alan.Text = sonuc.yaz(sonuc);
                    gercek1.Text = sanal1.Text = sanal2.Text = gercek2.Text = "";

                }
                else
                {
                    MessageBox.Show("Sayı kutularını doldurunuz!");
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            complex obj = new complex();

            if (obj.sayiKontrol(gercek1.Text) || obj.sayiKontrol(sanal1.Text) || obj.sayiKontrol(sanal2.Text) || obj.sayiKontrol(gercek2.Text))
            {
                MessageBox.Show("Sayı dışında değer girmeyiniz!");
            }
            else
            {
                if (gercek1.Text != "" && sanal1.Text != "" && sanal2.Text != "" && gercek2.Text != "")
                {
                    double aGercek = Convert.ToDouble(gercek1.Text);
                    double aSanal = Convert.ToDouble(sanal1.Text);

                    double bGercek = Convert.ToDouble(gercek2.Text);
                    double bSanal = Convert.ToDouble(sanal2.Text);

                    complex num1 = new complex(aGercek, aSanal);
                    complex num2 = new complex(bGercek, bSanal);

                    complex sonuc = num1 / num2;

                    sonuc_alan.Text = sonuc.yaz(sonuc);
                    gercek1.Text = sanal1.Text = sanal2.Text = gercek2.Text = "";

                }
                else
                {
                    MessageBox.Show("Sayı kutularını doldurunuz!");
                }
            }

        }
    }
    public class complex
    {
        private double nGercek;
        private double nSanal;

        public complex(double gercek, double sanal)
        {
            this.nGercek = gercek;
            this.nSanal = sanal;
        }

        public complex()
        {
            nGercek = 0;
            nSanal = 0;
        }
        public complex(complex x)
        {
            x.nSanal = this.nSanal;
            x.nGercek = this.nGercek;
        }
        public double gercek
        {
            get { return this.nGercek; }
            set { this.nGercek = value; }
        }
        public double sanal
        {
            get { return this.nSanal; }
            set { this.nSanal = value; }
        }

        public String yaz(complex x)
        {
            if (x.nSanal >= 0)
            {
                if (x.nGercek == 0 && x.nSanal == 0)
                {
                    return "0";
                }

                else if (x.nGercek != 0 && x.nSanal == 0)
                {
                    string gercek = Convert.ToString(x.nGercek);
                    return gercek;
                }

                else if (x.nGercek == 0 && x.nSanal != 0)
                {
                    if (x.nSanal == 1)
                    {
                        return "+i";
                    }
                    else if (x.nSanal == -1)
                    {
                        return "-i";
                    }
                    else
                    {
                        string sanal = Convert.ToString(x.nSanal);
                        return sanal + "i";
                    }
                }

                else
                {
                    if (x.nSanal == 1)
                    {
                        string gercek = Convert.ToString(x.nGercek);
                        return gercek + "+i";
                    }
                    else if (x.nSanal == -1)
                    {
                        string gercek = Convert.ToString(x.nGercek);
                        return gercek + "-i";
                    }
                    else
                    {
                        string gercek = Convert.ToString(x.nGercek);
                        string sanal = Convert.ToString(x.nSanal);
                        return gercek + "+" + sanal + "i";
                    }
                }
            }

            else
            {
                if (x.nGercek == 0 && x.nSanal == 0)
                {
                    return "0";
                }

                else if (x.nGercek != 0 && x.nSanal == 0)
                {
                    string gercek = Convert.ToString(x.nGercek);
                    return gercek;
                }

                else if (x.nGercek == 0 && x.nSanal != 0)
                {
                    if (x.nSanal == 1)
                    {
                        return "+i";
                    }
                    else if (x.nSanal == -1)
                    {
                        return "-i";
                    }
                    else
                    {
                        string sanal = Convert.ToString(x.nSanal);
                        return sanal + "i";
                    }
                }
                else
                {
                    if (x.nSanal == 1)
                    {
                        string gercek = Convert.ToString(x.nGercek);
                        return gercek + "+i";
                    }
                    else if (x.nSanal == -1)
                    {
                        string gercek = Convert.ToString(x.nGercek);
                        return gercek + "-i";
                    }
                    else
                    {
                        string gercek = Convert.ToString(x.nGercek);
                        string sanal = Convert.ToString(x.nSanal);
                        return gercek + sanal + "i";
                    }
                }
            }

        }
        public Boolean sayiKontrol(string x)
        {
            string kontrol = "qwertyuıopğüasdfghjklşizxcvbnmöçQWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ.,<>*/";

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < kontrol.Length; j++)
                {
                    if (x[i] == kontrol[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static complex operator +(complex x, complex y)
        {
            double aGercek = x.nGercek + y.nGercek;
            double aSanal = x.sanal + y.sanal;

            return new complex(aGercek, aSanal);

        }
        public static complex operator -(complex x, complex y)
        {
            double aGercek = x.nGercek - y.nGercek;
            double aSanal = x.sanal - y.sanal;

            return new complex(aGercek, aSanal);

        }
        public static complex operator *(complex x, complex y)
        {
            double aSanal = (x.nSanal * y.nGercek) + (x.nGercek * y.nSanal);
            double aGercek = (x.nGercek * y.nGercek) + ((-1) * (x.nSanal * y.sanal));

            return new complex(aGercek, aSanal);
        }

        public static complex operator /(complex x, complex y)
        {
            complex y1 = new complex(y.nGercek, -1 * y.nSanal);

            complex pay = x * y1;
            complex payda = y * y1;

            double aSanal = pay.nSanal / payda.nGercek;
            double aGercek = pay.nGercek / payda.nGercek;

            return new complex(aGercek, aSanal);
        }
    }
}
