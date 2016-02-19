using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi {
    public class SwapiCollectionReference<T> : SwapiReference
        where T : IEnumerable<SwapiReference>, new() {
        [JsonIgnore()]
        public T Value {
            get;
            internal set;
        }
    }
}
