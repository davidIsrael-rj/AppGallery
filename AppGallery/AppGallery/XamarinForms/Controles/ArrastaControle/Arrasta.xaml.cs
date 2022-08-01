using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.ArrastaControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Arrasta : ContentPage
    {
        public Arrasta()
        {
            InitializeComponent();
        }

        private void BotaoDetalhe(object sender, EventArgs e)
        {
            lblDetalhe.Text = $"Botão Detalhe {DateTime.Now.ToString("HH:MM:ss")}";
        }

        private void BotaoEditar(object sender, EventArgs e)
        {
            lblEditar.Text = $"Botão Editar {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void BotaoExcluir(object sender, EventArgs e)
        {
            lblExcluir.Text = $"Botão Excluir{"HH:mm:ss"}";
        }

        private void Swipe_Detalhe(object sender, EventArgs e)
        {
            lblDetalhe.Text = $"Swipe_Detalhe {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void EventoSwipeStarted(object sender, SwipeStartedEventArgs e)
        {
            lblSwipeStarted.Text = $"SwipeStarted {DateTime.Now.ToString("HH:mm:ss")} - {e.SwipeDirection}";
        }

        private void EventoSwipeChanging(object sender, SwipeChangingEventArgs e)
        {
            lblSwipeChanging.Text = $"SwipeChanging {DateTime.Now.ToString("HH:mm:ss")} - {e.SwipeDirection} - {e.Offset} ";
        }

        private void EventoSwipeEnded(object sender, SwipeEndedEventArgs e)
        {
            lblSwipeEnded.Text = $"SwipeEnded {DateTime.Now.ToString("HH:mm:ss")} - {e.SwipeDirection}";
        }

        private void Swipe_Editar(object sender, EventArgs e)
        {
            lblEditar.Text = $"Swipe_Editar {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void Swipe_Excluir(object sender, EventArgs e)
        {
            lblExcluir.Text = $"Swipe_Excluir {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void SwipeCloseRequested(object sender, CloseRequestedEventArgs e)
        {
            lblSwipeClose.Text = $"SwipeCloseRequested {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void Botao_CloseSwipeView(object sender, EventArgs e)
        {
            SwipeView_Arrastar.Close();
        }
    }
}