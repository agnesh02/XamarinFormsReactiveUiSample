using System;
using System.Collections.Generic;
using System.Text;

namespace ReactiveUiSample.Model
{
    public class Contact
    {

        public string Name { get; set; }
        public string Phone { get; set; }

        public Contact(string name = null, string phone = null)
        {
            Name = name;
            Phone = phone;
        }

    }
}
