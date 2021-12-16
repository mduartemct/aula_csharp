using System;
using PizzariaRest.Interfaces;

namespace PizzariaRest.Models
{
    public class Agreement : IModel
    {

        public Agreement()
        {
            Id = Guid.NewGuid().ToString();
        }


        public string Id { get; set; }

        public DateTime StartDate { get; set; }

        public string Description { get; set; }


    }
}
