using System.Collections.Generic;
using System;
namespace AddressBook.Models
{
    // Class Object
    public class Address
    {
        private string _name;
        private string _phoneNumber;
        private string _address;
        private static List<Address> _allAddress = new List<Address>{};

        // Constructor
        public Address(string nameIn, string phoneNumberIn, string addressIn)
        {
            _name = nameIn;
            _phoneNumber = phoneNumberIn;
            _address = addressIn;
        }
        // Getters
        public string getName()
        {
            return _name;
        }
        public string getPhoneNumber()
        {
            return _phoneNumber;
        }
        public string getAddress()
        {
            return _address;
        }
        // Setters
        public void setName(string nameIn)
        {
            _name = nameIn;
        }
        public void setPhoneNumber(string phoneNumberIn)
        {
            _phoneNumber = phoneNumberIn;
        }
        public void setAddress(string addressIn)
        {
            _address = addressIn;
        }
        public static List<Address> GetAll()
        {
            return _allAddress;
        }
        public static void ClearAll()
        {
            _allAddress.Clear();
        }
    }
}
