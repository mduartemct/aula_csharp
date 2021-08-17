using System;

namespace ClassExercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "jacira";
            person.Phone = "21 99825 2829";
            person.Email = "jaciradomal@gmail.com";

            Console.WriteLine("meu nome é: {0}", person.Name);
            Console.WriteLine("Meu numero de telefone é: {0}", person.Phone);
            Console.WriteLine("Meu e-mail é: {0}", person.Email);




            Address address = new Address();
            address.Street = "Rua Amaral Peixoto,";
            address.City = "Nikity,";
            address.State = "Rio de Janeiro,";
            address.PostalCode = "24.000.000";
            address.Coutry = "Brasil";

            Console.WriteLine("Meu endereço é: {0} {1} {2} {3}", address.Street, address.City, address.State, address.Coutry);
            Console.WriteLine("cep: {0}", address.PostalCode);

        }
    }
}
