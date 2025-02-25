﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccinationSystemApi.Models;
using VaccinationSystemApi.Dtos.Login;
using VaccinationSystemApi.Dtos.Admin;

namespace VaccinationSystemApi.Repositories.Interfaces
{
    public interface IVaccinationSystemRepository
    {
        IEnumerable<Patient> GetPatients();
        IEnumerable<Certificate> GetCertificates();
        Patient GetPatient(Guid id);
        IEnumerable<VaccinationCenter> GetCenters();
        VaccinationCenter GetCenter(Guid id);
        IEnumerable<Doctor> GetDoctors();
        Doctor GetDoctor(Guid id);
        VaccinationCenter GetCenterOfDoctor(Guid doctorId);
        IEnumerable<TimeSlot> GetTimeSlots();
        TimeSlot GetTimeSlot(Guid timeSlotId);
        IEnumerable<Appointment> GetNotCancelledAppointments();
        IEnumerable<Certificate> GetPatientCertificates(Guid patientId);
        Guid CreateAppointment(Guid patientId, Guid timeSlotId, Guid vaccineId);
        Appointment GetAppointment(Guid id);
        void CancelAppointment(Guid id);
        void CreateTimeSlot(TimeSlot timeSlot);
        void ConfirmVaccination(Guid appointmentId);
        Doctor GetDoctorByTimeSlot(Guid id);
        void DeleteTimeSlot(Guid id);
        void ReserveTimeSlot(Guid id);
        void ModifyTimeSlot(Guid timeSlotId, DateTime from, DateTime to);
        public IEnumerable<TimeSlot> GetDoctorActiveSlots(Guid doctorId, DateTime date);
        public IEnumerable<TimeSlot> GetDoctorTimeSlots(Guid doctorId);
        public IEnumerable<Appointment> GetPatientsIncomingAppointments(Guid patientId);
        public IEnumerable<Appointment> GetPatientsFormerAppointments(Guid patientId);
        public IEnumerable<Appointment> GetDoctorsIncomingAppointments(Guid doctorId);
        public IEnumerable<Appointment> GetDoctorsFormerAppointments(Guid doctorId);
        public IEnumerable<TimeSlot> FilterTimeslots(string city, DateTime dateFrom, DateTime dateTo, string virus);
        bool CreatePatient(RegisterRequest registerRequest, Guid guid = default(Guid));
        bool EditPatient(EditPatientRequest patientToEdit, out bool wasPatientFound);
        bool RemovePatient(Guid patientId);
        IEnumerable<Doctor> GetDoctorsWithMatchingVaccinationCentres();
        bool EditDoctor(EditDoctorRequest doctorData, out bool doctorFound);
        bool AddDoctor(Doctor doctorToAdd);
        bool DeleteDoctor(Guid DoctorId, out bool doctorFound);
        void CreateCertificate(Certificate certificateToAdd);
        void AddVaccinationBatchNumber(Guid appointmentId, string batchNumber);
        IEnumerable<string> GetViruses();
        IEnumerable<string> GetCities();
        IEnumerable<TimeSlot> GetDoctorsTimeSlots(Guid doctorId);
        void DeleteTimeslots(IEnumerable<Guid> TimeslotIds);
        IEnumerable<VaccinationCenter> GetVaccinationCenters();
        void AddVaccinationCenter(AddVaccinationCenterRequest centerToAdd);
        void EditVaccinationCenter(EditVaccinationCenterAdminRequest centerToEdit);
        void DeleteVaccinationCenter(Guid centerId);
        IEnumerable<Vaccine> GetExtendedVaccines();
        IEnumerable<Vaccine> GetVaccinesInCenter(Guid centerId);
        Virus GetVaccineVirus(Guid vaccineId);
        void AddVaccine(AddVaccineRequest vaccineToAdd);
        void EditVaccine(VaccineExtendedDTO updatedVaccine);
        void DeleteVaccine(Guid vaccineId);
        IEnumerable<Appointment> GetLastAppointments(Guid patientid);
        Patient GetPatientByEmail(string email);
    }
}
