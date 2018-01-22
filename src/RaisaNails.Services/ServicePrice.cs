using System;

namespace RaisaNails.Services
{
    public class ServicePrice
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EffectiveDate { get; set; }
    }
}
