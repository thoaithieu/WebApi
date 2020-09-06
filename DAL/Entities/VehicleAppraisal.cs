using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class VehicleAppraisal:BaseEntity
    {
        public int VehicleId { get; set; }
        public double AppraiseValue { get; set; }

        [JsonIgnore]
        public Vehicle Vehicle { get; set; }
    }
}
