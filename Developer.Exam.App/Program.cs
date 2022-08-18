using Developer.Exam.Application;
using Developer.Exam.Core.Services;

namespace Developer.Exam.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Initializer.Configure();

            Console.WriteLine("Input reference date");
            var strReferenceDate = Console.ReadLine();

            DateTime referenceDate;
            DateTime.TryParse(strReferenceDate, out referenceDate);

            Console.WriteLine("Input the number of trades in the portifolio");
            var strnumberOfTrade = Console.ReadLine();

            int numberOfTrade = 0;
            int.TryParse(strnumberOfTrade, out numberOfTrade);

            var sendAllTrades = true;
            List<string> Trades = new List<string>();

            int indexAllTrades = 0;

            while (sendAllTrades)
            {
                Console.WriteLine($"Input line {indexAllTrades + 1}");

                var inputTrade = Console.ReadLine();

                if (!string.IsNullOrEmpty(inputTrade))
                {
                    Trades.Add(inputTrade);
                    indexAllTrades++;
                }                 

                if(indexAllTrades == numberOfTrade)
                {
                    sendAllTrades = false;
                }
            }

            var tradeService = new TradeService();

            var result = tradeService.ClassifiedAllTrades(referenceDate, Trades);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Category}");
            }

            Console.ReadKey();
        }    
    }
}