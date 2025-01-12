﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirContentPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeConteudo.Conteudo01();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirNavigationPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;

        }

        private void AbrirCarouselPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeCarrossel.Carrossel();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirTabbedPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeAbas.Abas();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirMasterDetailPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirPaginaModal(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.Modal.Conteudo01();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirStackLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layout.PilhaLayout.Pilha();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirGrid(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layout.GradeLayout.Grade();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirAbsoluteLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layout.AbsolutoLayout.Absoluto();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirRelativeLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layout.RelativoLayout.Relativo();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirFlexLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layout.FlexivelLayout.Flexivel();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirScrollView(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Layout.BarraDeRolagemLayout.BarraDeRolagem();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirContentView(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Layout.ControleLayout.Controle());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirFrame(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Layout.QuadradoLayout.Quadrado());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirBoxView(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.CaixaControle.CaixaUm());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirLabel(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.RotuloControle.Rotulo());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirButton(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.BotaoControle.Botao());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirImageButton(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.BotaoImagemControle.BotaoImagem());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirImage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.ImagemControle.Imagem());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirEntry(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.CampoDeEntradaSimplesControle.CampoDeEntradaSimples());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirEditor(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.CampoDeEntradaMultiLineControle.CampoDeEntradaMultiLine());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirCheckBox(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.CaixaDeMarcacaoControle.CaixaDeMarcacao());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirRadioButton(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.CaixaDeRadioControle.CaixaDeRadio());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirSwitch(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.InterruptorControle.Interruptor());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirStepper(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.PassadorControle.Passador());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirSlider(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.DeslizanteControle.Deslizante());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirPicker(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.SelecaoControle.Selecao());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirDatePicker(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.DataSelecaoControle.DataSelecao());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirTimePicker(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.TempoSelecaoControle.TempoSelecao());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirActivityIndicator(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.IndicadorAtividadesControle.IndicadoDeAtividades());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirProgressBar(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.BarraDeProgessoControle.BarraDeProgresso());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirSearchBar(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.BarraDePesquisaControle.BarraDePesquisa());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirRefreshView(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.AtualizaControle.Atualiza());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirSwipeWiew(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.ArrastaControle.Arrasta());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirWebView(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Controles.NavegadorControle.Navegador());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }
    }
       
}