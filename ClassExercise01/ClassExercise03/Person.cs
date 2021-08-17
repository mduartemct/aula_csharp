using System;
namespace ClassExercise03
{
    public class Person
    {
        public Person()
        {
        }

        #region Exemplo de Fields feito por Marce

        //Fields
        private string id;
        private string name;


        //Propriedade com Lambdas
        public string Id
        {
            get => id;
            set => id = value;
        }

        //Propriedade Tradicional
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //Propriedade e Field direto
        public string Email { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        #endregion

        #region Agora Os Metodos

        //Metodo Simples sem retorno e sem parametro
        public void MetodoSemRetornoNemParametro()
        {
            if (Id.Contains("171"))
            {
                throw new SystemException("Namora não que não presta");
            }
        }

        //Metodo Sem retorno com Parametro

        /// <summary>
        /// 
        /// </summary>
        /// <param name="y">Idade Limite</param>
        public void MetodoSemRetornoComParametro(int y)
        {
            if (y > Idade)
            {
                throw new SystemException("Permitido apenas para maiores que Y centimetros.");
            }
        }

        //Metodo com Retorno e Parametro
        public bool MetodoComRetorno_e_Parametro(int value)
        {
            if (value > 15)
            {
                return true;
            }
            return false;
        }

        public string MetodoOrganizaNome_e_Idade(string sobrenome, string nome, int idade)
        {
            return string.Format("Meu nome é {0} {1} e tenho {2} anos de idade", nome, sobrenome, idade);
        }

        public string MetodoOrganizaNome_e_Idade(string sobrenome, string nome)
        {
            return string.Format("Meu nome é {0} {1} e tenho alguns anos de idade", nome, sobrenome);
        }

        public string MetodoOrganizaNome_e_Idade(int XPTO)
        {
            return string.Format("Meu nome é {0} e tenho alguns anos de idade", XPTO);
        }


        #endregion Agora Os Metodos
    }
}
