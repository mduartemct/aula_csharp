using System;
using System.Linq;
using PizzariaRest.Models;

namespace PizzariaRest.Interfaces
{
    public interface IAgreementRepository
    {
        Agreement Create(Agreement agreement);

        Agreement Read(string id);

        IQueryable<Agreement> AgreementQueryable();

        bool Delete(string id);

        bool Update(string id, Agreement agreement);

    }
}
