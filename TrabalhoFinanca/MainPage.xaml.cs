namespace TrabalhoFinanca
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void cliquebtn(object sender, EventArgs e)
        {
            string simboloAcao = campoSimbolo.Text;
            telaCot shareDetails = new telaCot(simboloAcao);
            telaCot telaCot = new telaCot(simboloAcao);
            await Navigation.PushAsync(telaCot);
            SemanticScreenReader.Announce(simboloAcao);
        }
    }

}
