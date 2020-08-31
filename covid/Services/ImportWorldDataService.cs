using covid.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace covid.Services
{
    public class ImportWorldDataService
    {
        private readonly HttpClient _client;

        public ImportWorldDataService(HttpClient client)
        {
            _client = client;
        }

        public async void ImportWorldData()
        {
            var csvBytes = await _client.GetStringAsync("https://github.com/owid/covid-19-data/tree/master/public/data");
            using (var stringReader = new StringReader(csvBytes))
            {
                using (var csv = new CsvHelper.CsvReader(stringReader, CultureInfo.InvariantCulture))
                {
                    var parsedData = csv.GetRecordsAsync<CsvModel>();

                }
            }
        }
    }
}
