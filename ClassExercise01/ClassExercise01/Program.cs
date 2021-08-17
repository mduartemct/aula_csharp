using System;
using Entities;

namespace ClassExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person iPerson = CreatePerson();

            Console.WriteLine("Meu nome é: {0}", iPerson.Name);

            Console.WriteLine("A  minha Cidade é: {0}", iPerson.ActualAddress.MyCity);
            Console.WriteLine("O endereço é: {0}", iPerson.ActualAddress.street);
            Console.WriteLine("O Estado é: {0}", iPerson.ActualAddress.TheState);
            Console.ReadLine();

        }

        private static Person CreatePerson()
        {

            //Cria uma instancia da classe - coloca ela na Memoria RAM do Computador e seta a Referência
            //chamada MyAddress
            Address myAddress = new Address("Niterói");
            myAddress.street = "Rua Matias Sandri";
            myAddress.TheState = "RJ";
            myAddress.country = "Brasil";
            myAddress.postalCode = "22.240-182";

            Person iPerson = new Person();
            iPerson.Name = "Marcelo Duarte";
            iPerson.Phone = "9714-2474";
            iPerson.Email = "mduarte_mct@hotmail.com";
            iPerson.ActualAddress = myAddress;
            return iPerson;
        }
    }
}
