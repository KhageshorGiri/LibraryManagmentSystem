using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Helper
{
    public class DateToDay
    {
        public double getDay(string date)
        {
             date = date.Replace("-", " ");
            var splitedValue = date.Split(" ");
            var year = Convert.ToDouble(splitedValue[0]);
            var month = Convert.ToDouble(splitedValue[1]);
            var day = Convert.ToDouble(splitedValue[2]);

            var totlDay = (year * 12 * 30) + (month * 30) + day;

            return totlDay;
        }
    }
}
