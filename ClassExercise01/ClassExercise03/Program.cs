using System;

namespace ClassExercise03
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Usando a Classe e os Metódos!");

            // Person person01 = new Person();
            Person person02 = new Person { Id = "1467", Email = "Md@m.comn", Idade = 48, Name = "Ambrozio da Silva", Sexo = "Masculino" };


            //Pegar uma Propriedade da Person
            string _myName = person02.Name;

            Console.WriteLine(_myName);

            //Mudar uma propriedade
            var newName = person02.Name = "Ambrozina da Silva";

            Console.WriteLine(newName);

            //Usar um método de Person que nao tem Retorno nem Parametro
            person02.MetodoSemRetornoNemParametro();

            //Usar um metodo que retorne algo
            bool isAlgo = person02.MetodoComRetorno_e_Parametro(20);

            Console.WriteLine(isAlgo);

            //usar um metodo com sobrecarga de parametros
            var m1 = person02.MetodoOrganizaNome_e_Idade(15);
            Console.WriteLine(m1);
            var m2 = person02.MetodoOrganizaNome_e_Idade("Silva", "Ambrozina");
            Console.WriteLine(m2);
            var m3 = person02.MetodoOrganizaNome_e_Idade("Silva", "Ambrozina", 50);
            Console.WriteLine(m3);

            Console.ReadLine();
        }
    }
}
