using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int gen(double half) 
        {
            double s = 0;
            int m = 0;
            while (s > -half)
            {
                double alf = rnd.NextDouble();
                s = s + Math.Log(alf);
                m++;
            }
            return m;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wales = gen(8);
            int france = gen(5);
            int japan = gen(15);
            int southAfrica = gen(3);
            int england = gen(11);
            int australia = gen(9);
            int newZealand = gen(10);
            int ireland = gen(7);
            label1.Text = wales.ToString();
            label2.Text = france.ToString();
            label3.Text = southAfrica.ToString();
            label4.Text = japan.ToString();
            label5.Text = ireland.ToString();
            label6.Text = newZealand.ToString();
            label7.Text = australia.ToString();
            label8.Text = england.ToString();
            int wales2, france2, japan2, southAfrica2, england2, australia2, newZealand2, ireland2, fin1, fin2, fin3, fin4;

            while (wales == france)
            {
                wales = gen(8);
                france = gen(5);
            }
            if (wales > france)
            {
                wales2 = gen(10);
                label13.Text = "WALES";
                label10.Text = wales2.ToString();
            }
            else 
            {
                france2 = gen(4);
                label13.Text = "FRANCE";
                label10.Text = france2.ToString();
            }

            while (japan == southAfrica)
            {
                japan = gen(15);
                southAfrica = gen(3);
            }
            if (japan > southAfrica)
            {
                japan2 = gen(4);
                label14.Text = "JAPAN";
                label9.Text = japan2.ToString();
            }
            else 
            {
                southAfrica2 = gen(12);
                label14.Text = "SOUTH AFRICA";
                label9.Text = southAfrica2.ToString();
            }

            while (england == australia)
            {
                england = gen(11);
                australia = gen(9);
            }
            if (england > australia)
            {
                england2 = gen(9);
                label16.Text = "ENGLAND";
                label12.Text = england2.ToString();
            }
            else 
            {
                australia2 = gen(8);
                label16.Text = "AUSTRALIA";
                label12.Text = australia2.ToString();
            }

            while (newZealand == ireland)
            {
                newZealand = gen(10);
                ireland = gen(7);
            }
            if (newZealand > ireland)
            {
                newZealand2 = gen(7);
                label15.Text = "NEW ZEALAND";
                label11.Text = newZealand2.ToString();
            }
            else 
            {
                ireland2 = gen(11);
                label15.Text = "IRELAND";
                label11.Text = ireland2.ToString();
            }

            while (Int32.Parse(label10.Text) == Int32.Parse(label9.Text))
            {
                label10.Text = gen(5).ToString();
                label9.Text = gen(5).ToString();
            }
            if (Int32.Parse(label10.Text) > Int32.Parse(label9.Text))
            {
                fin1 = gen(8);
                label19.Text = label13.Text;
                label20.Text = fin1.ToString();
            }
            else 
            {
                fin2 = gen(13);
                label19.Text = label14.Text;
                label20.Text = fin2.ToString();
            }

            while (Int32.Parse(label12.Text) == Int32.Parse(label11.Text))
            {
                label12.Text = gen(9).ToString();
                label11.Text = gen(9).ToString();
            }
            if (Int32.Parse(label12.Text) > Int32.Parse(label11.Text))
            {
                fin3 = gen(12);
                label17.Text = label16.Text;
                label18.Text = fin3.ToString();
            }
            else 
            {
                fin4 = gen(6);
                label17.Text = label15.Text;
                label18.Text = fin4.ToString();
            }
        }
    }
}
