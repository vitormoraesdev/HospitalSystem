using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class Phone : IEquatable<Phone>
    {
        public Phone(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        public string PhoneNumber { get;}
        public override bool Equals(object obj)
        {
            return Equals(obj as Phone);
        }
        public bool Equals(Phone other)
        {
            return PhoneNumber == other.PhoneNumber;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(PhoneNumber);
        }
    }
}
