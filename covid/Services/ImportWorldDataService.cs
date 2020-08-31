using covid.Models;
using CsvHelper.TypeConversion;
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
        private readonly Db _db;

        public ImportWorldDataService(HttpClient client, Db db)
        {
            _client = client;
            _db = db;
        }

        public async Task ImportWorldData()
        {
            try
            {
                var csvBytes = await _client.GetStringAsync("https://covid.ourworldindata.org/data/owid-covid-data.csv");
                using (var stringReader = new StringReader(csvBytes))
                {
                    using (var csv = new CsvHelper.CsvReader(stringReader, CultureInfo.InvariantCulture))
                    {
                        //csv.Configuration.HasHeaderRecord = true;
                        //csv.Configuration.PrepareHeaderForMatch = (s, i) => s.Trim();
                        //csv.Configuration.BadDataFound = (c) => { Console.WriteLine(c.CurrentIndex); };
                        //csv.Configuration.TypeConverterOptionsCache.GetOptions<DoubleConverter>().
                        _db.Rows.AddRange(csv.GetRecords<CsvModel>());
                        _db.SaveChanges();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
