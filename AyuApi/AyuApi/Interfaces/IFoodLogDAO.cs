using System;
using System.Collections.Generic;

namespace AyuApi.Interfaces
{
    public interface IFoodLogDAO
    {
        IList<string> RetrieveFoodLog();

        void SaveFoodLog(IList<string> foodLog);
    }
}
