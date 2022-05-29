﻿using System;

namespace VaccinationSystemApi.Dtos.Admin
{
    public class EditDoctorRequest
    {
        public Guid DoctorId { get; set; }
        public string PESEL { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public bool Active { get; set; }
        public Guid VaccinationCenterID { get; set; }
    }
}