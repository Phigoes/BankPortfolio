using BankPortfolio.Console.Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPortfolio.Console.Factory.Creator
{
    public abstract class RiskFactory
    {
        public abstract IFactory GetRisk(string risk);
    }
}
