using System;

namespace ConsoleApp1
{
    class Address
    {
        public int Index { get; set; }
        public string Sity { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Apartment { get; set; }
        public override string ToString()
        {
            return Index + " " + Sity + " " + Street + " " + House + " " + Apartment;
        }

        public Address(int addressIndex, string addressSity, string addressStreet,
                       int addressHouse, int addressApartment)
        {
            Index = addressIndex;
            Sity = addressSity;
            Street = addressStreet;
            House = addressHouse;
            Apartment = addressApartment;
        }
    }
}
