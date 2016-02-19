using Cloudikka.Swapi.Conversion.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi {
    [JsonConverter(typeof(SwapiReferenceConverter))]
    public class SwapiEntityReference<T> : SwapiReference
        where T : SwapiObject, new() {
        [JsonIgnore()]
        public T Value {
            get;
            internal set;
        }
    }
}
