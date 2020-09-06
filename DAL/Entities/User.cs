using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class User
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        public string UserRole { get; set; }

    }
}
