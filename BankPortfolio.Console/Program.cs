using BankPortfolio.Console.Category;
using BankPortfolio.Console.Model;

DateTime referenceDate = DateTime.ParseExact(Console.ReadLine().Trim(), "MM/dd/yyyy", null);
int trades = Convert.ToInt32(Console.ReadLine().Trim());
var tradeList = new List<Trade>();

for (int trade = 0; trade < trades; trade++)
{
    var elements = Console.ReadLine().TrimEnd().Split(' ').ToList();

	tradeList.Add(new Trade()
	{
		Value = Convert.ToDouble(elements[0]),
		ClientSector = elements[1],
		NextPaymentData = DateTime.ParseExact(elements[2], "MM/dd/yyyy", null)
	});
}

foreach (var trade in tradeList)
{
	var category = new Category(trade, referenceDate);
	Console.WriteLine(category.SetCategory());
}