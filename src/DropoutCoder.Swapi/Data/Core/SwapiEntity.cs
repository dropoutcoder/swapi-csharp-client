using System;
using Newtonsoft.Json;

namespace DropoutCoder.Swapi.Data {
    public abstract class SwapiEntity : SwapiObject {
        [JsonProperty("created")]
        public DateTime Created {
            get; internal set;
        }

        [JsonProperty("edited")]
        public DateTime Edited {
            get; internal set;
        }
    }
}
