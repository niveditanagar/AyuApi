using System;
using System.Collections.Generic;

namespace AyuApi.Interfaces
{
    public interface IFoodLogService
    {
        IList<string> GetFoodLog();

        void LogFoodItem(string foodItem);
    }
}
