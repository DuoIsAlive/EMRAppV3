﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMRAppV3.Models
{
    public class PatientInfo
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string Name { get; set; }
        public Gender Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public byte CityId { get; set; }
        public City Cities { get; set; }
        public DateTime DateTime { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }


        public int Age
        {
            get
            {
                var now = DateTime.Today;
                var age = now.Year - BirthDate.Year;
                if (BirthDate > now.AddYears(-age)) age--;
                return age;
            }
        }
        public ICollection<Appointment> Appointments { get; set; }


        //public Patient()
        //{
        //    Appointments = new Collection<Appointment>();
        //}


    }
}