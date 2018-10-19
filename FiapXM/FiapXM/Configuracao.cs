using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace FiapXM
{
    public class Configuracao : INotifyPropertyChanged
    {
        private bool aceitaEmail;
        private string email;

        public bool AceitaEmail
        {
            get
            {
                return aceitaEmail;
            }
            set
            {
                aceitaEmail = value;
                OnPropertyChanged();
                if(!aceitaEmail)Email = "";
            }
        }

        public string Email {
            get
            {
                return email;
            }
            set
            {
                email = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
