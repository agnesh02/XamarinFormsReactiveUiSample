using ReactiveUiSample.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReactiveUiSample.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ValueChangePage : ContentPage
	{
		public ValueChangePage()
		{
            InitializeComponent();
			BindingContext = new ValueChangeViewModel();
		}
    }
}