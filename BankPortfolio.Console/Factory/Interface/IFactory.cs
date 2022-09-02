using BankPortfolio.Console.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPortfolio.Console.Factory.Interface
{
    public interface IFactory
    {
        public string CalculateRisk();
    }
}
