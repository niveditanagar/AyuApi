using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AyuApi.Interfaces;
using Newtonsoft.Json;

namespace AyuApi.Services
{
    public class FoodLogService : IFoodLogService
    {
        private readonly IFoodLogDAO foodLogDAO;

        private IList<string> foodLog;

        public FoodLogService(IFoodLogDAO foodLogDAO)
        {
            this.foodLogDAO = foodLogDAO;
            foodLog = foodLogDAO.RetrieveFoodLog();
        }

        public IList<string> GetFoodLog()
        {
            return foodLog;
        }

        public void LogFoodItem(string foodItem)
        {
            foodLog.Add(foodItem);

            foodLogDAO.SaveFoodLog(foodLog);
        }
    }
}
