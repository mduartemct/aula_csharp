using System;
namespace ClassExercise02
{
    public class Address
    {

        string street;
        string city;
        string state;
        string postalCode;
        string coutry;



        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        public string Coutry
        {
            get { return coutry; }
            set { coutry = value; }
        }

    }
}
