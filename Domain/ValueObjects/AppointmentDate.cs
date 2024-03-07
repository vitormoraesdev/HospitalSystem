using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class AppointmentDate : IEquatable<AppointmentDate>
    {
        public AppointmentDate(DateTime dateTime)
        {
            DateTime = dateTime;
        }

        public DateTime DateTime { get;}
        public override bool Equals(object obj)
        {
            return Equals(obj as AppointmentDate);
        }

        public bool Equals(AppointmentDate other)
        {
            return DateTime == other.DateTime;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(DateTime);
        }
    }
}
