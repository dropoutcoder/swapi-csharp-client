using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi {
    public abstract class SwapiObject {
        [JsonProperty("url")]
        public Uri Url {
            get;
            set;
        }
    }
}
