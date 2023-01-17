using Microsoft.VisualBasic.FileIO;
using System;

namespace AddressBookADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System ADO.Net!");
            Option operation = new Option();
            operation.AddressBookOperation();
        }
    }
}