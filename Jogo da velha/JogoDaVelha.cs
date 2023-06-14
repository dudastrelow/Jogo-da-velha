using System;
public class JogoDaVelha
{

    public string a;
    public string b;    
    public string c;
    public string d;
    public string e;
    public string f;
    public string g;
    public string h;
    public string i;

    public JogoDaVelha(string a, string b, string c, string d, string e, string f, string g, string h, string i)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
        this.e = e;
        this.f = f;
        this.g = g;
        this.h = h;
        this.i = i;
    }

    public string Jogador(string jogador)
    {
        /*if ((a != " ") || (b != " ") || (c != " ") ||
            (d != " ") || (e != " ") || (f != " ") ||
            (g != " ") || (h != " ") || (i != " "))
        {
            jogador++;
        }
        if (jogador % 2 != 0)
        {
            return "Vez de jogador O";
        }
        else
        {
            return "Vez de jopgador X";
        }*/
        if(jogador == "x")
        {
            return "Vez de jogador O";
        }
        if(jogador == "o")
        {
            return "Vez de jogador X";
        }
        else
        {
            return "erro";
        }
    }
    public string Jogada()
    {
        if ((a == b && b == c && c == "x") ||
            (a == d && d == g && g == "x") ||
            (g == h && h == i && i == "x") ||
            (i == f && f == c && c == "x") ||
            (a == e && e == i && i == "x") ||
            (c == e && e == g && g == "x") ||
            (b == e && e == h && h == "x") ||
            (d == e && e == f && f == "x"))
        {
            return "O jogador X ganhou";
        }

        else if ((a == b && b == c && c == "o") ||
            (a == d && d == g && g == "o") ||
            (g == h && h == i && i == "o") ||
            (i == f && f == c && c == "o") ||
            (a == e && e == i && i == "o") ||
            (c == e && e == g && g == "o") ||
            (b == e && e == h && h == "o") ||
            (d == e && e == f && f == "o"))
        {
            return "O jogador O ganhou";
        }
        if( (a == "x" || a == "o") &&
            (b == "x" || b == "o") &&
            (c == "x" || c == "o") &&
            (d == "x" || d == "o") &&
            (e == "x" || e == "o") &&
            (f == "x" || f == "o") &&
            (g == "x" || g == "o") &&
            (h == "x" || h == "o") &&
            (i == "x" || i == "o") )
        {
            return "Deu velha";
        }
        else 
        {
            return " ";
        }
    }
    //((a != " ") || (b != " ") || (c != " ") ||
    //(d != " ") || (e != " ") || (f != " ") ||
    //(g != " ") || (h != " ") || (i != " "))

    /*jogador = 0;
        if (a != " ")
        {
            jogador++;
        }

        if (b != " ")
        {
            jogador++;
        }
        if (c != " ")
        {
            jogador++;
        }
        if (d != " ")
        {
            jogador++;
        }
        if (e != " ")
        {
            jogador++;
        }
        if (f != " ")
        {
            jogador++;
        }
        if (g != " ")
        {
            jogador++;
        }
        if (h != " ")
        {
            jogador++;
        }
        if (i != " ")
        {
            jogador++;
        }
        if (jogador % 2 != 0)
        {
            return "Vez de jogador O";
        }
        else
        {
            return "Vez de jopgador X";
        }
    public string VezDoJogador()
    {
        if (this.jogadas % 2 == 0)
        {
            return "x";
        }
        else
        {
            return "o";
        }
    }*/
}