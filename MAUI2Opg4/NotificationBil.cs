using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI2Opg1
{
    internal class NotificationBil : INotifyPropertyChanged
    {
        private string _model = "";
        private int _heste;
        private bool _elbil;

        public NotificationBil() { }
        public NotificationBil(string model, int heste, bool elbil)
        {
            Model = model;
            Heste = heste;
            Elbil = elbil;
            
        }

        public string Model
        {
            get { return _model; }
            set
            {
                _model = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Model"));
            }
        }

        public int Heste
        {
            get { return _heste; }
            set
            {
                _heste = value;
            }
        }
        public bool Elbil
        {
            get { return _elbil; }
            set
            {
                _elbil = value;
            }
        }




        public event PropertyChangedEventHandler? PropertyChanged = delegate { };
    }

}
