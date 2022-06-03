using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Layout.BarraDeRolagemLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarraDeRolagem : ContentPage
    {
        public BarraDeRolagem()
        {
            InitializeComponent();
        }

        private void RolarParaASegundaLabel(object sender, EventArgs e)
        {
            BarraDeRolagemTexto.ScrollToAsync(BotaoDois, ScrollToPosition.Start, true);
        }

        private void RolarParaSubir(object sender, EventArgs e)
        {
            BarraDeRolagemTexto.ScrollToAsync(BotaoUm, ScrollToPosition.Start, false);
        }
    }
}