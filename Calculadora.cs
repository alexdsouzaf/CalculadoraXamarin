using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CalculadoraXamarin
{
    public partial class Calculadora
    {
        #region[ATRIBUTOS]
        public decimal num1 { get; set; }
        public decimal num2 { get; set; }
        public string operador { get; set; }
        public bool flag { get; set; } = true;
        #endregion

        #region[CONSTRUTOR]
        public Calculadora()
        {
            this.Eventos();
            this.InitializeComponents();
        }
        #endregion

        #region[EVENTOS]
        private void Btn0_Clicked(object sender, EventArgs e)
        {
            lblVisorNumAtual.Text += "0";
            AtribuirVariaveisCalculo();
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            lblVisorNumAtual.Text += "1";
            AtribuirVariaveisCalculo();
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            lblVisorNumAtual.Text += "2"; 
            AtribuirVariaveisCalculo();
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            lblVisorNumAtual.Text += "3";
            AtribuirVariaveisCalculo();
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            lblVisorNumAtual.Text += "4";
            AtribuirVariaveisCalculo();
        }

        private void Btn5_Clicked(object sender, EventArgs e)
        {
            lblVisorNumAtual.Text += "5";
            AtribuirVariaveisCalculo();
        }

        private void Btn6_Clicked(object sender, EventArgs e)
        {
            lblVisorNumAtual.Text += "6";
            AtribuirVariaveisCalculo();
        }

        private void Btn7_Clicked(object sender, EventArgs e)
        {
            lblVisorNumAtual.Text += "7";
            AtribuirVariaveisCalculo();
        }

        private void Btn8_Clicked(object sender, EventArgs e)
        {
            lblVisorNumAtual.Text += "8";
            AtribuirVariaveisCalculo();
        }
        private void Btn9_Clicked(object sender, EventArgs e)
        {
            lblVisorNumAtual.Text += "9";
            AtribuirVariaveisCalculo();
        }

        private void btnIgual_Clicked(object sender, EventArgs e)
        {
            switch (operador)
            {
                case "+":
                    lblVisorNumAtual.Text = Somar();
                    break;
                case "-":
                    lblVisorNumAtual.Text = Subtrair();
                    break;
                case "*":
                    lblVisorNumAtual.Text = Multiplicar();
                    break;
                case "/":
                    lblVisorNumAtual.Text = Dividir();
                    break;
                default:
                    break;
            }

            num1 = Convert.ToDecimal(lblVisorNumAtual.Text);
            lblVisorOperacao.Text = string.Empty;
        }
        private void btnAdicao_Clicked(object sender, EventArgs e)
        {
            operador = "+";
            ManipulaVisor();
            lblVisorOperacao.Text += " + ";

        }
        private void btnSubstracao_Clicked(object sender, EventArgs e)
        {
            operador = "-";
            ManipulaVisor();
            lblVisorOperacao.Text += " - ";
        }

        private void btnMultiplicacao_Clicked(object sender, EventArgs e)
        {
            operador = "*";
            ManipulaVisor();
            lblVisorOperacao.Text += " * ";
        }
        private void btnDivisao_Clicked(object sender, EventArgs e)
        {
            operador = "/";
            ManipulaVisor();
            lblVisorOperacao.Text += " / ";
        }
        private void btnClear_Clicked(object sender, EventArgs e)
        {
            flag = true;
            lblVisorOperacao.Text = string.Empty;
            lblVisorNumAtual.Text = string.Empty;
        }
        #endregion

        #region[METODOS]
        private string Somar() => (num1 + num2).ToString();

        private string Subtrair() => (num1 - num2).ToString();

        private string Dividir() => (num1 / num2).ToString();

        private string Multiplicar() => (num1 * num2).ToString();

        private void AtribuirVariaveisCalculo()
        {
            if (flag)
                num1 = Convert.ToDecimal(lblVisorNumAtual.Text);
            else
                num2 = Convert.ToDecimal(lblVisorNumAtual.Text);
        }

        private void ManipulaVisor()
        {
            lblVisorOperacao.Text += lblVisorNumAtual.Text;
            lblVisorNumAtual.Text = string.Empty;
            flag = false;
        }

        private void Eventos()
        {
            btn0.Clicked += Btn0_Clicked;
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;
            btn4.Clicked += Btn4_Clicked;
            btn5.Clicked += Btn5_Clicked;
            btn6.Clicked += Btn6_Clicked;
            btn7.Clicked += Btn7_Clicked;
            btn8.Clicked += Btn8_Clicked;
            btn9.Clicked += Btn9_Clicked;
            btnIgual.Clicked += btnIgual_Clicked;
            btnAdicao.Clicked += btnAdicao_Clicked;
            btnSubstracao.Clicked += btnSubstracao_Clicked;
            btnMultiplicacao.Clicked += btnMultiplicacao_Clicked;
            btnDivisao.Clicked += btnDivisao_Clicked;
            btnClear.Clicked += btnClear_Clicked;
        }
        #endregion
    }
}