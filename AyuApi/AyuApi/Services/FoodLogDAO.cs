using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AyuApi.Interfaces;
using Newtonsoft.Json;

namespace AyuApi.Services
{
    public class FoodLogDAO : IFoodLogDAO
    {
        private readonly string FileLocation;

        public FoodLogDAO()
        {
            FileLocation = "./FoodLog.json";
        }

        public IList<string> RetrieveFoodLog() {
            if (File.Exists(FileLocation))
            {
                string foodLogAsString = File.ReadAllText(FileLocation);
                if (string.IsNullOrEmpty(foodLogAsString))
                {
                    return new List<string>();
                }

                return JsonConvert.DeserializeObject<IList<string>>(foodLogAsString);
            }
            else
            {
                return new List<string>();
            }
        }

        public void SaveFoodLog(IList<string> foodLog) {
            if (File.Exists(FileLocation))
            {
                File.Delete(FileLocation);
            }

            string foodAsString = JsonConvert.SerializeObject(foodLog);

            File.Create(FileLocation);
            File.WriteAllText(FileLocation, foodAsString);
        }
    }
}
