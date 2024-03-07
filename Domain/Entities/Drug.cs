using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Drug
    {
        public Drug(int id, string name, string description, int stock)
        {
            Id = id;
            Name = name;
            Description = description;
            Stock = stock;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Stock {  get; private set; }
    }
}
