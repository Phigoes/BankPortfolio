using BankPortfolio.Console.Enum;
using BankPortfolio.Console.Interface;
using BankPortfolio.Console.Strategy.ConcreteStrategy;
using BankPortfolio.Console.Strategy.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPortfolio.Console.Category
{
    public class Category
    {
        private ITrade trade;
        private DateTime refereceDate;

        public Category(ITrade trade, DateTime referenceDate)
        {
            this.trade = trade;
            this.refereceDate = referenceDate;
        }

        public string SetCategory()
        {
            var context = new Context();
            if (this.trade.ClientSector == SectorEnum.Private.ToString())
            {
                context.SetStrategy(new SectorPrivate());
                return context.GetClientSector(this.trade, this.refereceDate);
            }
            else if (this.trade.ClientSector == SectorEnum.Public.ToString())
            {
                context.SetStrategy(new SectorPublic());
                return context.GetClientSector(this.trade, this.refereceDate);
            }

            return RiskEnum.UNKNOWNRISK.ToString();
        }
    }
}
