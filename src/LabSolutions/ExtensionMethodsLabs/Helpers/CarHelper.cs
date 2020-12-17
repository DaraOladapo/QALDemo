using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExtensionMethodsLabs.Helpers
{
    static class CarHelper
    {
        public static List<string> GetSortedMakes(this List<Car> cars)
        {
            var carNames = cars.OrderBy(c => c.Make).Select(c => c.Make).ToList();
            return carNames;
        }
    }
}
