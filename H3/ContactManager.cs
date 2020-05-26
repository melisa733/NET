using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3
{
    class ContactManager
    {
        List<Contact> contacts;
        bool exit;
        public ContactManager() {
            contacts = new List<Contact>();
            exit = false;
        }
        public void List() 
        {
            if (contacts.Count == 0) 
            {
                Console.WriteLine("You don’t have any contacts!");
            }
            else
            {
                Console.WriteLine("Contact list: ");
                Console.WriteLine("_________________________________________");
                foreach (var c in contacts)
                {
                    Console.WriteLine("Name:{0}, Surname:{1}, Phone number:{2}",
                        c.getName(), c.getSurname(), c.getPhoneNumber());
                }
            }
        }

        public void Add() 
        {
            string name;
            string surname;
            string phoneNr;
            bool canAddContact = true;

            Console.WriteLine("Please enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter surname: ");
            surname = Console.ReadLine();
            Console.WriteLine("Please enter phoneNr: ");
            phoneNr = Console.ReadLine();

            foreach (var c in contacts)
            {
                if (c.getName() == name 
                        && c.getSurname() == surname 
                        && c.getPhoneNumber() == phoneNr) {
                    canAddContact = false;
                    Console.WriteLine("Contact already exists!");
                    break;
                }
            }

            if (canAddContact) {
                contacts.Add(new Contact(name, surname, phoneNr));
                Console.WriteLine("Contact added!");
            }
        }

        public void Delete() 
        {
            string name;
            string surname;
            bool deleted = false;

            Console.WriteLine("Please enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter surname: ");
            surname = Console.ReadLine();

            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].getName() == name
                        && contacts[i].getSurname() == surname)
                {
                    deleted = true;
                    contacts.RemoveAt(i);
                    Console.WriteLine("Contact deleted!");
                    break;
                }
            }

            if (!deleted) 
            {
                Console.WriteLine("Contact not found!");
            }
        }

        public void Exit() 
        {
            exit = true;
        }

        public bool getExit() 
        {
            return exit;
        }
    }
}
