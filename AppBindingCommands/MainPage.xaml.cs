namespace AppBindingCommands
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAtualizarInformacoes_Clicked(object sender, EventArgs e)
        {
            string informacoes = string.Empty;

            if (Preferences.ContainsKey("AcaoInicial"))
                informacoes += Preferences.Get("AcaoInicial", string.Empty);

            if (Preferences.ContainsKey("AcaoStart"))
                informacoes += Preferences.Get("AcaoStart", string.Empty);

            if (Preferences.ContainsKey("AcaoSleep"))
                informacoes += Preferences.Get("AcaoSleep", string.Empty);

            if (Preferences.ContainsKey("AcaoResume"))
                informacoes += Preferences.Get("AcaoResume", string.Empty);

            lblInformacoes.Text = informacoes;
        }
    }
}