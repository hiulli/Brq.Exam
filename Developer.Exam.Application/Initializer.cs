using System.Globalization;

namespace Developer.Exam.Application
{
    public class Initializer
    {
        public static void Configure()
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US", true);            
        }
    }
}