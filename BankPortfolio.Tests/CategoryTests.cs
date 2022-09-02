using BankPortfolio.Console.Category;
using BankPortfolio.Console.Enum;
using BankPortfolio.Console.Model;

namespace BankPortfolio.Tests
{
    public class CategoryTests
    {
        [Theory]
        [InlineData(2000000, "Private", "12/29/2025", "12/11/2020")]
        public void Shoud_Return_HighRisk(double value, string clientSector, string nextPaymentData, string referenceDate)
        {
            //Arrange
            var trade = new Trade()
            {
                Value = value,
                ClientSector = clientSector,
                NextPaymentData = DateTime.ParseExact(nextPaymentData, "MM/dd/yyyy", null)
            };

            //Act
            var category = new Category(trade, DateTime.ParseExact(referenceDate, "MM/dd/yyyy", null));

            //Assert
            Assert.Equal(category.SetCategory(), RiskEnum.HIGHRISK.ToString());
        }

        [Theory]
        [InlineData(400000, "Public", "07/01/2020", "12/11/2020")]
        public void Shoud_Return_Expired(double value, string clientSector, string nextPaymentData, string referenceDate)
        {
            //Arrange
            var trade = new Trade()
            {
                Value = value,
                ClientSector = clientSector,
                NextPaymentData = DateTime.ParseExact(nextPaymentData, "MM/dd/yyyy", null)
            };

            //Act
            var category = new Category(trade, DateTime.ParseExact(referenceDate, "MM/dd/yyyy", null));

            //Assert
            Assert.Equal(category.SetCategory(), RiskEnum.EXPIRED.ToString());
        }

        [Theory]
        [InlineData(5000000, "Public", "01/02/2024", "12/11/2020")]
        public void Shoud_Return_MediumRisk(double value, string clientSector, string nextPaymentData, string referenceDate)
        {
            //Arrange
            var trade = new Trade()
            {
                Value = value,
                ClientSector = clientSector,
                NextPaymentData = DateTime.ParseExact(nextPaymentData, "MM/dd/yyyy", null)
            };

            //Act
            var category = new Category(trade, DateTime.ParseExact(referenceDate, "MM/dd/yyyy", null));

            //Assert
            Assert.Equal(category.SetCategory(), RiskEnum.MEDIUMRISK.ToString());
        }
    }
}
