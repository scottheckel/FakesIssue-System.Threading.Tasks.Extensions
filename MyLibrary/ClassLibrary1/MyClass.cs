using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ClassLibrary1
{
    public class MyClass
    {
        public async Task Fetch()
        {
            using (var httpClient = new HttpClient())
            {
                await Fetch(httpClient);
            }
        }

        public async Task Fetch(HttpClient httpClient)
        {
            var result = await httpClient.GetAsync("https://www.google.com?q=test");
        }
    }
}
