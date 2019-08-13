using System;

namespace DropoutCoder.Swapi.Configuration {
    internal class DefaultSwapiConfiguration : SwapiConfiguration {
        private static string baseAddress = "http://swapi.co/api/";

        internal static SwapiConfiguration Create() {
            var uri = new Uri(baseAddress);
            var config = new DefaultSwapiConfiguration(uri);
            return config;
        }

        internal DefaultSwapiConfiguration(Uri baseAddress)
            : base(baseAddress) {
        }
    }
}
