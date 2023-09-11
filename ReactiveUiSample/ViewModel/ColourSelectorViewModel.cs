using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ReactiveUiSample.ViewModel
{
    class ColourSelectorViewModel : ReactiveObject
    {

        private int _redValue;
        public int RedValue
        {
            get => _redValue;
            set
            {
                this.RaiseAndSetIfChanged(ref _redValue, value);
                this.RaisePropertyChanged(nameof(FinalValue));
            }
        }

        private int _blueValue;
        public int BlueValue
        {
            get => _blueValue;
            set
            {
                this.RaiseAndSetIfChanged(ref _blueValue, value);
                this.RaisePropertyChanged(nameof(FinalValue));

            }
        }

        private int _greenValue;
        public int GreenValue
        {
            get => _greenValue;
            set
            {
                this.RaiseAndSetIfChanged(ref _greenValue, value);
                this.RaisePropertyChanged(nameof(FinalValue));
            }
        }

        private Color _finalValue;
        public Color FinalValue
        {
            get => Color.FromArgb(red: RedValue, green: GreenValue, blue: BlueValue);
            set
            {
                this.RaiseAndSetIfChanged(ref _finalValue, value);
            }
        }

    }
}
