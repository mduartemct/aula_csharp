using System;

namespace Entities
{
    public class Address
    {
        //Metodo construtor Padrão da classe.
        public Address()
        {
        }

        //Construtor que já cria uma classe Address com o nome da City
        public Address(string cityName)
        {
            city = cityName;
        }

        //Fields - Sao privados por padrão
        public string street;
        private string city;
        public string state;
        public string postalCode;
        public string country;

        //Propriedades permitem o encapsulamento dos Fields. Podemos
        //Criar Propriedades somente de leituta (GET) ou Somente Escrita (SET)
        //Ou leitura e escrita (GET/SET)
        public string MyCity
        {
            get
            {
                return city;
            }

        }

        public string TheState
        {
            get
            {
                if (state.Contains("RJ"))
                {
                    return "Rio de Janeiro, Eu moro bem!!";
                }
                if (state.Contains("SP"))
                {
                    return "SP - Vc é branquelo!";
                }
                return state;
            }
            set
            {
                if (value.Contains("SP"))
                {
                    throw new SystemException("Paulista não pode!");
                }
                state = value;
            }
        }

    }
}
