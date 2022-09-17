using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Boat : IInvestment
    {
        public int Length { get; set; }
        public int MeterPrice { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
        public int RegYear { get; set; }

        public Boat(int length, int meterPrice, string condition, string description, int regYear)
        {
            Length = length;
            MeterPrice = meterPrice;
            Condition = condition;
            Description = description;
            RegYear = regYear;  
        }

        public string InvestSummaray()
        {
            string res = $"Boat: {Description} Length={Length}";
            return res;
        }

        public int PriceCalculate()
        {
            int res = MeterPrice * Length;
            return res;
        }
    }
}
