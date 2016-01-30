using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi.Data {
    public class Vehicle : Craft {
        [JsonProperty("vehicle_class")]
        public string Class {
            get;
            set;
        }
    }
}
