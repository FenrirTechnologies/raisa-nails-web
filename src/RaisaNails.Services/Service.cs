using System;
using System.Collections.Generic;

namespace RaisaNails.Services
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public TimeSpan Duration { get; set; }
        public IEnumerable<ServicePrice> Prices { get; set; }
    }
}