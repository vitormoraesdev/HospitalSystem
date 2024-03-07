using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MedicalAppointment
    {
        public MedicalAppointment(int id, string description, Doctor doctor, Patient patient, AppointmentDate date)
        {
            Id = id;
            Description = description;
            Doctor = doctor;
            Patient = patient;
            Date = date;
        }

        public int Id { get; private set; }
        public string Description { get; private set; }
        public Doctor Doctor { get; private set; }
        public Patient Patient { get; private set; }
        public AppointmentDate Date { get; private set; }
    }
}
