using System;
using Newtonsoft.Json;

namespace DropoutCoder.Swapi.Data {
    public abstract class SwapiReference {
        [JsonProperty("url")]
        public Uri Url {
            get;
            internal set;
        }
    }
}
