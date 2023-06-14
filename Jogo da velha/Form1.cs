using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_velha
{
    public partial class Form1 : Form
    {

        string jogador = "X";
        public Form1()
        {
            InitializeComponent();
            tx_resultado.Text = " ";
        }

        private void DesButton()
        {
            if (tx_resultado.Text != " ")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (jogador == "X")
            {
                button1.Text = jogador;
                jogador = "O";
            }
            else
            {
                button1.Text = jogador;
                jogador = "X";
            }
            JogoDaVelha j = new JogoDaVelha(button1.Text.ToLower(), button2.Text.ToLower(), button3.Text.ToLower(), button4.Text.ToLower(), button5.Text.ToLower(), button6.Text.ToLower(), button7.Text.ToLower(), button8.Text.ToLower(), button9.Text.ToLower());
            string qq = j.Jogada();            
            tx_resultado.Text = qq;
            tx_jogador.Text = "Vez do jogador "+jogador;
            button1.Enabled = false;
            
            this.DesButton();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (jogador == "X")
            {
                button2.Text = jogador;
                jogador = "O";
            }
            else
            {
                button2.Text = jogador;
                jogador = "X";
            }
            JogoDaVelha j = new JogoDaVelha(button1.Text.ToLower(), button2.Text.ToLower(), button3.Text.ToLower(), button4.Text.ToLower(), button5.Text.ToLower(), button6.Text.ToLower(), button7.Text.ToLower(), button8.Text.ToLower(), button9.Text.ToLower());
            string qq = j.Jogada();
            tx_resultado.Text = qq;
            tx_jogador.Text = "Vez do jogador " + jogador;
            button2.Enabled = false;
            this.DesButton();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (jogador == "X")
            {
                button8.Text = jogador;
                jogador = "O";
            }
            else
            {
                button8.Text = jogador;
                jogador = "X";
            }
            JogoDaVelha j = new JogoDaVelha(button1.Text.ToLower(), button2.Text.ToLower(), button3.Text.ToLower(), button4.Text.ToLower(), button5.Text.ToLower(), button6.Text.ToLower(), button7.Text.ToLower(), button8.Text.ToLower(), button9.Text.ToLower());
            string qq = j.Jogada();
            tx_resultado.Text = qq;
            tx_jogador.Text = "Vez do jogador " + jogador;
            button8.Enabled = false;
            this.DesButton();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (jogador == "X")
            {
                button3.Text = jogador;
                jogador = "O";
            }
            else
            {
                button3.Text = jogador;
                jogador = "X";
            }
            JogoDaVelha j = new JogoDaVelha(button1.Text.ToLower(), button2.Text.ToLower(), button3.Text.ToLower(), button4.Text.ToLower(), button5.Text.ToLower(), button6.Text.ToLower(), button7.Text.ToLower(), button8.Text.ToLower(), button9.Text.ToLower());
            string qq = j.Jogada();
            tx_resultado.Text = qq;
            tx_jogador.Text = "Vez do jogador " + jogador;
            button3.Enabled = false;
            this.DesButton();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (jogador == "X")
            {
                button4.Text = jogador;
                jogador = "O";
            }
            else
            {
                button4.Text = jogador;
                jogador = "X";
            }
            JogoDaVelha j = new JogoDaVelha(button1.Text.ToLower(), button2.Text.ToLower(), button3.Text.ToLower(), button4.Text.ToLower(), button5.Text.ToLower(), button6.Text.ToLower(), button7.Text.ToLower(), button8.Text.ToLower(), button9.Text.ToLower());
            string qq = j.Jogada();
            tx_resultado.Text = qq;
            tx_jogador.Text = "Vez do jogador " + jogador;
            button4.Enabled = false;
            this.DesButton();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (jogador == "X")
            {
                button5.Text = jogador;
                jogador = "O";
            }
            else
            {
                button5.Text = jogador;
                jogador = "X";
            }
            JogoDaVelha j = new JogoDaVelha(button1.Text.ToLower(), button2.Text.ToLower(), button3.Text.ToLower(), button4.Text.ToLower(), button5.Text.ToLower(), button6.Text.ToLower(), button7.Text.ToLower(), button8.Text.ToLower(), button9.Text.ToLower());
            string qq = j.Jogada();
            tx_resultado.Text = qq;
            tx_jogador.Text = "Vez do jogador " + jogador;
            button5.Enabled = false;
            this.DesButton();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (jogador == "X")
            {
                button6.Text = jogador;
                jogador = "O";
            }
            else
            {
                button6.Text = jogador;
                jogador = "X";
            }
            JogoDaVelha j = new JogoDaVelha(button1.Text.ToLower(), button2.Text.ToLower(), button3.Text.ToLower(), button4.Text.ToLower(), button5.Text.ToLower(), button6.Text.ToLower(), button7.Text.ToLower(), button8.Text.ToLower(), button9.Text.ToLower());
            string qq = j.Jogada();
            tx_resultado.Text = qq;
            tx_jogador.Text = "Vez do jogador " + jogador;
            button6.Enabled = false;
            this.DesButton();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (jogador == "X")
            {
                button7.Text = jogador;
                jogador = "O";
            }
            else
            {
                button7.Text = jogador;
                jogador = "X";
            }
            JogoDaVelha j = new JogoDaVelha(button1.Text.ToLower(), button2.Text.ToLower(), button3.Text.ToLower(), button4.Text.ToLower(), button5.Text.ToLower(), button6.Text.ToLower(), button7.Text.ToLower(), button8.Text.ToLower(), button9.Text.ToLower());
            string qq = j.Jogada();
            tx_resultado.Text = qq;
            tx_jogador.Text = "Vez do jogador " + jogador;
            button7.Enabled = false;
            this.DesButton();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (jogador == "X")
            {
                button9.Text = jogador;
                jogador = "O";
            }
            else
            {
                button9.Text = jogador;
                jogador = "X";
            }
            JogoDaVelha j = new JogoDaVelha(button1.Text.ToLower(), button2.Text.ToLower(), button3.Text.ToLower(), button4.Text.ToLower(), button5.Text.ToLower(), button6.Text.ToLower(), button7.Text.ToLower(), button8.Text.ToLower(), button9.Text.ToLower());
            string qq = j.Jogada();
            tx_resultado.Text = qq;
            tx_jogador.Text = "Vez do jogador " + jogador;
            button9.Enabled = false;      
            this.DesButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tx_resultado_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
                //tx_jogador.Text = "Vez de jogador X";
                tx_resultado.Text = " ";
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;
            
        }
    }
}

