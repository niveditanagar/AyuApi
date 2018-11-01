using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AyuApi.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AyuApi.Controllers
{
    [Route("api/food")]
    public class FoodItemController : ControllerBase
    {
        private readonly IFoodLogService foodLogService;

        public FoodItemController(IFoodLogService foodLogService) 
        {
            this.foodLogService = foodLogService;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return foodLogService.GetFoodLog();
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
            foodLogService.LogFoodItem(value);
        }
    }
}
