using ReactiveUiSample.Model;
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
	public partial class ContactsPage : ContentPage
	{
		public ContactsPage()
		{
			InitializeComponent ();
			BindingContext = new ContactsPageViewModel();
		}
	}
}