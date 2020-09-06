using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Model:BaseEntity
    {
        public string Name { get; set; }
        public int Year { get; set; }
        [JsonIgnore]
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
