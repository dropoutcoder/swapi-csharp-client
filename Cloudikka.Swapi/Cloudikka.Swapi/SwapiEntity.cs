using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi {
    public abstract class SwapiEntity : SwapiObject {
        [JsonProperty("created")]
        public DateTime Created {
            get; set;
        }

        [JsonProperty("edited")]
        public DateTime Edited {
            get; set;
        }
    }
}
