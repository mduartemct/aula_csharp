using System;
using PizzariaRest.Interfaces;

namespace PizzariaRest.Models
{
    public class Coachee : IModel
    {
        //Implementacao da Interface
        public string Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                if (string.IsNullOrEmpty(email))
                {
                    throw new SystemException("Email não pode ser nulo/vazio");
                }

            }
        }

    }
}
