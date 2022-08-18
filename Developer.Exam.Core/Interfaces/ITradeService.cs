using Developer.Exam.Core.Entities;

namespace Developer.Exam.Core.Interfaces
{
    public interface ITradeService
    {
        List<Trade> ClassifiedAllTrades(DateTime referenceDate, List<string> arguments);
    }
}
