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
    public class DownloadUnitTest {
        private SwapiClient Client = new SwapiClient();

        [TestMethod]
        public async Task GetAllTest() {
            var reference = new SwapiEntityReference<Root>() { Url = new Uri("http://swapi.co/api/") };
            var root = await Client.GetAllAsync();
            var result = root;
        }
    }
}
