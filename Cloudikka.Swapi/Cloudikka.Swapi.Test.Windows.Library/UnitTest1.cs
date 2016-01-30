using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Threading.Tasks;
using Cloudikka.Swapi.Data;

namespace Cloudikka.Swapi.Test.Windows.Library
{
    [TestClass]
    public class UnitTest1 {
        private SwapiClient Client = new SwapiClient();

        [TestMethod]
        public async Task TestMethod1() {
            var reference = new SwapiReference<Character>() { Url = new Uri("http://swapi.co/api/people/1/") };
            var result = await Client.GetAsync<Character>(reference);
        }
    }
}
