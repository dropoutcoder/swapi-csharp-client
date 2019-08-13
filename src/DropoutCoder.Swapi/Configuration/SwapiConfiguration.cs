using System;

namespace DropoutCoder.Swapi.Configuration {
    public class SwapiConfiguration {
        public SwapiConfiguration(Uri baseAddress) {
            if (baseAddress == null) {
                throw new ArgumentNullException(nameof(baseAddress));
            }

            this.BaseAddress = baseAddress;
        }

        public Uri BaseAddress {
            get;
            private set;
        }
    }
}
