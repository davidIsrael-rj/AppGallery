using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.BarraDeProgessoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarraDeProgresso : ContentPage
    {
        double valorProgresBar = 0.0;
        public BarraDeProgresso()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            valorProgresBar += 0.10; 
            BarraDeProgresso1.ProgressTo(valorProgresBar, 500, Easing.BounceOut);
        }
    }
}