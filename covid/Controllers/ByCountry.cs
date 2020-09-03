using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using covid.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace covid.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CovidData : ControllerBase
    {
        private readonly Db _db;

        public CovidData(Db db)
        {
            _db = db;
        }

        [HttpGet]
        public IEnumerable<CsvModel> ByCountry([FromQuery]string country)
        {
            return _db.Rows.Where(x => x.Location.ToLower() == country.ToLower());
        }
    }
}
