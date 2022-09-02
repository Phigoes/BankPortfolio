using BankPortfolio.Console.Enum;
using BankPortfolio.Console.Factory.ConcreateCreator;
using BankPortfolio.Console.Factory.Creator;
using BankPortfolio.Console.Factory.Interface;
using BankPortfolio.Console.Interface;
using BankPortfolio.Console.Strategy.Interface;
using BankPortfolio.Console.Strategy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPortfolio.Console.Strategy.ConcreteStrategy
{
    public class SectorPrivate : IStrategy
    {
        public ClientRiskModel GetClientCategory(ITrade trade, DateTime referenceDate)
        {
            if (referenceDate.Subtract(trade.NextPaymentData).TotalDays > 30)
            {
                return new ClientRiskModel()
                {
                    Type = RiskEnum.EXPIRED.ToString()
                };
            }

            if (trade.Value > 1000000)
            {
                RiskFactory factory = new ConcreteRiskFactory();
                IFactory risk = factory.GetRisk(RiskEnum.HIGHRISK.ToString());

                return new ClientRiskModel()
                {
                    Type = risk.CalculateRisk()
                };
            }

            return new ClientRiskModel()
            {
                Type = RiskEnum.UNKNOWNRISK.ToString()
            };
        }
    }
}
