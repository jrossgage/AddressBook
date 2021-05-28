using System.Collections.Generic;

namespace addressBook
{
    public class AddressBook
    {
        public Dictionary<string, Contact> ContactList { get; set; }


        public AddressBook()
        {
            ContactList = new Dictionary<string, Contact>();
        }
        public void AddContact(Contact contact)
        {

            ContactList.Add(contact.Email, contact);

        }

        public Contact GetByEmail(string email)
        {

            Contact value = new Contact();
            ContactList.TryGetValue(email, out value);
            return value;

        }
    }
}