using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.ImagemControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Imagem : ContentPage
    {
        public Imagem()
        {
            InitializeComponent();

            //Imagem01.Source = ImageSource.FromResource("AppGallery.XamarinForms.Controles.ImagemControle.background.png");
            //Download -> System.IO (Stream) = System.IO.Stream
            //Imagem01.Source = ImageSource.FromStream("https://ciclovivo.com.br/wp-content/uploads/2018/10/iStock-536613027.jpg")
        }

    }
}