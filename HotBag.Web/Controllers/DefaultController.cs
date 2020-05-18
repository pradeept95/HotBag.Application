using HotBag.AspNetCore.Authorization;
using HotBag.AspNetCore.ResultWrapper.ResponseModel;
using HotBag.AspNetCore.Web.BaseController;
using HotBag.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBag.Web.Controllers
{
    public class DefaultController : BaseApiController
    {
        public DefaultController()
        {

        }

        private static readonly string[] Summaries = new[]
       {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet]
        [HotBagAuthorize(HotBagClaimTypes.Permission, "WeatherForecast.Read")]
        public ListResultDto<WeatherForecast> Get()
        {
            var rng = new Random();
            var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToList();


            ////event bus publish test
            //publisher.Publish();

            ////email microservice test
            //_emailPublisher.PublishMessage(JsonConvert.SerializeObject(result));



            ////automapper test
            //var testEntity = new Person
            //{
            //    Id = Guid.NewGuid(),
            //    FirstName = "Pradeep",
            //    MiddleName = "Raj",
            //    LastName = "Thapaliya",
            //    Address = "8904 Jody Ln",
            //    DOB = DateTime.Now
            //};


            //var testEntityDto = _objectMapper.Map<PersonDto>(testEntity);
            //var ooPerson = _objectMapper.Map<Person>(testEntityDto);


            //var addressTest = new Address
            //{
            //    AddressLine1 = "8904 Jody Ln",
            //    AddressLine2 = "Apt 2B",
            //    City = "Des Plaines",
            //    State = "IL",
            //    Country = "United State"
            //};

            //var addressTestDto = _objectMapper.Map<AddressDto>(addressTest);
            //var ooAddressTestDto = _objectMapper.Map<Address>(addressTestDto);


            return new ListResultDto<WeatherForecast>(result, "all forecast data");
        }

    }
}
