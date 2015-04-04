using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_galo
{
    public partial class Form1 : Form
    {
        int cont=0;
        int jog=0;
        int venc=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jog == 0)
            {
                button1.Text = "O";
                button1.Enabled = false;
                jog = 1;
                cont = cont + 1;
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("Jogador 1 Ganha");
                }
            }
            else if (jog == 1)
            {
                button1.Text = "X";
                button1.Enabled = false;
                jog = 0;
                cont = cont + 1; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (jog == 0)
            {
                button2.Text = "O";
                button2.Enabled = false;
                jog = 1;
                cont = cont + 1;
            }
            else if (jog == 1)
            {
                button2.Text = "X";
                button2.Enabled = false;
                jog = 0;
                cont = cont + 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (jog == 0)
            {
                button3.Text = "O";
                button3.Enabled = false;
                jog = 1;
                cont = cont + 1;
            }
            else if (jog == 1)
            {
                button3.Text = "X";
                button3.Enabled = false;
                jog = 0;
                cont = cont + 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (jog == 0)
            {
                button4.Text = "O";
                button4.Enabled = false;
                jog = 1;
                cont = cont + 1;
            }
            else if (jog == 1)
            {
                button4.Text = "X";
                button4.Enabled = false;
                jog = 0;
                cont = cont + 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (jog == 0)
            {
                button5.Text = "O";
                button5.Enabled = false;
                jog = 1;
                cont = cont + 1;
            }
            else if (jog == 1)
            {
                button5.Text = "X";
                button5.Enabled = false;
                jog = 0;
                cont = cont + 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (jog == 0)
            {
                button6.Text = "O";
                button6.Enabled = false;
                jog = 1;
                cont = cont + 1;
            }
            else if (jog == 1)
            {
                button6.Text = "X";
                button6.Enabled = false;
                jog = 0;
                cont = cont + 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (jog == 0)
            {
                button7.Text = "O";
                button7.Enabled = false;
                jog = 1;
                cont = cont + 1;
            }
            else if (jog == 1)
            {
                button7.Text = "X";
                button7.Enabled = false;
                jog = 0;
                cont = cont + 1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (jog == 0)
            {
                button8.Text = "O";
                button8.Enabled = false;
                jog = 1;
                cont = cont + 1;
            }
            else if (jog == 1)
            {
                button8.Text = "X";
                button8.Enabled = false;
                jog = 0;
                cont = cont + 1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (jog == 0)
            {
                button9.Text = "O";
                button9.Enabled = false;
                jog = 1;
                cont = cont + 1;
            }
            else if (jog == 1)
            {
                button9.Text = "X";
                button9.Enabled = false;
                jog = 0;
                cont = cont + 1;
            }
        }
    }
}
