using ReactiveUiSample.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ReactiveUiSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void NavigateToLoginPage(object sender, EventArgs e)
        {
            Console.WriteLine("Agnesh: Navigating to value change screen...");
            Navigation.PushAsync(new ValueChangePage());
        }

        public void NavigateToColourSelectorPage(object sender, EventArgs e)
        {
            Console.WriteLine("Agnesh: Navigating to colour selector screen...");
            Navigation.PushAsync(new ColourSelectorPage());
        }

        public void NavigateToContactsPage(object sender, EventArgs e)
        {
            Console.WriteLine("Agnesh: Navigating to contacts screen...");
            Navigation.PushAsync(new ContactsPage());
        }

    }
}
