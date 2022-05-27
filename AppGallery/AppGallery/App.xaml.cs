using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            /*
          var pagina = new NavigationPage(new XamarinForms
                 .Paginas
                 .PaginaDeNavegacao
                 .Conteudo01()
         );
            MainPage = pagina;
             */
            /*
             MainPage = new XamarinForms.Paginas.Modal.Conteudo01();
            */
            /*
            var pagina = new CarouselPage();
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo01());
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo02());
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo03());

            pagina.CurrentPage = pagina.Children[1];

            MainPage = pagina;
            */
            /*
            var pagina = new XamarinForms.Paginas.PaginaDeCarrossel.Carrossel();
            MainPage = pagina;
            */
            /*
            var pagina = new XamarinForms.Paginas.PaginaDeAbas.Abas();
            MainPage = pagina;
             var pagina = new MasterDetailPage();
            //Menu
            pagina.Master = ;
            //Conteudo
            pagina.Detail = ;
          
            var pagina = new XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral();
            MainPage = pagina;
              */
            var pagina = new AppBase.Menu();
            MainPage = pagina;

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
