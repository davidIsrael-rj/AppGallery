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
            numA = "0";
            numB = "0";
            operacao = "";
        }
        public void ZerarTudo()
        {
            Limpar();
            LblResultado.Text = "0";
            resultado = 0;
        }
        public void entrarValor(string valor)
        {
            if (operacao == "")
            {
                if (numA =="0" )
                {
                    numA = valor;
                    LblResultado.Text = numA;
                }
                else
                {
                    numA = numA + valor;
                    LblResultado.Text = numA;
                }
            }
            else
            {
                numB = valor;
                LblResultado.Text = numB;
            }
            
        }
        private void Zero(object sender, EventArgs e)
        {
            entrarValor("0");
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
                        resultado = valorA - valorB;
                        LblResultado.Text = resultado.ToString();
                        Limpar();
                    }
                    break;
                case "Multiplicacao":
                    {
                        resultado =valorA * valorB;
                        LblResultado.Text = resultado.ToString();
                        Limpar();
                    }
                    break;
                case "Divisao":
                    {
                        resultado = valorA / valorA;
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
            entrarValor("1");
            
        }

        private void Dois(object sender, EventArgs e)
        {
            entrarValor("2");
        }

        private void Tres(object sender, EventArgs e)
        {
            entrarValor("3");
        }

        private void Soma(object sender, EventArgs e)
        {
            operacao = "Soma";
        }

        private void Quatro(object sender, EventArgs e)
        {
            entrarValor("4");
        }

        private void Cinco(object sender, EventArgs e)
        {
            entrarValor("5");
        }

        private void Seis(object sender, EventArgs e)
        {
            entrarValor("6");
        }

        private void Subtracao(object sender, EventArgs e)
        {
            operacao = "Subtracao";
        }

        private void Sete(object sender, EventArgs e)
        {
            entrarValor("7");
        }

        private void Oito(object sender, EventArgs e)
        {
            entrarValor("8");
        }

        private void Nove(object sender, EventArgs e)
        {
            entrarValor("9");
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