using Developer.Exam.Core.Entities;
using Developer.Exam.Core.Interfaces;

namespace Developer.Exam.Core.Services
{
    public class TradeService : ITradeService
    {
        public TradeService()
        {

        }

        public List<Trade> ClassifiedAllTrades(DateTime referenceDate, List<string> arguments)
        {
            var result = new List<Trade>();

            foreach (var item in arguments)            {
                
                var newTrade = new Trade(item);
                newTrade.SetCategory(referenceDate);
                result.Add(newTrade);
            }   
            
            return result;
        }
    }
}
