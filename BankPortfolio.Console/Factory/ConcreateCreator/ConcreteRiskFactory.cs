using BankPortfolio.Console.Factory.ConcreateRisk;
using BankPortfolio.Console.Factory.Creator;
using BankPortfolio.Console.Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPortfolio.Console.Factory.ConcreateCreator
{
    public class ConcreteRiskFactory : RiskFactory
    {
        public override IFactory GetRisk(string risk)
        {
            switch (risk)
            {
                case "HIGHRISK":
                    return new HighRisk();
                case "MEDIUMRISK":
                    return new MediumRisk();
                default:
                    throw new ApplicationException($"Risk {risk} cannot be created");
            }
        }
    }
}
