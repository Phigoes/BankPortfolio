﻿using BankPortfolio.Console.Enum;
using BankPortfolio.Console.Factory.Interface;
using BankPortfolio.Console.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPortfolio.Console.Factory.ConcreateRisk
{
    public class HighRisk : IFactory
    {
        public string CalculateRisk()
        {
            return RiskEnum.HIGHRISK.ToString();
        }
    }
}
