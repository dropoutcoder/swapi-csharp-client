using Newtonsoft.Json;

namespace DropoutCoder.Swapi.Data {
    public class Vehicle : Craft {
        [JsonProperty("vehicle_class")]
        public string Class {
            get;
            set;
        }
    }
}
