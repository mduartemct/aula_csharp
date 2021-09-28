using System;
using System.Collections.Generic;
using System.Linq;
using PizzariaRest.Models;
namespace PizzariaRest.Mocks
{
    public class CoacheeMock
    {
        static IList<Coachee> coacheeList = new List<Coachee>();

        public static Coachee CreateCoachee(string name, string gender, string email)
        {
            Coachee coachee = new Coachee
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Gender = gender,
                Email = email
            };
            coacheeList.Add(coachee);

            return coachee;
        }

        public static Coachee ReadCoachee(string id)
        {
            var ret = coacheeList.Where(xpto => xpto.Id == id).FirstOrDefault();
            if (ret == null)
            {
                throw new SystemException("404");
            }
            return ret;
        }

        public static IEnumerable<Coachee> ReadCoachees()
        {
            return coacheeList.ToList();
        }


        public static bool DeleteCoachee(string id)
        {
            var existCoachee = ReadCoachee(id);
            if (existCoachee == null)
            {
                return false;
            }
            coacheeList.Remove(existCoachee);
            return true;
        }


    }

}
