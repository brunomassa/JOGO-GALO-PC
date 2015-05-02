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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //butao casa numro 1
            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 2 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 2 its your turn";
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
                        MessageBox.Show("Jogador 1 Ganha!!!!","Vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!","Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!","Vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!","Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!","vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!","Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                    MessageBox.Show("Empate!!!!","Empate");
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 1 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 1 its your turn";
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                    MessageBox.Show("Empate!!!!", "Empate");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //butao casa numero 2
            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 2 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 2 its your turn";
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                    MessageBox.Show("Empate!!!!","Empate");
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 1 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 1 its your turn";
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                    MessageBox.Show("Empate!!!!","Empate");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //butao casa numero 3
            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 2 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 2 its your turn";
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                    MessageBox.Show("Empate!!!!", "Empate");
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 1 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 1 its your turn";
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                    MessageBox.Show("Empate!!!!", "Empate");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //butao casa numero 4
            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 2 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 2 its your turn";
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                    MessageBox.Show("Empate!!!!", "Empate");
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 1 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 1 its your turn";
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                    MessageBox.Show("Empate!!!!", "Empate");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //butao casa numero 5
            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 2 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 2 its your turn";
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                    MessageBox.Show("Empate!!!!", "Empate");
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 1 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 1 its your turn";
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                    MessageBox.Show("Empate!!!!", "Empate");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //butao casa numero 6
            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 2 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 2 its your turn";
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                    MessageBox.Show("Empate!!!!", "Empate");
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 1 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 1 its your turn";
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                    MessageBox.Show("Empate!!!!", "Empate");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //butao casa numero 7
            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 2 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 2 its your turn";
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                    MessageBox.Show("Empate!!!!", "Empate");
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 1 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 1 its your turn";
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                    MessageBox.Show("Empate!!!!", "Empate");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //butao casa numero 8
            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 2 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 2 its your turn";
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                    MessageBox.Show("Empate!!!!", "Empate");
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 1 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 1 its your turn";
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                    MessageBox.Show("Empate!!!!", "Empate");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //butao casa numero 9
            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 2 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 2 its your turn";
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 1 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 1 win!!!!", "Winner");
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
                    MessageBox.Show("Empate!!!!", "Empate");
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 1 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 1 its your turn";
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                        MessageBox.Show("Jogador 2 Ganha!!!!", "vencedor");
                    }
                    else if (ling == 1)
                    {
                        MessageBox.Show("Player 2 win!!!!", "Winner");
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
                    MessageBox.Show("Empate!!!!", "Empate");
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

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            cont = 0;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menu opção sair
            if (ling == 0)
            {
                DialogResult saida = MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo);
                if (saida == DialogResult.Yes)
                {
                    if (venc == 0)
                    {
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
                        Settings.Default.Save();
                        Application.Exit();
                    }
                    else if (venc == 1)
                    {
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
                DialogResult saida = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel);
                MessageBoxManager.Unregister();
                if (saida == DialogResult.OK)
                {
                    if (venc == 0)
                    {
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
                        Settings.Default.Save();
                        Application.Exit();
                    }
                    else if (venc == 1)
                    {
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
            contraHumanoToolStripMenuItem.CheckState = CheckState.Checked;
            portuguêsToolStripMenuItem.CheckState = CheckState.Checked;
            originalToolStripMenuItem.CheckState = CheckState.Checked;
            originalToolStripMenuItem1.CheckState = CheckState.Checked;
            button1.Text = Settings.Default.btn1;
            button2.Text = Settings.Default.btn2;
            button3.Text = Settings.Default.btn3;
            button4.Text = Settings.Default.btn4;
            button5.Text = Settings.Default.btn5;
            button6.Text = Settings.Default.btn6;
            button7.Text = Settings.Default.btn7;
            button8.Text = Settings.Default.btn8;
            button9.Text = Settings.Default.btn9;
            //condições para ajustar o jogo ao processo guardado
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
            if (jog == 0)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 1 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 1 its your turn";
                }
            }
            else if (jog == 1)
            {
                if (ling == 0)
                {
                    label1.Text = "Jogador 2 é a sua vez";
                }
                else if (ling == 1)
                {
                    label1.Text = "Player 2 its your turn";
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
            label4.Text = "Jogo do galo v 5.0.2 LP";
            inglêsToolStripMenuItem.CheckState = CheckState.Unchecked;
            portuguêsToolStripMenuItem.CheckState = CheckState.Checked;
            ling = 0;
            if (jog == 0)
            {
                label1.Text = "Jogador 1 é a sua vez";
            }
            else if (jog == 1)
            {
                label1.Text = "Jogador 2 é a sua vez";
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
            label4.Text = "TicTac Toe V 5.0.2 LP";
            inglêsToolStripMenuItem.CheckState = CheckState.Checked;
            portuguêsToolStripMenuItem.CheckState = CheckState.Unchecked;
            ling = 1;
            if (jog == 0)
            {
              label1.Text = "Player 1 its your turn";  
            }
            else if (jog == 1)
            {
              label1.Text = "Player 2 its your turn";
            }
        }

        private void v40ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //changelog versão 4.0
            if (ling == 0)
            {
                MessageBox.Show("Versão 4.0\n-Tradução a 99%\n-Jogo guarda processo se nao ouver vencedor\n :)\n", "changelog");
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
                DialogResult saida = MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo);
                if (saida == DialogResult.Yes)
                {
                    if (venc == 0)
                    {
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
                        Settings.Default.Save();
                        Application.Exit();
                    }
                    else if (venc == 1)
                    {
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
                        Settings.Default["contjog"] = cont;
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
                DialogResult saida = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel);
                MessageBoxManager.Unregister();
                if (saida == DialogResult.OK)
                {
                    if (venc == 0)
                    {
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
                        Settings.Default.Save();
                        Application.Exit();
                    }
                    else if (venc == 1)
                    {
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
                        Settings.Default["contjog"] = cont;
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
    }
}
