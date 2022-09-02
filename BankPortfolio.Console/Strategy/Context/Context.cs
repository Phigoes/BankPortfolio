using BankPortfolio.Console.Interface;
using BankPortfolio.Console.Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPortfolio.Console.Strategy.Context
{
    public class Context
    {
        private IStrategy _strategy;

        public Context()
        { }

        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public string GetClientSector(ITrade trade, DateTime refereceDate)
        {
            var result = this._strategy.GetClientCategory(trade, refereceDate);

            return result.Type;
        }
    }
}
