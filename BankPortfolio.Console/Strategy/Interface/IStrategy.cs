using BankPortfolio.Console.Interface;
using BankPortfolio.Console.Strategy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPortfolio.Console.Strategy.Interface
{
    public interface IStrategy
    {
        ClientRiskModel GetClientCategory(ITrade trade, DateTime referenceDate);
    }
}
