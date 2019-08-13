using System;
using Newtonsoft.Json;

namespace DropoutCoder.Swapi {
    public abstract class SwapiReference {
        [JsonProperty("url")]
        public Uri Url {
            get;
            set;
        }
    }
}
