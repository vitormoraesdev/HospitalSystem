using Domain.Enumerations;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Patient
    {
        public Patient(int id, string name, int age, Sex patientSex, Address addressPatient)
        {
            Id = id;
            Name = name;
            Age = age;
            PatientSex = patientSex;
            AddressPatient = addressPatient;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Sex PatientSex { get; private set; }
        public Address AddressPatient { get; private set; }
    }
}
