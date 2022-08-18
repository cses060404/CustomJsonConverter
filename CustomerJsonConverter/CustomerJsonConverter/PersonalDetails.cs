using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CustomerJsonConverter
{
    public class PersonalDetails
    {
        public PersonalDetails(string name, string SSN)
        {
            this.SSN = SSN;
            this.name = name;
        }

        public string name { get; set; }

        [JsonConverter(typeof(SSNMaskConverter))]
        public string SSN { get; set; }
    }
}
