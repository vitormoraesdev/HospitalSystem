using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class Address : IEquatable<Address>
    {
        public Address(string cep, string state, string city, string block, string number, string complement) 
        {
            Cep = cep;
            State = state;
            City = city;
            Block = block;
            Number = number;
            Complement = complement;
        }
        public string Cep { get;}
        public string State { get;}
        public string City { get;}
        public string Block { get;}
        public string Number { get;}
        public string Complement { get;}

        public override bool Equals(Object obj)
        {
            return Equals(obj as Address);
        }
        public bool Equals(Address other) 
        {
            if (other == null)
            {
                return false;
            }
            return Cep == other.Cep && State == other.State && City == other.City && Block == other.Block && Number == other.Number && Complement == other.Complement;
        }
    }
}
