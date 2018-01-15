using System.Collections.Generic;

namespace RaisaNails.Services
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<ServicePrice> Prices { get; set; }
    }
}
