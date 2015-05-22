using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jogo_galo.Properties;
using System.IO;

namespace Jogo_galo
{
    public partial class Form1 : Form
    {
        //variavél conta jogadas
        int cont=0;
        //variavél vez do jogador
        int jog=0;
        //variavél de vencedor
        int venc=0;
        //variavél de linguagem
        int ling = 0;
        //variavél de tema fundo
        int temaf = 0;
        //variavél de tema tabuleiro
        int temat = 0;
        // variavél segundos
        int sec=0;
        // variavél minutos
        int min=0;
        // variavél nome do jogador 1
        string jogador1;
        // variavél nome do jogador 2
        string jogador2;
        //variavel imagens
        int img1=0;
        int img2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //butao casa numro 1
            if (textBox1.Text == "")
            {
                jogador1 = "Jogador1";
                
            }
            else if (textBox2.Text == "")
            {
                jogador2 = "Jogador2";
            }
            else
            {
                jogador1 = textBox1.Text;
                jogador2 = textBox2.Text;
            }
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            
            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = jogador2+" é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador2 + " its your turn";
                }
                button1.Text = "O";
                button1.Enabled = false;
                jog = 1;
                cont = cont + 1;
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                    
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                 else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (cont == 9 && venc == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show("Empate!!!!", "Empate");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Draw!!!!!", "Draw");
                        timer1.Enabled = false;
                    }
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = jogador1 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador1 + " its your turn";
                }
                button1.Text = "X";
                button1.Enabled = false;
                jog = 0;
                cont = cont + 1;
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (cont == 9 && venc == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show("Empate!!!!", "Empate");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Draw!!!!!", "Draw");
                        timer1.Enabled = false;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //butao casa numero 2
            if (textBox1.Text == "")
            {
                jogador1 = "Jogador1";
            }
            else if (textBox2.Text == "")
            {
                jogador2 = "Jogador2";
            }
            else
            {
                jogador1 = textBox1.Text;
                jogador2 = textBox2.Text;
            }
            textBox1.Enabled = false;
            textBox2.Enabled = false;

            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = jogador2 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador2 + " its your turn";
                }
                button2.Text = "O";
                button2.Enabled = false;
                jog = 1;
                cont = cont + 1;
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (cont == 9 && venc == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show("Empate!!!!", "Empate");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Draw!!!!!", "Draw");
                        timer1.Enabled = false;
                    }
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = jogador1 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador1 + " its your turn";
                }
                button2.Text = "X";
                button2.Enabled = false;
                jog = 0;
                cont = cont + 1;
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (cont == 9 && venc == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show("Empate!!!!", "Empate");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Draw!!!!!", "Draw");
                        timer1.Enabled = false;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //butao casa numero 3
            if (textBox1.Text == "")
            {
                jogador1 = "Jogador1";
            }
            else if (textBox2.Text == "")
            {
                jogador2 = "Jogador2";
            }
            else
            {
                jogador1 = textBox1.Text;
                jogador2 = textBox2.Text;
            }
            textBox1.Enabled = false;
            textBox2.Enabled = false;

            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = jogador2 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador2 + " its your turn";
                }
                button3.Text = "O";
                button3.Enabled = false;
                jog = 1;
                cont = cont + 1;
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (cont == 9 && venc == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show("Empate!!!!", "Empate");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Draw!!!!!", "Draw");
                        timer1.Enabled = false;
                    }
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = jogador1 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador1 + " its your turn";
                }
                button3.Text = "X";
                button3.Enabled = false;
                jog = 0;
                cont = cont + 1;
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (cont == 9 && venc == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show("Empate!!!!", "Empate");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Draw!!!!!", "Draw");
                        timer1.Enabled = false;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //butao casa numero 4
            if (textBox1.Text == "")
            {
                jogador1 = "Jogador1";
            }
            else if (textBox2.Text == "")
            {
                jogador2 = "Jogador2";
            }
            else
            {
                jogador1 = textBox1.Text;
                jogador2 = textBox2.Text;
            }
            textBox1.Enabled = false;
            textBox2.Enabled = false;

            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = jogador2 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador2 + " its your turn";
                }
                button4.Text = "O";
                button4.Enabled = false;
                jog = 1;
                cont = cont + 1;
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (cont == 9 && venc == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show("Empate!!!!", "Empate");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Draw!!!!!", "Draw");
                        timer1.Enabled = false;
                    }
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = jogador1 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador1 + " its your turn";
                }
                button4.Text = "X";
                button4.Enabled = false;
                jog = 0;
                cont = cont + 1;
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (cont == 9 && venc == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show("Empate!!!!", "Empate");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Draw!!!!!", "Draw");
                        timer1.Enabled = false;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //butao casa numero 5
            if (textBox1.Text == "")
            {
                jogador1 = "Jogador1";
            }
            else if (textBox2.Text == "")
            {
                jogador2 = "Jogador2";
            }
            else
            {
                jogador1 = textBox1.Text;
                jogador2 = textBox2.Text;
            }
            textBox1.Enabled = false;
            textBox2.Enabled = false;

            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = jogador2 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador2 + " its your turn";
                }
                button5.Text = "O";
                button5.Enabled = false;
                jog = 1;
                cont = cont + 1;
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (cont == 9 && venc == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show("Empate!!!!", "Empate");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Draw!!!!!", "Draw");
                        timer1.Enabled = false;
                    }
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = jogador1 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador1 + " its your turn";
                }
                button5.Text = "X";
                button5.Enabled = false;
                jog = 0;
                cont = cont + 1;
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    
                    venc = 1;
                }
                else if (cont == 9 && venc == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show("Empate!!!!", "Empate");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Draw!!!!!", "Draw");
                        timer1.Enabled = false;
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //butao casa numero 6
            if (textBox1.Text == "")
            {
                jogador1 = "Jogador1";
            }
            else if (textBox2.Text == "")
            {
                jogador2 = "Jogador2";
            }
            else
            {
                jogador1 = textBox1.Text;
                jogador2 = textBox2.Text;
            }
            textBox1.Enabled = false;
            textBox2.Enabled = false;

            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = jogador2 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador2 + " its your turn";
                }
                button6.Text = "O";
                button6.Enabled = false;
                jog = 1;
                cont = cont + 1;
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (cont == 9 && venc == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show("Empate!!!!", "Empate");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Draw!!!!!", "Draw");
                        timer1.Enabled = false;
                    }
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = jogador1 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador1 + " its your turn";
                }
                button6.Text = "X";
                button6.Enabled = false;
                jog = 0;
                cont = cont + 1;
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (cont == 9 && venc == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show("Empate!!!!", "Empate");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Draw!!!!!", "Draw");
                        timer1.Enabled = false;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //butao casa numero 7
            if (textBox1.Text == "")
            {
                jogador1 = "Jogador1";
            }
            else if (textBox2.Text == "")
            {
                jogador2 = "Jogador2";
            }
            else
            {
                jogador1 = textBox1.Text;
                jogador2 = textBox2.Text;
            }
            textBox1.Enabled = false;
            textBox2.Enabled = false;

            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = jogador2 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador2 + " its your turn";
                }
                button7.Text = "O";
                button7.Enabled = false;
                jog = 1;
                cont = cont + 1;
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (cont == 9 && venc == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show("Empate!!!!", "Empate");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Draw!!!!!", "Draw");
                        timer1.Enabled = false;
                    }
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = jogador1 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador1 + " its your turn";
                }
                
                button7.Text = "X";
                button7.Enabled = false;
                jog = 0;
                cont = cont + 1;
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (cont == 9 && venc == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show("Empate!!!!", "Empate");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Draw!!!!!", "Draw");
                        timer1.Enabled = false;
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //butao casa numero 8
            if (textBox1.Text == "")
            {
                jogador1 = "Jogador1";
            }
            else if (textBox2.Text == "")
            {
                jogador2 = "Jogador2";
            }
            else
            {
                jogador1 = textBox1.Text;
                jogador2 = textBox2.Text;
            }
            textBox1.Enabled = false;
            textBox2.Enabled = false;

            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = jogador2 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador2 + " its your turn";
                }
                button8.Text = "O";
                button8.Enabled = false;
                jog = 1;
                cont = cont + 1;
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (cont == 9 && venc == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show("Empate!!!!", "Empate");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Draw!!!!!", "Draw");
                        timer1.Enabled = false;
                    }
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = jogador1 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador1 + " its your turn";
                }
                button8.Text = "X";
                button8.Enabled = false;
                jog = 0;
                cont = cont + 1;
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (cont == 9 && venc == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show("Empate!!!!", "Empate");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Draw!!!!!", "Draw");
                        timer1.Enabled = false;
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //butao casa numero 9
            if (textBox1.Text == "")
            {
                jogador1 = "Jogador1";
            }
            else if (textBox2.Text == "")
            {
                jogador2 = "Jogador2";
            }
            else
            {
                jogador1 = textBox1.Text;
                jogador2 = textBox2.Text;
            }
            textBox1.Enabled = false;
            textBox2.Enabled = false;

            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = jogador2 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador2 + " its your turn";
                }
                button9.Text = "O";
                button9.Enabled = false;
                jog = 1;
                cont = cont + 1;
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1+" Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1+" win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador1 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador1 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (cont == 9 && venc == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show("Empate!!!!", "Empate");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Draw!!!!!", "Draw");
                        timer1.Enabled = false;
                    }
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = jogador1 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador1 + " its your turn";
                }
                button9.Text = "X";
                button9.Enabled = false;
                jog = 0;
                cont = cont + 1;
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show(jogador2 + " Ganha!!!!", "vencedor");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show(jogador2 + " win!!!!", "Winner");
                        timer1.Enabled = false;
                    }
                    venc = 1;
                }
                else if (cont == 9 && venc == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    if (ling == 0)
                    {
                        MessageBox.Show("Empate!!!!", "Empate");
                        timer1.Enabled = false;
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Draw!!!!!", "Draw");
                        timer1.Enabled = false;
                    }
                }
            }
        }

        private void riniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menu opção reiniciar
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            textBox1.Text = "jogador1";
            textBox2.Text = "jogador2";
            textBox1.Enabled = true;
            textBox2.Enabled = true;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            
            cont = 0;
            venc = 0;
            sec = 0;
            min = 0;
            label8.Text = Convert.ToString(sec);
            label6.Text = Convert.ToString(min);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menu opção sair
            if (ling == 0)
            {
                DialogResult saida = MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (saida == DialogResult.Yes)
                {
                    if (venc == 0)
                    {
                        Settings.Default.simg1 = img1;
                        Settings.Default.simg2 = img2;
                        Settings.Default["ss"] = 1;
                        Settings.Default["btn1"] = button1.Text;
                        Settings.Default["btn2"] = button2.Text;
                        Settings.Default["btn3"] = button3.Text;
                        Settings.Default["btn4"] = button4.Text;
                        Settings.Default["btn5"] = button5.Text;
                        Settings.Default["btn6"] = button6.Text;
                        Settings.Default["btn7"] = button7.Text;
                        Settings.Default["btn8"] = button8.Text;
                        Settings.Default["btn9"] = button9.Text;
                        Settings.Default["svenc"] = venc;
                        Settings.Default["sjog"] = jog;
                        Settings.Default["btn1e"] = button1.Enabled.ToString();
                        Settings.Default["btn2e"] = button2.Enabled.ToString();
                        Settings.Default["btn3e"] = button3.Enabled.ToString();
                        Settings.Default["btn4e"] = button4.Enabled.ToString();
                        Settings.Default["btn5e"] = button5.Enabled.ToString();
                        Settings.Default["btn6e"] = button6.Enabled.ToString();
                        Settings.Default["btn7e"] = button7.Enabled.ToString();
                        Settings.Default["btn8e"] = button8.Enabled.ToString();
                        Settings.Default["btn9e"] = button9.Enabled.ToString();
                        Settings.Default["thf"] = temaf;
                        Settings.Default["tht"] = temat;
                        Settings.Default["contjog"] = cont;
                        Settings.Default["sling"] = ling;
                        Settings.Default["nomjog1"] = jogador1;
                        Settings.Default["nomjog2"] = jogador2;
                        Settings.Default["ssec"] = sec;
                        Settings.Default["smin"] = min;
                        Settings.Default.Save();
                        Application.Exit();
                    }
                    else if (venc == 1)
                    {
                        Settings.Default.simg1 = 0;
                        Settings.Default.simg2 = 0;
                        Settings.Default["ss"] = 0;
                        Settings.Default["btn1"] = "";
                        Settings.Default["btn2"] = "";
                        Settings.Default["btn3"] = "";
                        Settings.Default["btn4"] = "";
                        Settings.Default["btn5"] = "";
                        Settings.Default["btn6"] = "";
                        Settings.Default["btn7"] = "";
                        Settings.Default["btn8"] = "";
                        Settings.Default["btn9"] = "";
                        Settings.Default["svenc"] = 0;
                        Settings.Default["sjog"] = jog;
                        Settings.Default["btn1e"] = "";
                        Settings.Default["btn2e"] = "";
                        Settings.Default["btn3e"] = "";
                        Settings.Default["btn4e"] = "";
                        Settings.Default["btn5e"] = "";
                        Settings.Default["btn6e"] = "";
                        Settings.Default["btn7e"] = "";
                        Settings.Default["btn8e"] = "";
                        Settings.Default["btn9e"] = "";
                        Settings.Default["thf"] = temaf;
                        Settings.Default["tht"] = temat;
                        Settings.Default["contjog"] = 0;
                        Settings.Default["sling"] = ling;
                        Settings.Default["nomjog1"] = "jogador1";
                        Settings.Default["nomjog2"] = "jogador2";
                        Settings.Default["ssec"] = 0;
                        Settings.Default["smin"] = 0;
                        Settings.Default.Save();
                        Application.Exit();
                    }
                }
                else
                {

                }
            }
            if (ling == 1)
            {
                MessageBoxManager.OK = "Yeas";
                MessageBoxManager.Cancel = "No";
                MessageBoxManager.Register();
                DialogResult saida = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                MessageBoxManager.Unregister();
                if (saida == DialogResult.OK)
                {
                    if (venc == 0)
                    {
                        Settings.Default.simg1 = img1;
                        Settings.Default.simg2 = img2;
                        Settings.Default["ss"] = 1;
                        Settings.Default["btn1"] = button1.Text;
                        Settings.Default["btn2"] = button2.Text;
                        Settings.Default["btn3"] = button3.Text;
                        Settings.Default["btn4"] = button4.Text;
                        Settings.Default["btn5"] = button5.Text;
                        Settings.Default["btn6"] = button6.Text;
                        Settings.Default["btn7"] = button7.Text;
                        Settings.Default["btn8"] = button8.Text;
                        Settings.Default["btn9"] = button9.Text;
                        Settings.Default["svenc"] = venc;
                        Settings.Default["sjog"] = jog;
                        Settings.Default["btn1e"] = button1.Enabled.ToString();
                        Settings.Default["btn2e"] = button2.Enabled.ToString();
                        Settings.Default["btn3e"] = button3.Enabled.ToString();
                        Settings.Default["btn4e"] = button4.Enabled.ToString();
                        Settings.Default["btn5e"] = button5.Enabled.ToString();
                        Settings.Default["btn6e"] = button6.Enabled.ToString();
                        Settings.Default["btn7e"] = button7.Enabled.ToString();
                        Settings.Default["btn8e"] = button8.Enabled.ToString();
                        Settings.Default["btn9e"] = button9.Enabled.ToString();
                        Settings.Default["thf"] = temaf;
                        Settings.Default["tht"] = temat;
                        Settings.Default["contjog"] = cont;
                        Settings.Default["sling"] = ling;
                        Settings.Default["nomjog1"] = jogador1;
                        Settings.Default["nomjog2"] = jogador2;
                        Settings.Default["ssec"] = sec;
                        Settings.Default["smin"] = min;
                        Settings.Default.Save();
                        Application.Exit();
                    }
                    else if (venc == 1)
                    {
                        Settings.Default.simg1 = 0;
                        Settings.Default.simg2 = 0;
                        Settings.Default["ss"] = 0;
                        Settings.Default["btn1"] = "";
                        Settings.Default["btn2"] = "";
                        Settings.Default["btn3"] = "";
                        Settings.Default["btn4"] = "";
                        Settings.Default["btn5"] = "";
                        Settings.Default["btn6"] = "";
                        Settings.Default["btn7"] = "";
                        Settings.Default["btn8"] = "";
                        Settings.Default["btn9"] = "";
                        Settings.Default["svenc"] = 0;
                        Settings.Default["sjog"] = jog;
                        Settings.Default["btn1e"] = "";
                        Settings.Default["btn2e"] = "";
                        Settings.Default["btn3e"] = "";
                        Settings.Default["btn4e"] = "";
                        Settings.Default["btn5e"] = "";
                        Settings.Default["btn6e"] = "";
                        Settings.Default["btn7e"] = "";
                        Settings.Default["btn8e"] = "";
                        Settings.Default["btn9e"] = "";
                        Settings.Default["thf"] = temaf;
                        Settings.Default["tht"] = temat;
                        Settings.Default["contjog"] = 0;
                        Settings.Default["sling"] = ling;
                        Settings.Default["nomjog1"] = "jogador1";
                        Settings.Default["nomjog2"] = "jogador2";
                        Settings.Default["ssec"] = 0;
                        Settings.Default["smin"] = 0;
                        Settings.Default.Save();
                        Application.Exit();
                    }
                }
                else
                {

                }
            }
        }

        private void v10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //changelog versão 1.0
            if (ling == 0)
            {
                MessageBox.Show("Versão 1.0\n-Primeira release\n :)\n", "changelog");
            }
            else if (ling == 1)
            {
                MessageBoxManager.OK = "OK";
                MessageBoxManager.Cancel = "Cancel";
                MessageBoxManager.Register();
                MessageBox.Show("Version 1.0\n-First release\n :)\n", "changelog");
                MessageBoxManager.Unregister();
            }
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //changelog versão 2.0
            if (ling == 0)
            {
                MessageBox.Show("Versão 2.0\n-Adicionado menu(com poucas funcões)\n:|", "changelog");
            }
            else if (ling == 1)
            {
                MessageBoxManager.OK = "OK";
                MessageBoxManager.Cancel = "Cancel";
                MessageBoxManager.Register();
                MessageBox.Show("Version 2.0\n-Added menu(with few functions)\n:|", "changelog");
                MessageBoxManager.Unregister();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            ling = Settings.Default.sling;
            contraHumanoToolStripMenuItem.CheckState = CheckState.Checked;
            portuguêsToolStripMenuItem.CheckState = CheckState.Checked;
            originalToolStripMenuItem.CheckState = CheckState.Checked;
            originalToolStripMenuItem1.CheckState = CheckState.Checked;
            jogador1 = "jogador 1";
            jogador2 = "jogador 2";
            textBox1.Text = jogador1;
            textBox2.Text = jogador2;
            if (Settings.Default.ss == 1)
            {
                if (ling == 0)
                {
                    DialogResult jogo = MessageBox.Show("Existe um jogo guardado pretende carregar?", "Jogo do galo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (jogo == DialogResult.Yes)
                    {

                        pictureBox5.BackgroundImage = Jogo_galo.Properties.Resources.foto;
                        pictureBox6.BackgroundImage = Jogo_galo.Properties.Resources.foto;
                        button1.Text = Settings.Default.btn1;
                        button2.Text = Settings.Default.btn2;
                        button3.Text = Settings.Default.btn3;
                        button4.Text = Settings.Default.btn4;
                        button5.Text = Settings.Default.btn5;
                        button6.Text = Settings.Default.btn6;
                        button7.Text = Settings.Default.btn7;
                        button8.Text = Settings.Default.btn8;
                        button9.Text = Settings.Default.btn9;
                        textBox1.Text = Settings.Default.nomjog1;
                        textBox2.Text = Settings.Default.nomjog2;
                        jogador1 = Settings.Default.nomjog1;
                        jogador2 = Settings.Default.nomjog2;
                        sec = Settings.Default.ssec;
                        min = Settings.Default.smin;
                        label8.Text = Convert.ToString(sec);
                        label6.Text = Convert.ToString(min);
                        //condições para ajustar o jogo ao processo guardado
                        if (Settings.Default.tb1e == "False")
                        {
                            textBox1.Enabled = false;
                        }
                        if (Settings.Default.tb2e == "False")
                        {
                            textBox2.Enabled = false;
                        }
                        if (Settings.Default.btn1e == "False")
                        {
                            button1.Enabled = false;
                        }
                        if (Settings.Default.btn2e == "False")
                        {
                            button2.Enabled = false;
                        }
                        if (Settings.Default.btn3e == "False")
                        {
                            button3.Enabled = false;
                        }
                        if (Settings.Default.btn4e == "False")
                        {
                            button4.Enabled = false;
                        }
                        if (Settings.Default.btn5e == "False")
                        {
                            button5.Enabled = false;
                        }
                        if (Settings.Default.btn6e == "False")
                        {
                            button6.Enabled = false;
                        }
                        if (Settings.Default.btn7e == "False")
                        {
                            button7.Enabled = false;
                        }
                        if (Settings.Default.btn8e == "False")
                        {
                            button8.Enabled = false;
                        }
                        if (Settings.Default.btn9e == "False")
                        {
                            button9.Enabled = false;
                        }
                        venc = Settings.Default.svenc;
                        jog = Settings.Default.sjog;
                        cont = Settings.Default.contjog;
                    }
                    else
                    {
                        pictureBox5.BackgroundImage = Jogo_galo.Properties.Resources.foto;
                        pictureBox6.BackgroundImage = Jogo_galo.Properties.Resources.foto;
                    }
                }
                else if (ling == 1)
                {
                    MessageBoxManager.OK = "Yeas";
                    MessageBoxManager.Cancel = "No";
                    MessageBoxManager.Register();
                    DialogResult jogo = MessageBox.Show("You have an saved game do you want to load progress?", "TicTac Toe", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    MessageBoxManager.Unregister();
                    if (jogo == DialogResult.Yes)
                    {
                        pictureBox5.BackgroundImage = Jogo_galo.Properties.Resources.foto;
                        pictureBox6.BackgroundImage = Jogo_galo.Properties.Resources.foto;
                        button1.Text = Settings.Default.btn1;
                        button2.Text = Settings.Default.btn2;
                        button3.Text = Settings.Default.btn3;
                        button4.Text = Settings.Default.btn4;
                        button5.Text = Settings.Default.btn5;
                        button6.Text = Settings.Default.btn6;
                        button7.Text = Settings.Default.btn7;
                        button8.Text = Settings.Default.btn8;
                        button9.Text = Settings.Default.btn9;
                        textBox1.Text = Settings.Default.nomjog1;
                        textBox2.Text = Settings.Default.nomjog2;
                        jogador1 = Settings.Default.nomjog1;
                        jogador2 = Settings.Default.nomjog2;
                        sec = Settings.Default.ssec;
                        min = Settings.Default.smin;
                        label8.Text = Convert.ToString(sec);
                        label6.Text = Convert.ToString(min);
                        //condições para ajustar o jogo ao processo guardado
                        if (Settings.Default.tb1e == "False")
                        {
                            textBox1.Enabled = false;
                        }
                        if (Settings.Default.tb2e == "False")
                        {
                            textBox2.Enabled = false;
                        }
                        if (Settings.Default.btn1e == "False")
                        {
                            button1.Enabled = false;
                        }
                        if (Settings.Default.btn2e == "False")
                        {
                            button2.Enabled = false;
                        }
                        if (Settings.Default.btn3e == "False")
                        {
                            button3.Enabled = false;
                        }
                        if (Settings.Default.btn4e == "False")
                        {
                            button4.Enabled = false;
                        }
                        if (Settings.Default.btn5e == "False")
                        {
                            button5.Enabled = false;
                        }
                        if (Settings.Default.btn6e == "False")
                        {
                            button6.Enabled = false;
                        }
                        if (Settings.Default.btn7e == "False")
                        {
                            button7.Enabled = false;
                        }
                        if (Settings.Default.btn8e == "False")
                        {
                            button8.Enabled = false;
                        }
                        if (Settings.Default.btn9e == "False")
                        {
                            button9.Enabled = false;
                        }
                        venc = Settings.Default.svenc;
                        jog = Settings.Default.sjog;
                        cont = Settings.Default.contjog;
                    }
                    else
                    {
                        pictureBox5.BackgroundImage = Jogo_galo.Properties.Resources.foto;
                        pictureBox6.BackgroundImage = Jogo_galo.Properties.Resources.foto;
                    }
                }
            }
            
            if (ling == 0)
            {
                jogoToolStripMenuItem.Text = "Jogo";
                novoJogoToolStripMenuItem.Text = "Novo jogo";
                riniciarToolStripMenuItem.Text = "riniciar";
                sairToolStripMenuItem.Text = "Sair";
                temasToolStripMenuItem.Text = "Temas";
                fundoToolStripMenuItem.Text = "Fundo";
                tabuleiroToolStripMenuItem.Text = "Tabuleiro";
                azulToolStripMenuItem.Text = "Azul";
                azulToolStripMenuItem1.Text = "Azul";
                brancoToolStripMenuItem.Text = "Preto";
                brancoToolStripMenuItem1.Text = "Branco";
                verdeToolStripMenuItem.Text = "Verde";
                verdeToolStripMenuItem1.Text = "Verde";
                amareloToolStripMenuItem.Text = "Amarelo";
                amareloToolStripMenuItem1.Text = "Amarelo";
                laranjaToolStripMenuItem.Text = "LaranJa";
                laranjaToolStripMenuItem1.Text = "Laranja";
                rosaToolStripMenuItem.Text = "Rosa";
                rosaToolStripMenuItem1.Text = "Rosa";
                originalToolStripMenuItem.Text = "Original";
                originalToolStripMenuItem1.Text = "Original";
                linguagensToolStripMenuItem.Text = "Linguagem";
                portuguêsToolStripMenuItem.Text = "Português";
                inglêsToolStripMenuItem.Text = "Inglês";
                contraHumanoToolStripMenuItem.Text = "Contra Humanos";
                label4.Text = "Jogo do galo v 5.3 LP";
                inglêsToolStripMenuItem.CheckState = CheckState.Unchecked;
                portuguêsToolStripMenuItem.CheckState = CheckState.Checked;
                label11.Text = "Nome jogador1";
                label10.Text = "Nome jogador2";
            }
            else if (ling == 1)
            {
                jogoToolStripMenuItem.Text = "Game";
                novoJogoToolStripMenuItem.Text = "New game";
                riniciarToolStripMenuItem.Text = "Restart";
                sairToolStripMenuItem.Text = "Exit";
                temasToolStripMenuItem.Text = "Themes";
                fundoToolStripMenuItem.Text = "Background";
                tabuleiroToolStripMenuItem.Text = "Board";
                azulToolStripMenuItem.Text = "Blue";
                azulToolStripMenuItem1.Text = "Blue";
                brancoToolStripMenuItem.Text = "Black";
                brancoToolStripMenuItem1.Text = "Black";
                verdeToolStripMenuItem.Text = "Green";
                verdeToolStripMenuItem1.Text = "Green";
                amareloToolStripMenuItem.Text = "Yellow";
                amareloToolStripMenuItem1.Text = "Yellow";
                laranjaToolStripMenuItem.Text = "Orange";
                laranjaToolStripMenuItem1.Text = "Orange";
                rosaToolStripMenuItem.Text = "Pink";
                rosaToolStripMenuItem1.Text = "Pink";
                originalToolStripMenuItem.Text = "Original";
                originalToolStripMenuItem1.Text = "Original";
                linguagensToolStripMenuItem.Text = "Language";
                portuguêsToolStripMenuItem.Text = "Portugese";
                inglêsToolStripMenuItem.Text = "English";
                contraHumanoToolStripMenuItem.Text = "VS Humans";
                label4.Text = "TicTac Toe V 5.3 LP";
                inglêsToolStripMenuItem.CheckState = CheckState.Checked;
                portuguêsToolStripMenuItem.CheckState = CheckState.Unchecked;
                label11.Text = "Name player1";
                label10.Text = "Name player2";
            }
            if (jog == 0)
            {
                if (ling == 0)
                {
                    
                    label1.Text = jogador1 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador1 + " its your turn";
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = jogador2 + " é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = jogador2 + " its your turn";
                }
            }
            //tema fundo
            temaf = Settings.Default.thf;
            if (temaf == 0)
            {
                this.BackColor = Color.White;
                azulToolStripMenuItem.CheckState = CheckState.Unchecked;
                brancoToolStripMenuItem.CheckState = CheckState.Unchecked;
                verdeToolStripMenuItem.CheckState = CheckState.Unchecked;
                amareloToolStripMenuItem.CheckState = CheckState.Unchecked;
                laranjaToolStripMenuItem.CheckState = CheckState.Unchecked;
                rosaToolStripMenuItem.CheckState = CheckState.Unchecked;
                originalToolStripMenuItem.CheckState = CheckState.Checked;
            }
            else if (temaf == 1)
            {
                this.BackColor = Color.Aquamarine;
                azulToolStripMenuItem.CheckState = CheckState.Checked;
                brancoToolStripMenuItem.CheckState = CheckState.Unchecked;
                verdeToolStripMenuItem.CheckState = CheckState.Unchecked;
                amareloToolStripMenuItem.CheckState = CheckState.Unchecked;
                laranjaToolStripMenuItem.CheckState = CheckState.Unchecked;
                rosaToolStripMenuItem.CheckState = CheckState.Unchecked;
                originalToolStripMenuItem.CheckState = CheckState.Unchecked;
            }
            else if (temaf == 2)
            {
                this.BackColor = Color.Black;
                azulToolStripMenuItem.CheckState = CheckState.Unchecked;
                brancoToolStripMenuItem.CheckState = CheckState.Checked;
                verdeToolStripMenuItem.CheckState = CheckState.Unchecked;
                amareloToolStripMenuItem.CheckState = CheckState.Unchecked;
                laranjaToolStripMenuItem.CheckState = CheckState.Unchecked;
                rosaToolStripMenuItem.CheckState = CheckState.Unchecked;
                originalToolStripMenuItem.CheckState = CheckState.Unchecked;
            }
            else if (temaf == 3)
            {
                this.BackColor = Color.Green;
                azulToolStripMenuItem.CheckState = CheckState.Unchecked;
                brancoToolStripMenuItem.CheckState = CheckState.Unchecked;
                verdeToolStripMenuItem.CheckState = CheckState.Checked;
                amareloToolStripMenuItem.CheckState = CheckState.Unchecked;
                laranjaToolStripMenuItem.CheckState = CheckState.Unchecked;
                rosaToolStripMenuItem.CheckState = CheckState.Unchecked;
                originalToolStripMenuItem.CheckState = CheckState.Unchecked;
            }
            else if (temaf == 4)
            {
                this.BackColor = Color.Yellow;
                azulToolStripMenuItem.CheckState = CheckState.Unchecked;
                brancoToolStripMenuItem.CheckState = CheckState.Unchecked;
                verdeToolStripMenuItem.CheckState = CheckState.Unchecked;
                amareloToolStripMenuItem.CheckState = CheckState.Checked;
                laranjaToolStripMenuItem.CheckState = CheckState.Unchecked;
                rosaToolStripMenuItem.CheckState = CheckState.Unchecked;
                originalToolStripMenuItem.CheckState = CheckState.Unchecked;
            }
            else if (temaf == 5)
            {
                this.BackColor = Color.Orange;
                azulToolStripMenuItem.CheckState = CheckState.Unchecked;
                brancoToolStripMenuItem.CheckState = CheckState.Unchecked;
                verdeToolStripMenuItem.CheckState = CheckState.Unchecked;
                amareloToolStripMenuItem.CheckState = CheckState.Unchecked;
                laranjaToolStripMenuItem.CheckState = CheckState.Checked;
                rosaToolStripMenuItem.CheckState = CheckState.Unchecked;
                originalToolStripMenuItem.CheckState = CheckState.Unchecked;
            }
            else if (temaf == 6)
            {
                this.BackColor = Color.Pink;
                azulToolStripMenuItem.CheckState = CheckState.Unchecked;
                brancoToolStripMenuItem.CheckState = CheckState.Unchecked;
                verdeToolStripMenuItem.CheckState = CheckState.Unchecked;
                amareloToolStripMenuItem.CheckState = CheckState.Unchecked;
                laranjaToolStripMenuItem.CheckState = CheckState.Unchecked;
                rosaToolStripMenuItem.CheckState = CheckState.Checked;
                originalToolStripMenuItem.CheckState = CheckState.Unchecked;
            }
            //tema tabuleiro
            temat = Settings.Default.tht;
            if (temat == 0)
            {
                pictureBox1.BackColor = Color.Black;
                pictureBox2.BackColor = Color.Black;
                pictureBox3.BackColor = Color.Black;
                pictureBox4.BackColor = Color.Black;
                azulToolStripMenuItem1.CheckState = CheckState.Unchecked;
                rosaToolStripMenuItem1.CheckState = CheckState.Unchecked;
                originalToolStripMenuItem1.CheckState = CheckState.Checked;
                verdeToolStripMenuItem1.CheckState = CheckState.Unchecked;
                amareloToolStripMenuItem1.CheckState = CheckState.Unchecked;
                laranjaToolStripMenuItem1.CheckState = CheckState.Unchecked;
                brancoToolStripMenuItem1.CheckState = CheckState.Unchecked;
            }
            else if (temat == 1)
            {
                pictureBox1.BackColor = Color.Aquamarine;
                pictureBox2.BackColor = Color.Aquamarine;
                pictureBox3.BackColor = Color.Aquamarine;
                pictureBox4.BackColor = Color.Aquamarine;
                azulToolStripMenuItem1.CheckState = CheckState.Checked;
                rosaToolStripMenuItem1.CheckState = CheckState.Unchecked;
                originalToolStripMenuItem1.CheckState = CheckState.Unchecked;
                verdeToolStripMenuItem1.CheckState = CheckState.Unchecked;
                amareloToolStripMenuItem1.CheckState = CheckState.Unchecked;
                laranjaToolStripMenuItem1.CheckState = CheckState.Unchecked;
                brancoToolStripMenuItem1.CheckState = CheckState.Unchecked;
            }
            else if (temat == 2)
            {
                pictureBox1.BackColor = Color.Green;
                pictureBox2.BackColor = Color.Green;
                pictureBox3.BackColor = Color.Green;
                pictureBox4.BackColor = Color.Green;
                azulToolStripMenuItem1.CheckState = CheckState.Unchecked;
                rosaToolStripMenuItem1.CheckState = CheckState.Unchecked;
                originalToolStripMenuItem1.CheckState = CheckState.Unchecked;
                verdeToolStripMenuItem1.CheckState = CheckState.Checked;
                amareloToolStripMenuItem1.CheckState = CheckState.Unchecked;
                laranjaToolStripMenuItem1.CheckState = CheckState.Unchecked;
                brancoToolStripMenuItem1.CheckState = CheckState.Unchecked;
            }
            else if (temat == 3)
            {
                pictureBox1.BackColor = Color.Yellow;
                pictureBox2.BackColor = Color.Yellow;
                pictureBox3.BackColor = Color.Yellow;
                pictureBox4.BackColor = Color.Yellow;
                azulToolStripMenuItem1.CheckState = CheckState.Unchecked;
                rosaToolStripMenuItem1.CheckState = CheckState.Unchecked;
                originalToolStripMenuItem1.CheckState = CheckState.Unchecked;
                verdeToolStripMenuItem1.CheckState = CheckState.Unchecked;
                amareloToolStripMenuItem1.CheckState = CheckState.Checked;
                laranjaToolStripMenuItem1.CheckState = CheckState.Unchecked;
                brancoToolStripMenuItem1.CheckState = CheckState.Unchecked;
            }
            else if (temat == 4)
            {
                pictureBox1.BackColor = Color.Orange;
                pictureBox2.BackColor = Color.Orange;
                pictureBox3.BackColor = Color.Orange;
                pictureBox4.BackColor = Color.Orange;
                azulToolStripMenuItem1.CheckState = CheckState.Unchecked;
                rosaToolStripMenuItem1.CheckState = CheckState.Unchecked;
                originalToolStripMenuItem1.CheckState = CheckState.Unchecked;
                verdeToolStripMenuItem1.CheckState = CheckState.Unchecked;
                amareloToolStripMenuItem1.CheckState = CheckState.Unchecked;
                laranjaToolStripMenuItem1.CheckState = CheckState.Checked;
                brancoToolStripMenuItem1.CheckState = CheckState.Unchecked;
            }
            else if (temat == 5)
            {
                pictureBox1.BackColor = Color.Pink;
                pictureBox2.BackColor = Color.Pink;
                pictureBox3.BackColor = Color.Pink;
                pictureBox4.BackColor = Color.Pink;
                azulToolStripMenuItem1.CheckState = CheckState.Unchecked;
                rosaToolStripMenuItem1.CheckState = CheckState.Checked;
                originalToolStripMenuItem1.CheckState = CheckState.Unchecked;
                verdeToolStripMenuItem1.CheckState = CheckState.Unchecked;
                amareloToolStripMenuItem1.CheckState = CheckState.Unchecked;
                laranjaToolStripMenuItem1.CheckState = CheckState.Unchecked;
                brancoToolStripMenuItem1.CheckState = CheckState.Unchecked;
            }
            else if (temat == 6)
            {
                pictureBox1.BackColor = Color.White;
                pictureBox2.BackColor = Color.White;
                pictureBox3.BackColor = Color.White;
                pictureBox4.BackColor = Color.White;
                azulToolStripMenuItem1.CheckState = CheckState.Unchecked;
                rosaToolStripMenuItem1.CheckState = CheckState.Unchecked;
                originalToolStripMenuItem1.CheckState = CheckState.Unchecked;
                verdeToolStripMenuItem1.CheckState = CheckState.Unchecked;
                amareloToolStripMenuItem1.CheckState = CheckState.Unchecked;
                laranjaToolStripMenuItem1.CheckState = CheckState.Unchecked;
                brancoToolStripMenuItem1.CheckState = CheckState.Checked;
            }
        }

        private void contraHumanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //contra-humanos
            //Ainda não feito
            //para possivél junção a jogo contra o computador
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tema fundo azul
            temaf = 1;
            this.BackColor = Color.Aquamarine;
            azulToolStripMenuItem.CheckState = CheckState.Checked;
            brancoToolStripMenuItem.CheckState = CheckState.Unchecked;
            verdeToolStripMenuItem.CheckState = CheckState.Unchecked;
            amareloToolStripMenuItem.CheckState = CheckState.Unchecked;
            laranjaToolStripMenuItem.CheckState = CheckState.Unchecked;
            rosaToolStripMenuItem.CheckState = CheckState.Unchecked;
            originalToolStripMenuItem.CheckState = CheckState.Unchecked;
        }

        private void brancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tema fundo preto
            temaf = 2;
            this.BackColor = Color.Black;
            azulToolStripMenuItem.CheckState = CheckState.Unchecked;
            brancoToolStripMenuItem.CheckState = CheckState.Checked;
            verdeToolStripMenuItem.CheckState = CheckState.Unchecked;
            amareloToolStripMenuItem.CheckState = CheckState.Unchecked;
            laranjaToolStripMenuItem.CheckState = CheckState.Unchecked;
            rosaToolStripMenuItem.CheckState = CheckState.Unchecked;
            originalToolStripMenuItem.CheckState = CheckState.Unchecked;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tema fundo verde
            temaf = 3;
            this.BackColor = Color.Green;
            azulToolStripMenuItem.CheckState = CheckState.Unchecked;
            brancoToolStripMenuItem.CheckState = CheckState.Unchecked;
            verdeToolStripMenuItem.CheckState = CheckState.Checked;
            amareloToolStripMenuItem.CheckState = CheckState.Unchecked;
            laranjaToolStripMenuItem.CheckState = CheckState.Unchecked;
            rosaToolStripMenuItem.CheckState = CheckState.Unchecked;
            originalToolStripMenuItem.CheckState = CheckState.Unchecked;
        }

        private void amareloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tema fundo amarelo
            temaf = 4;
            this.BackColor = Color.Yellow;
            azulToolStripMenuItem.CheckState = CheckState.Unchecked;
            brancoToolStripMenuItem.CheckState = CheckState.Unchecked;
            verdeToolStripMenuItem.CheckState = CheckState.Unchecked;
            amareloToolStripMenuItem.CheckState = CheckState.Checked;
            laranjaToolStripMenuItem.CheckState = CheckState.Unchecked;
            rosaToolStripMenuItem.CheckState = CheckState.Unchecked;
            originalToolStripMenuItem.CheckState = CheckState.Unchecked;
        }

        private void laranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tema fundo laranja
            temaf = 5;
            this.BackColor = Color.Orange;
            azulToolStripMenuItem.CheckState = CheckState.Unchecked;
            brancoToolStripMenuItem.CheckState = CheckState.Unchecked;
            verdeToolStripMenuItem.CheckState = CheckState.Unchecked;
            amareloToolStripMenuItem.CheckState = CheckState.Unchecked;
            laranjaToolStripMenuItem.CheckState = CheckState.Checked;
            rosaToolStripMenuItem.CheckState = CheckState.Unchecked;
            originalToolStripMenuItem.CheckState = CheckState.Unchecked;
        }

        private void rosaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tema fundo rosa
            temaf = 6;
            this.BackColor = Color.Pink;
            azulToolStripMenuItem.CheckState = CheckState.Unchecked;
            brancoToolStripMenuItem.CheckState = CheckState.Unchecked;
            verdeToolStripMenuItem.CheckState = CheckState.Unchecked;
            amareloToolStripMenuItem.CheckState = CheckState.Unchecked;
            laranjaToolStripMenuItem.CheckState = CheckState.Unchecked;
            rosaToolStripMenuItem.CheckState = CheckState.Checked;
            originalToolStripMenuItem.CheckState = CheckState.Unchecked;
        }

        private void azulToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //tema tabuleiro azul
            temat = 1;
            pictureBox1.BackColor = Color.Aquamarine;
            pictureBox2.BackColor = Color.Aquamarine;
            pictureBox3.BackColor = Color.Aquamarine;
            pictureBox4.BackColor = Color.Aquamarine;
            azulToolStripMenuItem1.CheckState = CheckState.Checked;
            rosaToolStripMenuItem1.CheckState = CheckState.Unchecked;
            originalToolStripMenuItem1.CheckState = CheckState.Unchecked;
            verdeToolStripMenuItem1.CheckState = CheckState.Unchecked;
            amareloToolStripMenuItem1.CheckState = CheckState.Unchecked;
            laranjaToolStripMenuItem1.CheckState = CheckState.Unchecked;
            brancoToolStripMenuItem1.CheckState = CheckState.Unchecked;
        }

        private void originalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //tema tabuleiro original
            temat = 0;
            pictureBox1.BackColor = Color.Black;
            pictureBox2.BackColor = Color.Black;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BackColor = Color.Black;
            azulToolStripMenuItem1.CheckState = CheckState.Unchecked;
            rosaToolStripMenuItem1.CheckState = CheckState.Unchecked;
            originalToolStripMenuItem1.CheckState = CheckState.Checked;
            verdeToolStripMenuItem1.CheckState = CheckState.Unchecked;
            amareloToolStripMenuItem1.CheckState = CheckState.Unchecked;
            laranjaToolStripMenuItem1.CheckState = CheckState.Unchecked;
            brancoToolStripMenuItem1.CheckState = CheckState.Unchecked;
        }

        private void verdeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //tema tabuleiro verde
            temat = 2;
            pictureBox1.BackColor = Color.Green;
            pictureBox2.BackColor = Color.Green;
            pictureBox3.BackColor = Color.Green;
            pictureBox4.BackColor = Color.Green;
            azulToolStripMenuItem1.CheckState = CheckState.Unchecked;
            rosaToolStripMenuItem1.CheckState = CheckState.Unchecked;
            originalToolStripMenuItem1.CheckState = CheckState.Unchecked;
            verdeToolStripMenuItem1.CheckState = CheckState.Checked;
            amareloToolStripMenuItem1.CheckState = CheckState.Unchecked;
            laranjaToolStripMenuItem1.CheckState = CheckState.Unchecked;
            brancoToolStripMenuItem1.CheckState = CheckState.Unchecked;
        }

        private void amareloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //tema tabuleiro amarelo
            temat = 3;
            pictureBox1.BackColor = Color.Yellow;
            pictureBox2.BackColor = Color.Yellow;
            pictureBox3.BackColor = Color.Yellow;
            pictureBox4.BackColor = Color.Yellow;
            azulToolStripMenuItem1.CheckState = CheckState.Unchecked;
            rosaToolStripMenuItem1.CheckState = CheckState.Unchecked;
            originalToolStripMenuItem1.CheckState = CheckState.Unchecked;
            verdeToolStripMenuItem1.CheckState = CheckState.Unchecked;
            amareloToolStripMenuItem1.CheckState = CheckState.Checked;
            laranjaToolStripMenuItem1.CheckState = CheckState.Unchecked;
            brancoToolStripMenuItem1.CheckState = CheckState.Unchecked;
        }

        private void laranjaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //tema tabuleiro laranja
            temat = 4;
            pictureBox1.BackColor = Color.Orange;
            pictureBox2.BackColor = Color.Orange;
            pictureBox3.BackColor = Color.Orange;
            pictureBox4.BackColor = Color.Orange;
            azulToolStripMenuItem1.CheckState = CheckState.Unchecked;
            rosaToolStripMenuItem1.CheckState = CheckState.Unchecked;
            originalToolStripMenuItem1.CheckState = CheckState.Unchecked;
            verdeToolStripMenuItem1.CheckState = CheckState.Unchecked;
            amareloToolStripMenuItem1.CheckState = CheckState.Unchecked;
            laranjaToolStripMenuItem1.CheckState = CheckState.Checked;
            brancoToolStripMenuItem1.CheckState = CheckState.Unchecked;
        }

        private void rosaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //tema tabuleiro rosa
            temat = 5;
            pictureBox1.BackColor = Color.Pink;
            pictureBox2.BackColor = Color.Pink;
            pictureBox3.BackColor = Color.Pink;
            pictureBox4.BackColor = Color.Pink;
            azulToolStripMenuItem1.CheckState = CheckState.Unchecked;
            rosaToolStripMenuItem1.CheckState = CheckState.Checked;
            originalToolStripMenuItem1.CheckState = CheckState.Unchecked;
            verdeToolStripMenuItem1.CheckState = CheckState.Unchecked;
            amareloToolStripMenuItem1.CheckState = CheckState.Unchecked;
            laranjaToolStripMenuItem1.CheckState = CheckState.Unchecked;
            brancoToolStripMenuItem1.CheckState = CheckState.Unchecked;
        }

        private void brancoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //tema tabuleiro branco
            temat = 6;
            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.White;
            pictureBox4.BackColor = Color.White;
            azulToolStripMenuItem1.CheckState = CheckState.Unchecked;
            rosaToolStripMenuItem1.CheckState = CheckState.Unchecked;
            originalToolStripMenuItem1.CheckState = CheckState.Unchecked;
            verdeToolStripMenuItem1.CheckState = CheckState.Unchecked;
            amareloToolStripMenuItem1.CheckState = CheckState.Unchecked;
            laranjaToolStripMenuItem1.CheckState = CheckState.Unchecked;
            brancoToolStripMenuItem1.CheckState = CheckState.Checked;
        }

        private void v30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chagelog versão 3.0
            if (ling == 0)
            {
                MessageBox.Show("Versão 3.0\n-Temas a funcionar\n-Tradução smi-completa\n :)\n", "changelog");
            }
            else if (ling == 1)
            {
                MessageBox.Show("Version 3.0\n-Themes working\n-Traduction Smiley-complete\n :)\n", "changelog");
            }
        }

        private void portuguêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //linguagem português
            jogoToolStripMenuItem.Text = "Jogo";
            novoJogoToolStripMenuItem.Text = "Novo jogo";
            riniciarToolStripMenuItem.Text = "riniciar";
            sairToolStripMenuItem.Text = "Sair";
            temasToolStripMenuItem.Text = "Temas";
            fundoToolStripMenuItem.Text = "Fundo";
            tabuleiroToolStripMenuItem.Text = "Tabuleiro";
            azulToolStripMenuItem.Text = "Azul";
            azulToolStripMenuItem1.Text = "Azul";
            brancoToolStripMenuItem.Text = "Preto";
            brancoToolStripMenuItem1.Text = "Branco";
            verdeToolStripMenuItem.Text = "Verde";
            verdeToolStripMenuItem1.Text = "Verde";
            amareloToolStripMenuItem.Text = "Amarelo";
            amareloToolStripMenuItem1.Text = "Amarelo";
            laranjaToolStripMenuItem.Text = "LaranJa";
            laranjaToolStripMenuItem1.Text = "Laranja";
            rosaToolStripMenuItem.Text = "Rosa";
            rosaToolStripMenuItem1.Text = "Rosa";
            originalToolStripMenuItem.Text = "Original";
            originalToolStripMenuItem1.Text = "Original";
            linguagensToolStripMenuItem.Text = "Linguagem";
            portuguêsToolStripMenuItem.Text = "Português";
            inglêsToolStripMenuItem.Text = "Inglês";
            contraHumanoToolStripMenuItem.Text = "Contra Humanos";
            label4.Text = "Jogo do galo v 5.3 LP";
            inglêsToolStripMenuItem.CheckState = CheckState.Unchecked;
            portuguêsToolStripMenuItem.CheckState = CheckState.Checked;
            label11.Text = "Nome jogador1";
            label10.Text = "Nome jogador2";
            ling = 0;
            if (jog == 0)
            {
                label1.Text = jogador1+" é a sua vez";
            }
            else if (jog == 1)
            {
                label1.Text = jogador2+" é a sua vez";
            }
        }

        private void inglêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //linguagem Inglês
            jogoToolStripMenuItem.Text = "Game";
            novoJogoToolStripMenuItem.Text = "New game";
            riniciarToolStripMenuItem.Text = "Restart";
            sairToolStripMenuItem.Text = "Exit";
            temasToolStripMenuItem.Text = "Themes";
            fundoToolStripMenuItem.Text = "Background";
            tabuleiroToolStripMenuItem.Text = "Board";
            azulToolStripMenuItem.Text = "Blue";
            azulToolStripMenuItem1.Text = "Blue";
            brancoToolStripMenuItem.Text = "Black";
            brancoToolStripMenuItem1.Text = "Black";
            verdeToolStripMenuItem.Text = "Green";
            verdeToolStripMenuItem1.Text = "Green";
            amareloToolStripMenuItem.Text = "Yellow";
            amareloToolStripMenuItem1.Text = "Yellow";
            laranjaToolStripMenuItem.Text = "Orange";
            laranjaToolStripMenuItem1.Text = "Orange";
            rosaToolStripMenuItem.Text = "Pink";
            rosaToolStripMenuItem1.Text = "Pink";
            originalToolStripMenuItem.Text = "Original";
            originalToolStripMenuItem1.Text = "Original";
            linguagensToolStripMenuItem.Text = "Language";
            portuguêsToolStripMenuItem.Text = "Portugese";
            inglêsToolStripMenuItem.Text = "English";
            contraHumanoToolStripMenuItem.Text = "VS Humans";
            label4.Text = "TicTac Toe V 5.3 LP";
            inglêsToolStripMenuItem.CheckState = CheckState.Checked;
            portuguêsToolStripMenuItem.CheckState = CheckState.Unchecked;
            label11.Text = "Name player1";
            label10.Text = "Name player2";
            ling = 1;
            if (jog == 0)
            {
              label1.Text = jogador1+" its your turn";  
            }
            else if (jog == 1)
            {
              label1.Text = jogador2+" its your turn";
            }
        }

        private void v40ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //changelog versão 4.0
            if (ling == 0)
            {
                MessageBox.Show("Versão 4.0\n-Tradução a 99%\n-Jogo guarda processo se nao houver vencedor\n :)\n", "changelog");
            }
            else if (ling == 1)
            {
                MessageBox.Show("Version 4.0\n-About 99% of taduction\n-Game save process if nobody win\n :)\n", "changelog");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //botão fechar
            if (ling == 0)
            {
                DialogResult saida = MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (saida == DialogResult.Yes)
                {
                    if (venc == 0)
                    {
                        Settings.Default.simg1 = img1;
                        Settings.Default.simg2 = img2;
                        Settings.Default["ss"] = 1;
                        Settings.Default["btn1"] = button1.Text;
                        Settings.Default["btn2"] = button2.Text;
                        Settings.Default["btn3"] = button3.Text;
                        Settings.Default["btn4"] = button4.Text;
                        Settings.Default["btn5"] = button5.Text;
                        Settings.Default["btn6"] = button6.Text;
                        Settings.Default["btn7"] = button7.Text;
                        Settings.Default["btn8"] = button8.Text;
                        Settings.Default["btn9"] = button9.Text;
                        Settings.Default["svenc"] = venc;
                        Settings.Default["sjog"] = jog;
                        Settings.Default["btn1e"] = button1.Enabled.ToString();
                        Settings.Default["btn2e"] = button2.Enabled.ToString();
                        Settings.Default["btn3e"] = button3.Enabled.ToString();
                        Settings.Default["btn4e"] = button4.Enabled.ToString();
                        Settings.Default["btn5e"] = button5.Enabled.ToString();
                        Settings.Default["btn6e"] = button6.Enabled.ToString();
                        Settings.Default["btn7e"] = button7.Enabled.ToString();
                        Settings.Default["btn8e"] = button8.Enabled.ToString();
                        Settings.Default["btn9e"] = button9.Enabled.ToString();
                        Settings.Default["thf"] = temaf;
                        Settings.Default["tht"] = temat;
                        Settings.Default["contjog"] = cont;
                        Settings.Default["sling"] = ling;
                        Settings.Default["nomjog1"] = jogador1;
                        Settings.Default["nomjog2"] = jogador2;
                        Settings.Default["tb1e"] = textBox1.Enabled.ToString();
                        Settings.Default["tb2e"] = textBox2.Enabled.ToString();
                        Settings.Default["ssec"] = sec;
                        Settings.Default["smin"] = min;
                        Settings.Default.Save();
                        Application.Exit();
                    }
                    else if (venc == 1)
                    {
                        Settings.Default.simg1 = 0;
                        Settings.Default.simg2 = 0;
                        Settings.Default["ss"] = 0;
                        Settings.Default["btn1"] = "";
                        Settings.Default["btn2"] = "";
                        Settings.Default["btn3"] = "";
                        Settings.Default["btn4"] = "";
                        Settings.Default["btn5"] = "";
                        Settings.Default["btn6"] = "";
                        Settings.Default["btn7"] = "";
                        Settings.Default["btn8"] = "";
                        Settings.Default["btn9"] = "";
                        Settings.Default["svenc"] = 0;
                        Settings.Default["sjog"] = jog;
                        Settings.Default["btn1e"] = "";
                        Settings.Default["btn2e"] = "";
                        Settings.Default["btn3e"] = "";
                        Settings.Default["btn4e"] = "";
                        Settings.Default["btn5e"] = "";
                        Settings.Default["btn6e"] = "";
                        Settings.Default["btn7e"] = "";
                        Settings.Default["btn8e"] = "";
                        Settings.Default["btn9e"] = "";
                        Settings.Default["thf"] = temaf;
                        Settings.Default["tht"] = temat;
                        Settings.Default["contjog"] = 0;
                        Settings.Default["sling"] = ling;
                        Settings.Default["nomjog1"] = "";
                        Settings.Default["nomjog2"] = "";
                        Settings.Default["tb1e"] = "";
                        Settings.Default["tb2e"] = "";
                        Settings.Default["nomjog1"] = "Jogador1";
                        Settings.Default["nomjog2"] = "Jogador2";
                        Settings.Default["ssec"] = 0;
                        Settings.Default["smin"] = 0;
                        Settings.Default.Save();
                        Application.Exit();
                    }
                }
                else
                {

                }
            }
            if (ling == 1)
            {
                MessageBoxManager.OK = "Yeas";
                MessageBoxManager.Cancel = "No";
                MessageBoxManager.Register();
                DialogResult saida = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                MessageBoxManager.Unregister();
                if (saida == DialogResult.OK)
                {
                    if (venc == 0)
                    {
                        Settings.Default.simg1 = img1;
                        Settings.Default.simg2 = img2;
                        Settings.Default["ss"] = 1;
                        Settings.Default["btn1"] = button1.Text;
                        Settings.Default["btn2"] = button2.Text;
                        Settings.Default["btn3"] = button3.Text;
                        Settings.Default["btn4"] = button4.Text;
                        Settings.Default["btn5"] = button5.Text;
                        Settings.Default["btn6"] = button6.Text;
                        Settings.Default["btn7"] = button7.Text;
                        Settings.Default["btn8"] = button8.Text;
                        Settings.Default["btn9"] = button9.Text;
                        Settings.Default["svenc"] = venc;
                        Settings.Default["sjog"] = jog;
                        Settings.Default["btn1e"] = button1.Enabled.ToString();
                        Settings.Default["btn2e"] = button2.Enabled.ToString();
                        Settings.Default["btn3e"] = button3.Enabled.ToString();
                        Settings.Default["btn4e"] = button4.Enabled.ToString();
                        Settings.Default["btn5e"] = button5.Enabled.ToString();
                        Settings.Default["btn6e"] = button6.Enabled.ToString();
                        Settings.Default["btn7e"] = button7.Enabled.ToString();
                        Settings.Default["btn8e"] = button8.Enabled.ToString();
                        Settings.Default["btn9e"] = button9.Enabled.ToString();
                        Settings.Default["thf"] = temaf;
                        Settings.Default["tht"] = temat;
                        Settings.Default["contjog"] = cont;
                        Settings.Default["sling"] = ling;
                        Settings.Default["nomjog1"] = jogador1;
                        Settings.Default["nomjog2"] = jogador2;
                        Settings.Default["tb1e"] = textBox1.Enabled.ToString();
                        Settings.Default["tb2e"] = textBox2.Enabled.ToString();
                        Settings.Default["ssec"] = sec;
                        Settings.Default["smin"] = min;
                        Settings.Default.Save();
                        Application.Exit();
                    }
                    else if (venc == 1)
                    {
                        Settings.Default.simg1 = 0;
                        Settings.Default.simg2 = 0;
                        Settings.Default["ss"] = 0;
                        Settings.Default["btn1"] = "";
                        Settings.Default["btn2"] = "";
                        Settings.Default["btn3"] = "";
                        Settings.Default["btn4"] = "";
                        Settings.Default["btn5"] = "";
                        Settings.Default["btn6"] = "";
                        Settings.Default["btn7"] = "";
                        Settings.Default["btn8"] = "";
                        Settings.Default["btn9"] = "";
                        Settings.Default["svenc"] = 0;
                        Settings.Default["sjog"] = jog;
                        Settings.Default["btn1e"] = "";
                        Settings.Default["btn2e"] = "";
                        Settings.Default["btn3e"] = "";
                        Settings.Default["btn4e"] = "";
                        Settings.Default["btn5e"] = "";
                        Settings.Default["btn6e"] = "";
                        Settings.Default["btn7e"] = "";
                        Settings.Default["btn8e"] = "";
                        Settings.Default["btn9e"] = "";
                        Settings.Default["thf"] = temaf;
                        Settings.Default["tht"] = temat;
                        Settings.Default["contjog"] = 0;
                        Settings.Default["sling"] = ling;
                        Settings.Default["nomjog1"] = "";
                        Settings.Default["nomjog2"] = "";
                        Settings.Default["tb1e"] = "";
                        Settings.Default["tb2e"] = "";
                        Settings.Default["nomjog1"] = "Jogador1";
                        Settings.Default["nomjog2"] = "Jogador2";
                        Settings.Default["ssec"] = 0;
                        Settings.Default["smin"] = 0;
                        Settings.Default.Save();
                        Application.Exit();
                    }
                }
                else
                {

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //butão minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void originalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tema fundo original
            temaf = 0;
            this.BackColor = Color.White;
            azulToolStripMenuItem.CheckState = CheckState.Unchecked;
            brancoToolStripMenuItem.CheckState = CheckState.Unchecked;
            verdeToolStripMenuItem.CheckState = CheckState.Unchecked;
            amareloToolStripMenuItem.CheckState = CheckState.Unchecked;
            laranjaToolStripMenuItem.CheckState = CheckState.Unchecked;
            rosaToolStripMenuItem.CheckState = CheckState.Unchecked;
            originalToolStripMenuItem.CheckState = CheckState.Checked;
        }

        private void label3_Enter(object sender, EventArgs e)
        {
            label3.BackColor = Color.Blue;
        }

        private void label3_Leave(object sender, EventArgs e)
        {
            label3.BackColor = Color.Transparent;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            //efeito hover no butao minimizar
            label3.BackColor = Color.Cyan;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            //efeito mouse leave no butao minimizar
            label3.BackColor = Color.Transparent;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            //efeito hover no butão fechar
            label2.BackColor = Color.OrangeRed;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            //efeito mouse leave no butão fechar
            label2.BackColor = Color.Transparent;
        }

        private void v50502ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //changelog versão 5.0/5.0.2
            if (ling == 0)
            {
                MessageBox.Show("Versão 5.0/5.0.2\n-Tradução a 100%\n-Novo Design\n-Jogo guarda o tema escolhido\n :)\n", "changelog");
            }
            else if (ling == 1)
            {
                MessageBox.Show("Version 5.0/5.0.2\n- 100% of taduction\n-New Design\n-Game save the picked out theme\n :)\n", "changelog");
            }
        }

        private void v51511ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //changelog da versão 5.1/5.1.1

            if (ling == 0)
            {
                MessageBox.Show("Versão 5.1/5.1.1\n- Correcão de alguns bugs\n- Jogo guarda a linguagem escolhida\n :)\n", "changelog");
            }
            else if (ling == 1)
            {
                MessageBox.Show("Version 5.1/5.1.1\n- Correction of bugs\n- Game save the picked out Language\n :)\n", "changelog");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //temporizador
            sec = sec + 1;
            label8.Text = Convert.ToString(sec);
            if (sec == 60)
            {
                sec = 0;
                label8.Text = Convert.ToString(sec);
                min = min + 1;
                label6.Text = Convert.ToString(min);
            }
        }

        private void v512ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //changelog da versão 5.1.2

            if (ling == 0)
            {
                MessageBox.Show("Versão 5.1.2\n- Correcão de alguns bugs\n- Agora já pode ser introduzido nomes\n- Adicionado temporizador(minutos/segindos)\n :)\n", "changelog");
            }
            else if (ling == 1)
            {
                MessageBox.Show("Version 5.1.2\n- Correction of bugs\n- now you can put names\n- Added timer(minutes/seconds)\n :)\n", "changelog");
            }
        }

        private void v513ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //changelog da versão 5.1.3
            if (ling == 0)
            {
                MessageBox.Show("Versão 5.1.3\n- Correcão de alguns bugs\n- nomes e temporizador também são guardados\n :)\n", "changelog");
            }
            else if (ling == 1)
            {
                MessageBox.Show("Version 5.1.3\n- Correction of bugs\n- names and timer also are saved\n :)\n", "changelog");
            }
        }

        private void v52ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //changelog da versão 5.2
            if (ling == 0)
            {
                MessageBox.Show("Versão 5.2\n- Correcão de alguns bugs\n- jogo agora pergunta se pretende carregar o ultimo jogo guardado\n :)\n", "changelog");
            }
            else if (ling == 1)
            {
                MessageBox.Show("Version 5.2\n- Correction of bugs\n- game now ask if you want to load the last saved game progress\n :)\n", "changelog");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //butao escolher imagem jogador 1
            string localimagem;
            string jog1;
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "JPG files(*.jpg)|*.jpg|All Files (*.*)|*.*";


            if (dlg.ShowDialog() == DialogResult.OK)
            {
                localimagem = dlg.FileName.ToString();
                pictureBox5.ImageLocation = localimagem;
                pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                if (!Directory.Exists("C:/Users/" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "/Documents/jogogalo/imagens"))
                {
                    Directory.CreateDirectory("C:/Users/" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "/Documents/jogogalo/imagens");
                }
                jog1 = "C:/Users/" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "/Documents/jogogalo/imagens/jog1.jpg";
                if (File.Exists(jog1))
                {
                    System.IO.File.Delete(jog1);
                    System.IO.File.Copy(dlg.FileName, "C:/Users/" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "/Documents/jogogalo/imagens/jog1.jpg");
                }
                else
                {
                    System.IO.File.Copy(dlg.FileName, "C:/Users/" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "/Documents/jogogalo/imagens/jog1.jpg");
                }
            }
            button10.Enabled = false;
            img1 = 1;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //butao escolher imagem jogador 2
            string localimagem;
            string jog2;
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "JPG files(*.jpg)|*.jpg|All Files (*.*)|*.*";


            if (dlg.ShowDialog() == DialogResult.OK)
            {
                localimagem = dlg.FileName.ToString();
                pictureBox6.ImageLocation = localimagem;
                pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                if (!Directory.Exists("C:/Users/"+System.Security.Principal.WindowsIdentity.GetCurrent().Name+"/Documents/jogogalo/imagens"))
                {
                    Directory.CreateDirectory("C:/Users/" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "/Documents/jogogalo/imagens");
                }
                jog2 = "C:/Users/" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "/Documents/jogogalo/imagens/jog2.jpg";
                if (File.Exists(jog2))
                {
                    System.IO.File.Delete(jog2);
                    System.IO.File.Copy(dlg.FileName, "C:/Users/" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "/Documents/jogogalo/imagens/jog2.jpg");
                }
                else
                {
                    System.IO.File.Copy(dlg.FileName, "C:/Users/" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "/Documents/jogogalo/imagens/jog2.jpg");
                }
            }
            button11.Enabled = false;
            img2 = 1;
        }

        private void v53ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //changelog da versão 5.3
            if (ling == 0)
            {
                MessageBox.Show("Versão 5.3\n- Correcão de alguns bugs\n- jogo agora permite escolher imagens para ambos os jogadores (ainda nao guarda as imagens)\n :)\n", "changelog");
            }
            else if (ling == 1)
            {
                MessageBox.Show("Version 5.3\n- Correction of bugs\n-now you can chose images for players (but not saving images for now)\n :)\n", "changelog");
            }
        }
    }
}
