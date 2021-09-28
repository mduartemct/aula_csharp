using System;
namespace PizzariaRest.Models
{
    public class Coachee
    {
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
