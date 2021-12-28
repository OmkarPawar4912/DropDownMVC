using DropDownMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace DropDownMVC.Controllers
{
    public class DorpDownController : Controller
    {
        //Load Country
        public IActionResult Index()
        {
            List<Country> countries = new List<Country>
            {
                new Country{Id=1,Name="India"},
                new Country{Id=2,Name="Japan"},
                new Country{Id=3,Name="Australia"}
            };

            ViewBag.Country = countries;
            return View();
        }

        //Load Distric (country wise)
        public JsonResult GetDistricByCountryId(int countryId)
        {
            var DistricList = GetDistric(countryId);

            var DistricData = DistricList.Select(m => new SelectListItem()
            {
                Value = m.Id.ToString(),
                Text = m.Name.ToString()
            });

            return new JsonResult(DistricData);
        }
        //Create Distric List
        private IList<Distric> GetDistric(int countryId)
        {
            IList<Distric> districs = new List<Distric>
            {
                new Distric{Id=1,CountryId=1,Name="Mumbai"},
                new Distric{Id=2,CountryId=1,Name="Delhi" },
                new Distric{Id=3,CountryId=1,Name="Chennai"},
                new Distric{Id=4,CountryId=2,Name="Hiroshima"},
                new Distric{Id=5,CountryId=2,Name="Koba"},
                new Distric{Id=6,CountryId=2,Name="Osaka"},
                new Distric{Id=7,CountryId=2,Name="Akita"},
                new Distric{Id=7,CountryId=3,Name="Cairns"},
                new Distric{Id=7,CountryId=3,Name="Mackay"},
                new Distric{Id=7,CountryId=3,Name="Brisbane"}
            };
            return districs.Where(m => m.CountryId == countryId).ToList();
        }

        //Load Cit (Distric wise)
        public JsonResult GetCityByDistricId(int districId)
        {
            var CityList = GetCity(districId);

            var CityData = CityList.Select(m => new SelectListItem()
            {
                Value = m.Id.ToString(),
                Text = m.Name.ToString()
            });

            return new JsonResult(CityData);
        }

        //Create City List
        private IList<City> GetCity(int districId)
        {
            IList<City> city = new List<City>
            {
                new City{Id=1,DistricId=1,Name="Andheri"},
              new  City {Id=2,DistricId=1,Name="Mira-Bhayandar"},
              new  City {Id=3,DistricId=1,Name="Bandra"},
              new  City {Id=4,DistricId=2,Name="Aali"},
              new  City {Id=5,DistricId=2,Name="Gheora"}
            };
            return city.Where(m => m.DistricId == districId).ToList();
        }
    }
}
