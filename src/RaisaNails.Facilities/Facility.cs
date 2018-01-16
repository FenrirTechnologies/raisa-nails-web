using RaisaNails.Services;
using System.Collections.Generic;

namespace RaisaNails.Facilities
{
    public class Facility
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public IEnumerable<Service> Services { get; set; }
    }
}