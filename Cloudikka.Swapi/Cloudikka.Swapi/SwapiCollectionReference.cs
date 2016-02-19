using Cloudikka.Swapi.Conversion.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi {
    [JsonConverter(typeof(SwapiReferenceConverter))]
    public class SwapiCollectionReference<T> : SwapiReference
        where T : SwapiEntity, new() {
        [JsonIgnore()]
        public SwapiCollection<T> Value {
            get;
            internal set;
        }
    }
}
