using DropoutCoder.Swapi.Conversion.Json;
using Newtonsoft.Json;

namespace DropoutCoder.Swapi {
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
