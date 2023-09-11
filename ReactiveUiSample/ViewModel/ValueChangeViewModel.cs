using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ReactiveUiSample.ViewModel
{
    public class ValueChangeViewModel : INotifyPropertyChanged
    {
        private string _inputText;
        public string InputText
        {
            get { return _inputText; }
            set
            {
                this._inputText = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(InputText)));
            }
        }


    
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
