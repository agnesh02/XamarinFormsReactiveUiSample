using ReactiveUI;
using ReactiveUiSample.Model;
using System.Collections.Generic;


namespace ReactiveUiSample.ViewModel
{
    public class ContactsPageViewModel : ReactiveObject
    {

        private List<Contact> _contactsList = new List<Contact>()
        {
            new Contact(name: "Agnesh", phone: "90019019"),
            new Contact(name: "Ranjini", phone: "3535353"),
            new Contact(name: "Santhosh", phone: "223232"),
            new Contact(name: "Lachu", phone: "2323232")
        };

        public List<Contact> ContactList
        {
            get => _contactsList;
            set
            {
                this.RaiseAndSetIfChanged(ref _contactsList, value);
            }
        }

    };


}
