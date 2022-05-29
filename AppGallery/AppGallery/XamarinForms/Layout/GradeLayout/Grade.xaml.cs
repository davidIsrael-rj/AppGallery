using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Layout.GradeLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Grade : ContentPage
    {
        int resultado = 0;
        string operacao = "";
        int valorA, valorB;
        string numA, numB;
        public Grade()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            valorA = 0;
            valorB = 0;
            numA = "";
            numB = "";
            operacao = "";
        }
        public void ZerarTudo()
        {
            Limpar();
            LblResultado.Text = "0";
            resultado = 0;
        }
        private void Zero(object sender, EventArgs e)
        {
            if (operacao == "")
            {
                numA = numA + "0";
                LblResultado.Text = numA;
            }
            else
            {
                numB = numB + "0";
                LblResultado.Text = numB;
            }
        }

        private void Ponto(object sender, EventArgs e)
        {

        }

        private void Igual(object sender, EventArgs e)
        {
            valorA = (int)Convert.ToInt64(numA);
            valorB = (int)Convert.ToInt64(numB);
            switch (operacao)
            {

                case "Soma":
                    {
                        resultado = resultado + valorA + valorB;
                        LblResultado.Text = resultado.ToString();
                        Limpar();
                    }
                    break;
                case "Subtracao":
                    {
                        resultado = resultado -  valorA - valorA;
                        LblResultado.Text = resultado.ToString();
                        Limpar();
                    }
                    break;
                case "Multiplicacao":
                    {
                        resultado = resultado * valorA * valorB;
                        LblResultado.Text = resultado.ToString();
                        Limpar();
                    }
                    break;
                case "Divisao":
                    {
                        resultado = resultado / valorA / valorA;
                        LblResultado.Text = resultado.ToString();
                        Limpar();
                    }
                    break;
                default:
                    break;
            }
        }

        private void Um(object sender, EventArgs e)
        {
           if(operacao =="")
            {
                numA = numA + "1";
                LblResultado.Text = numA;
            }
            else
            {
                numB = numB + "1";
                LblResultado.Text = numB;
            }
            
        }

        private void Dois(object sender, EventArgs e)
        {
            if (operacao == "")
            {
                numA = numA + "2";
                LblResultado.Text = numA;
            }
            else
            {
                numB = numB + "2";
                LblResultado.Text = numB;
            }
        }

        private void Tres(object sender, EventArgs e)
        {
            if (operacao == "")
            {
                numA = numA + "3";
                LblResultado.Text = numA;
            }
            else
            {
                numB = numB + "3";
                LblResultado.Text = numB;
            }
        }

        private void Soma(object sender, EventArgs e)
        {
            operacao = "Soma";
        }

        private void Quatro(object sender, EventArgs e)
        {
            if (operacao == "")
            {
                numA = numA + "4";
                LblResultado.Text = numA;
            }
            else
            {
                numB = numB + "4";
                LblResultado.Text = numB;
            }
        }

        private void Cinco(object sender, EventArgs e)
        {
            if (operacao == "")
            {
                numA = numA + "5";
                LblResultado.Text = numA;
            }
            else
            {
                numB = numB + "5";
                LblResultado.Text = numB;
            }
        }

        private void Seis(object sender, EventArgs e)
        {
            if (operacao == "")
            {
                numA = numA + "6";
                LblResultado.Text = numA;
            }
            else
            {
                numB = numB + "6";
                LblResultado.Text = numB;
            }
        }

        private void Subtracao(object sender, EventArgs e)
        {
            operacao = "Subtracao";
        }

        private void Sete(object sender, EventArgs e)
        {
            if (operacao == "")
            {
                numA = numA + "7";
                LblResultado.Text = numA;
            }
            else
            {
                numB = numB + "7";
                LblResultado.Text = numB;
            }
        }

        private void Oito(object sender, EventArgs e)
        {
            if (operacao == "")
            {
                numA = numA + "8";
                LblResultado.Text = numA;
            }
            else
            {
                numB = numB + "8";
                LblResultado.Text = numB;
            }
        }

        private void Nove(object sender, EventArgs e)
        {
            if (operacao == "")
            {
                numA = numA + "9";
                LblResultado.Text = numA;
            }
            else
            {
                numB = numB + "9";
                LblResultado.Text = numB;
            }
        }

        private void Multiplicacao(object sender, EventArgs e)
        {
            operacao = "Multiplicacao";
        }

        private void Deletar(object sender, EventArgs e)
        {
            ZerarTudo();
        }

        private void TrocaDeSinalMaisEMenos(object sender, EventArgs e)
        {

        }

        private void Porcentagem(object sender, EventArgs e)
        {

        }

        private void Divisao(object sender, EventArgs e)
        {
            operacao = "Divisao";
        }
    }
}