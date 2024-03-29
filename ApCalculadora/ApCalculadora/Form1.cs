﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApCalculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private bool IsOperacao(string aux)
        {
            if (aux == "+" || aux == "-" || aux == "/" || aux == "*" || aux == "^" || aux == "(" || aux == ")")
                return true;

            return false;
        }

        private bool TemPrecedencia(char topo, char operacao)
        {
            switch (topo)
            {
                case '+':
                case '-':
                    if (operacao == '+' || operacao == '-' || operacao == ')')
                        return true;
                    break;

                case '*':
                case '/':
                case '^':
                    if (operacao == '+' || operacao == '-' || operacao == '*' || operacao == '/' || operacao == ')')
                        return true;
                    break;

                case '(':
                    if (operacao == ')')
                        return true;
                    break;

            }

            return false;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            txtResultado.Text = "";
            lbSequencias.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lbSequencias.Text = "";
            Button clicked = (Button)sender;
            txtVisor.Text += clicked.Text;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            FilaLista<string> sequenciaInfixa = new FilaLista<string>();
            FilaLista<string> sequenciaPosfixa = new FilaLista<string>();
            PilhaLista<string> operacoes = new PilhaLista<string>();

            string sequencia = txtVisor.Text;

            for (int s = 0; s < sequencia.Length; s++)
            {
                string item = "";

                if (IsOperacao(sequencia[s].ToString()))
                {
                    item = "";
                    int posicao = s;

                    while (posicao + item.Length < sequencia.Length &&
                           (!IsOperacao(sequencia[posicao + item.Length].ToString()) ||
                           sequencia[posicao + item.Length] == '.'))
                        item += sequencia[posicao + item.Length];

                    s = posicao + item.Length - 1;
                    sequenciaPosfixa.Enfileirar(item);
                }
                else
                {
                    item = sequencia[s] + "";

                    while (!operacoes.EstaVazia() && TemPrecedencia(operacoes.OTopo()[0], item[0]))
                    {
                        char operador = operacoes.OTopo()[0];

                        if (operador == '(')
                            break;
                        else
                        {
                            sequenciaPosfixa.Enfileirar(operador + "");
                            operacoes.Desempilhar();
                        }
                    }

                    if (item != ")")
                        operacoes.Empilhar(item);
                    else
                        operacoes.Desempilhar();
                }

                if (item != "(" && item != ")")
                    sequenciaInfixa.Enfileirar(item);
            }

            while (!operacoes.EstaVazia())
            {
                string operador = operacoes.Desempilhar();

                if (operador != ")" && operador != "(")
                    sequenciaPosfixa.Enfileirar(operador);
            }

            char variavel = 'A';
            string[] vetorPosfixa = sequenciaPosfixa.ToArray();
            lbSequencias.Text = "Pósfixa: ";

            for (int t = 0; t < vetorPosfixa.Length; t++)
            {
                if (IsOperacao(vetorPosfixa[t]))
                    lbSequencias.Text += vetorPosfixa[t];
                else
                    lbSequencias.Text += variavel++;
            }

            lbSequencias.Text += "\n" + "Infixa: ";
            variavel = 'A';
            string[] vetorInfixa = sequenciaInfixa.ToArray();

            for (int z = 0; z < vetorInfixa.Length; z++)
            {
                if (IsOperacao(vetorInfixa[z]))
                    lbSequencias.Text += vetorInfixa[z];
                else
                    lbSequencias.Text += variavel++;
            }

            PilhaLista<double> resultados = new PilhaLista<double>();
            double x = 0, y = 0, valorFinal = 0;

            string[] vetorSequencia = sequenciaPosfixa.ToArray();

            for (int k = 0; k < vetorSequencia.Length; k++)
            {
                if (!IsOperacao(vetorSequencia[k]))
                    resultados.Empilhar(double.Parse(vetorSequencia[k].Replace('.', ',')));
                else
                {
                    x = resultados.Desempilhar();
                    y = resultados.Desempilhar();

                    switch (vetorSequencia[k])
                    {
                        case "+":
                            valorFinal = y + x;
                            break;

                        case "-":
                            valorFinal = y - x;
                            break;

                        case "*":
                            valorFinal = y * x;
                            break;

                        case "/":
                            if (x == 0)
                                throw new DivideByZeroException("Divisão por 0 INVÁLIDA!!");

                            valorFinal = y / x;
                            break;

                        case "^":
                            valorFinal = Math.Pow(y, x);
                            break;
                    }

                    resultados.Empilhar(valorFinal);
                }
            }

            txtResultado.Text = resultados.Desempilhar().ToString();
        }

        private void txtVisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '0') && (e.KeyChar != '1') && (e.KeyChar != '2') && (e.KeyChar != '3') && (e.KeyChar != '4') && (e.KeyChar != '5') &&
                (e.KeyChar != '6') && (e.KeyChar != '7') && (e.KeyChar != '8') && (e.KeyChar != '9') && (e.KeyChar != '^') && (e.KeyChar != '/') &&
                (e.KeyChar != '*') && (e.KeyChar != '-') && (e.KeyChar != '+') && (e.KeyChar != '.') && (e.KeyChar != '(') && (e.KeyChar != ')') &&
                !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
