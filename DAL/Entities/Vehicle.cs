using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Vehicle:BaseEntity
    {
        public int CustomerId { get; set; }
        public int ModelId { get; set; }
        public int ManufactorId { get; set; }
        public string VIN { get; set; }
        public int CurrentMeter { get; set; }
        [JsonIgnore]
        public Customer Customer { get; set; }
        [JsonIgnore]
        public Model Model { get; set; }
        [JsonIgnore]
        public Manufactor Manufactor { get; set; }
        [JsonIgnore]
        public ICollection<Condition> Conditions { get; set; }
        [JsonIgnore]
        public ICollection<VehicleAppraisal> VehicleAppraisals { get; set; }
    }
}
