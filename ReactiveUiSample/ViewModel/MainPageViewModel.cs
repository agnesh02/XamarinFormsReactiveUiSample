using ReactiveUiSample.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ReactiveUiSample.ViewModel
{
    public class MainPageViewModel
    {
        public ICommand sampleFunction => new Command(SampleFunctionExecution);

        void SampleFunctionExecution()
        {
            Console.WriteLine("Agnesh: Sample function executed !!");
        }
    }
}
