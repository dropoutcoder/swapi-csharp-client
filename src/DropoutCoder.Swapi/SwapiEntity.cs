using System;
using Newtonsoft.Json;

namespace DropoutCoder.Swapi {
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
