using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CalculadoraXamarin
{
    public partial class Calculadora : ContentPage
    {
        private static double TamanhoBotaoX { get; set; } = 1;
        private static double TamanhoBotaoY { get; set; } = 1.2;
        #region[COMPONENTES]
        //numeros
        Button btn0 = new Button() { Text = "0", ScaleX = TamanhoBotaoX, ScaleY = TamanhoBotaoY }; 
        Button btn1 = new Button() { Text = "1", ScaleX = TamanhoBotaoX, ScaleY = TamanhoBotaoY };
        Button btn2 = new Button() { Text = "2", ScaleX = TamanhoBotaoX, ScaleY = TamanhoBotaoY };
        Button btn3 = new Button() { Text = "3", ScaleX = TamanhoBotaoX, ScaleY = TamanhoBotaoY };
        Button btn4 = new Button() { Text = "4", ScaleX = TamanhoBotaoX, ScaleY = TamanhoBotaoY };
        Button btn5 = new Button() { Text = "5", ScaleX = TamanhoBotaoX, ScaleY = TamanhoBotaoY };
        Button btn6 = new Button() { Text = "6", ScaleX = TamanhoBotaoX, ScaleY = TamanhoBotaoY };
        Button btn7 = new Button() { Text = "7", ScaleX = TamanhoBotaoX, ScaleY = TamanhoBotaoY };
        Button btn8 = new Button() { Text = "8", ScaleX = TamanhoBotaoX, ScaleY = TamanhoBotaoY };
        Button btn9 = new Button() { Text = "9", ScaleX = TamanhoBotaoX, ScaleY = TamanhoBotaoY };
        
        //operadores
        Button btnAdicao = new Button() { Text = "+", ScaleX = TamanhoBotaoX, ScaleY = TamanhoBotaoY };
        Button btnSubstracao = new Button() { Text = "-", ScaleX = TamanhoBotaoX, ScaleY = TamanhoBotaoY };
        Button btnMultiplicacao = new Button() { Text = "*", ScaleX = TamanhoBotaoX, ScaleY = TamanhoBotaoY };
        Button btnDivisao = new Button() { Text = "/", ScaleX = TamanhoBotaoX, ScaleY = TamanhoBotaoY };
        Button btnIgual = new Button() { Text = "=", ScaleX = TamanhoBotaoX, ScaleY = TamanhoBotaoY };

        //recursos
        Button btnClear = new Button() { Text = "Clear", ScaleX = TamanhoBotaoX, ScaleY = TamanhoBotaoY };

        /// <summary>
        /// Numero escolhio no momento do click do botão
        /// </summary>
        Label lblVisorNumAtual = new Label() { Text = "", FontSize = 44, HorizontalTextAlignment = TextAlignment.End, Margin = 10, Padding = 15 };
        
        /// <summary>
        /// Expressão completa que será calculada
        /// </summary>
        Label lblVisorOperacao = new Label() { Text = "", FontSize = 60, HorizontalTextAlignment = TextAlignment.End, Margin = 10, Padding = 15 };

        #endregion

        #region[LAYOUT DA PAGINA]
        public void InitializeComponents()
        {
            this.Content = new StackLayout
            {
                Children =
                {
                    lblVisorOperacao,
                    lblVisorNumAtual,                                
                    new FlexLayout
                    {
                        Margin = new Thickness(20,0),                        
                        //Padding = new Thickness(10,0),
                        Children =
                        {
                            btn7,
                            btn8,
                            btn9,
                            btnAdicao
                        }
                    },                                
                    new FlexLayout
                    {
                        Margin = new Thickness(20,0),
                        //Padding = new Thickness(10,0),
                        Children =
                        {
                            btn4,
                            btn5,
                            btn6,
                            btnSubstracao
                        }
                    },                                
                    new FlexLayout
                    {
                        Margin = new Thickness(20,0),
                        //Padding = new Thickness(10,0),
                        Children =
                        {
                            btn1,
                            btn2,
                            btn3,
                            btnMultiplicacao
                        }
                    },                                
                    new FlexLayout
                    {
                        Margin = new Thickness(20,0),
                        //Padding = new Thickness(10,0),
                        Children =
                        {
                            btnClear,
                            btn0,
                            btnIgual,
                            btnDivisao
                        }
                    },
        
                    
                }
            };
        }
        #endregion
    }
}