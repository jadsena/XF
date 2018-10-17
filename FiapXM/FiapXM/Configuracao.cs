using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FiapXM
{
    public class Configuracao : INotifyPropertyChanged
    {
        protected bool aceitaEmail;
        public bool AceitaEmail
        {
            get
            {
                return aceitaEmail;
            }
            set
            {
                aceitaEmail = value;
                OnPropertyChanged(nameof(AceitaEmail));
            }
        }

        public string Email { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
