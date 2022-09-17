﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class House : IInvestment
    {
        public string Address { get; set; }
        public int SquareMeters { get; set; }
        public int SquareMeterPrice { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }

        public House(string address, int squareMeters, int squareMeterPrice, string condition, string description)
        {
            Address = address;
            SquareMeters = squareMeters;
            SquareMeterPrice = squareMeterPrice;
            Condition = condition;
            Description = description;
        }

        public int PriceCalculate()
        {
            int res = SquareMeters * SquareMeterPrice;
            return res;
        }

        public string InvestSummaray()
        {
            string res = $"House: {Address} Area={SquareMeters}";
            return res;
        }
    }
}