﻿using Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Doctor
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public SpecializationEnum? Specialization { get; private set; }
    }
}
