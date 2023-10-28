using HW__3_Solution.Entity;
using HW__3_Solution.Entitys;
using HW__3_Solution.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW__3_Solution.Controllers
{
    public class ContactController
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void RemoveContact(Contact contact)
        {
            contacts.Remove(contact);
        }

        public void ClearContacts()
        {
            contacts.Clear();
        }

        public void AddListContacts(List<Contact> contactsList)
        {
            contacts.AddRange(contactsList);
        }

        public List<string> GetListContactsNames()
        {
            List<string> Namelist = new List<string>();

            foreach (Contact contact in contacts)
            {
                if (!Namelist.Contains(contact.Name))
                    Namelist.Add(contact.Name);
            }
            return Namelist;
        }

        public void ShowInformation(IOutputHandler handler)
        {
            handler.Show(contacts);
        }

        public void ShowInformationContactsNames(IOutputHandler handler)
        {
            handler.Show(this.GetListContactsNames());
        }

        public void SaveInformation(ISavingFileHandler handler)
        {
            handler.Save(contacts);
        }

        public void LoadInformation(ISavingFileHandler handler)
        {
            contacts = handler.LoadContacts();
        }

        public int GetCount()
        {
            return contacts.Count;
        }
    }


}
