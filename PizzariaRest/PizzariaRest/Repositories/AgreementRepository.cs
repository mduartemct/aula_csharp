using System;
using System.Linq;
using PizzariaRest.Contexts;
using PizzariaRest.Interfaces;
using PizzariaRest.Models;

namespace PizzariaRest.Repositories
{
    public class AgreementRepository : IAgreementRepository
    {
        public AgreementRepository()
        {
        }

        public IQueryable<Agreement> AgreementQueryable()
        {
            throw new NotImplementedException();
        }

        public Agreement Create(Agreement agreement)
        {
            using (AgreementContext dbContext = new AgreementContext())
            {
                dbContext.Add(agreement);
                dbContext.SaveChanges();
            }
            return agreement;

        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Agreement Read(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(string id, Agreement agreement)
        {
            throw new NotImplementedException();
        }
    }
}
