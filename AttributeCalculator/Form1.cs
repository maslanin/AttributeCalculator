using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AttributeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // например, на 10 лвл дают (10 - 1) * 3 атриков
            if ((int)atr3x.Value < 5 && (int)atr2x.Value > 0)
            {
                MessageBox.Show("Атрибуты x2 не могут быть заполнены, пока атрибуты x3 меньше 5!");
                return;
            }
            if ((int)atr2x.Value < 5 && (int)atr1x.Value > 0)
            {
                MessageBox.Show("Атрибуты x1 не могут быть заполнены, пока атрибуты x2 меньше 5!");
                return;
            }
            int popravka = (int)lvl.Value - 1; // дают не с 1, а с 2 лвла
            popravka *= 4;
            if ((int)lvl.Value > 156)
            {
                int bla = (int)lvl.Value - 156;
                popravka += bla * 2; // лишние 2 звезды на каждый 156+ лвл
            }
            popravka += (int)atr3x.Value * 3;
            popravka += (int)atr2x.Value * 2;
            popravka += (int)atr1x.Value;
            int full = popravka;
            full -= (int)hp.Value;
            full -= (int)mana.Value;
            full -= (int)atk.Value;
            full -= (int)def.Value;
            full -= (int)free.Value;
            textBox1.Text = popravka.ToString();
            textBox2.Text = full.ToString();
        }
    }
}
