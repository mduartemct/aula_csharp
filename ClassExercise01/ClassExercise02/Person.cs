using System;
namespace ClassExercise02
{
    public class Person
    {
        public Person()
        {

        }
        string name;
        string phone;
        string email;
        Address address;



        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


    }
}
