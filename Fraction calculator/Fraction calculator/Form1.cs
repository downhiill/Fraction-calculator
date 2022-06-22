using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraction_calculator
{
    public partial class Calculator : System.Windows.Forms.Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        Fraction Droba;
        Fraction Drobb;
        int p;

        private void Form1_Load(object sender, EventArgs e)
        {          
            label4.Text = "";
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox1, "Числитель первой дроби");
            ToolTip c = new ToolTip();
            c.SetToolTip(textBox2, "Знаменатель первой дроби");
            ToolTip k = new ToolTip();
            k.SetToolTip(textBox3, "Числитель второй дроби");
            ToolTip m = new ToolTip();
            m.SetToolTip(textBox4, "Знаменатель второй дроби");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
            if ((int.TryParse(textBox1.Text, out p)) & (int.TryParse(textBox2.Text, out p)) & (int.TryParse(textBox3.Text, out p)) & (int.TryParse(textBox4.Text, out p)))
            {
                Droba = new Fraction(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                Drobb = new Fraction(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
                Fraction fraction = Fraction.Sum(Droba, Drobb);
                label6.Text = fraction.getNumerator();
                label8.Text = fraction.getDenominator();

            }
            else
            {

                label4.Text = "Введите числа в числитель и знаменатель!";

            }
            





        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            if ((int.TryParse(textBox1.Text, out p)) & (int.TryParse(textBox2.Text, out p)) & (int.TryParse(textBox3.Text, out p)) & (int.TryParse(textBox4.Text, out p)))
            {
                Droba = new Fraction(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                Drobb = new Fraction(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));              
                Fraction fraction = Fraction.Sub(Droba, Drobb);
                label6.Text = fraction.getNumerator();
                label8.Text = fraction.getDenominator();

            }
            else
            {
                   
                label4.Text = "Введите числа в числитель и знаменатель!";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
            if ((int.TryParse(textBox1.Text, out p)) & (int.TryParse(textBox2.Text, out p)) & (int.TryParse(textBox3.Text, out p)) & (int.TryParse(textBox4.Text, out p)))
            {
                Droba = new Fraction(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                Drobb = new Fraction(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
                
                Fraction fraction = Fraction.Mul(Droba, Drobb);
                label6.Text = fraction.getNumerator();
                label8.Text = fraction.getDenominator();

                //string[] arr = Fraction.Mul(Droba, Drobb).ToString().Split(new char[] {'/'});
                //label6.Text = arr[0];
                //label8.Text = arr[1];


            }
            else
            {              
                label4.Text = "Введите числа в числитель и знаменатель!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "/";
            if ((int.TryParse(textBox1.Text, out p)) & (int.TryParse(textBox2.Text, out p)) & (int.TryParse(textBox3.Text, out p)) & (int.TryParse(textBox4.Text, out p)))
            {
                Droba = new Fraction(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                Drobb = new Fraction(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
                Fraction fraction = Fraction.Div(Droba, Drobb);
                label6.Text = fraction.getNumerator();
                label8.Text = fraction.getDenominator();

            }
            else
            {
                
                label4.Text = "Введите числа в числитель и знаменатель!";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "-")
            {
                label4.Text = "Знаменатель не может быть отрицательным!";
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Formpravila f2 = new Formpravila();

            f2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
