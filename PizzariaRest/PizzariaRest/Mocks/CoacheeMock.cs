using System;
using PizzariaRest.Models;
namespace PizzariaRest.Mocks
{
    public class CoacheeMock
    {

        public static Coachee CreateCoachee(string name, string gender)
        {
            Coachee coachee = new Coachee
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Gender = gender
            };

            return coachee;
        }


    }
}
