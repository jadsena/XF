using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FiapXM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            if(App.Configuracao.AceitaEmail && !string.IsNullOrWhiteSpace(App.Configuracao.Email))
                DisplayAlert("Atenção"
                    , string.Format("E-mail enviado para {0}", App.Configuracao.Email)
                    , "OK");
            else
                DisplayAlert("Atenção", "E-mail não autorizado.", "OK");

        }

        private void btnConfig_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConfigPage());
        }
    }
}
