using RaisaNails.Services;
using RaisaNails.Users;
using System;

namespace RaisaNails.Appointments
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public User Customer { get; set; }
        public int EmployeeId { get; set; }
        public User Employee { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public int ServicePriceId { get; set; }
        public ServicePrice ServicePrice { get; set; }
    }
}
