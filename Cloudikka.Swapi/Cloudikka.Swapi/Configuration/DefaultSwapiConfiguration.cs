using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi.Configuration {
    internal class DefaultSwapiConfiguration : SwapiConfiguration {
        private static string baseAddress = "http://swapi.co/api/";

        internal static SwapiConfiguration Create() {
            var uri = new Uri(baseAddress);
            var config = new DefaultSwapiConfiguration(uri);
            return config;
        }

        internal DefaultSwapiConfiguration(Uri baseAddress)
            : base(baseAddress){
        }
    }
}
