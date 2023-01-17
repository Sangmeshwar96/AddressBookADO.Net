using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADO
{
    public class Option
    {
        AddressBookOperations operations = new AddressBookOperations();
        public int choice;

        public void AddressBookOperation()
        {
            do
            {
                Console.Write("\n1. Insert New Contact\n" +
                    "2. Edit Existing Contact\n" +
                    "3. Delete Contact\n" +
                    "4. Retrieve Contact Belongs To City Or State\n" +
                    "5. Size Of AddressBook By City\n" +
                    "6. Retrieve Contacts Belongs To City Sorted Alphabatically\n" +
                    "0. Exit\n" +
                    "Select One Option: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        operations.InsertNewContact();
                        break;
                    case 2:
                        operations.EditExistingContact();
                        break;
                    case 3:
                        operations.DeleteContact();
                        break;
                    case 4:
                        operations.RetrieveContactBelongsToCityOrState();
                        if (operations.addressBook.Count > 0)
                        {
                            Console.WriteLine("________________________________________\n");
                            foreach (AddressBook contact in operations.addressBook)
                            {
                                Console.WriteLine("Contact Id: " + contact.ContactId);
                                Console.WriteLine("FirstName: " + contact.FirstName);
                                Console.WriteLine("LastName: " + contact.LastName);
                                Console.WriteLine("Address: " + contact.Address);
                                Console.WriteLine("City: " + contact.City);
                                Console.WriteLine("State: " + contact.State);
                                Console.WriteLine("Zip: " + contact.Zip);
                                Console.WriteLine("PhoneNumber: " + contact.PhoneNumber);
                                Console.WriteLine("Email: " + contact.Email);
                                Console.WriteLine("________________________________________\n");
                            }
                        }
                        else
                            Console.WriteLine("-----Data Not Found-----");
                        break;
                    case 5:
                        operations.SizeOfAddressBookByCity();
                        break;
                    case 6:
                        operations.RetrieveContactBelongsToCitySortedAlphabatically();
                        if (operations.addressBook.Count > 0)
                        {
                            Console.WriteLine("________________________________________\n");
                            foreach (AddressBook contact in operations.addressBook)
                            {
                                Console.WriteLine("Contact Id: " + contact.ContactId);
                                Console.WriteLine("FirstName: " + contact.FirstName);
                                Console.WriteLine("LastName: " + contact.LastName);
                                Console.WriteLine("Address: " + contact.Address);
                                Console.WriteLine("City: " + contact.City);
                                Console.WriteLine("State: " + contact.State);
                                Console.WriteLine("Zip: " + contact.Zip);
                                Console.WriteLine("PhoneNumber: " + contact.PhoneNumber);
                                Console.WriteLine("Email: " + contact.Email);
                                Console.WriteLine("________________________________________\n");
                            }
                        }
                        else
                            Console.WriteLine("-----Data Not Found-----");
                        break;
                    case 0:
                        Console.WriteLine("________________________________________\n");
                        Console.WriteLine("-----Thankyou-----");
                        break;
                    default:
                        Console.WriteLine("________________________________________\n");
                        Console.WriteLine("-----Invalid Option-----");
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
