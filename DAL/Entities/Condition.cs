using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Condition:BaseEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string ImagePath { get; set; }
        public string Note { get; set; }
        [JsonIgnore]
        public Vehicle Vehicle { get; set; }
    }
}
