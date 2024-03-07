using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Bed
    {
        public Bed(int id, int numBed, bool busy)
        {
            Id = id;
            NumBed = numBed;
            Busy = busy;
        }

        public int Id { get; private set; }
        public int NumBed { get; private set; }
        public bool Busy { get; private set; }
    }
}
