 using Developer.Exam.Core.Interfaces;

namespace Developer.Exam.Core.Entities
{
    public class Trade : ITrade
    {
        public Trade(string clientSector, double value, DateTime nextPaymentDate)
        {
            Value = value;
            ClientSector = clientSector;
            NextPaymentDate = nextPaymentDate;
        }

        public Trade(string data)
        {
            var arrData = data.Split(' ');

            double value;
            double.TryParse(arrData[0].ToString(), out value);
            Value = value;

            ClientSector = arrData[1];

            DateTime nextPaymentDate;
            DateTime.TryParse(arrData[2], out nextPaymentDate);
            NextPaymentDate = nextPaymentDate;
        }

        public string ClientSector { get; private set; }
        public double Value { get; private set; }
        public DateTime NextPaymentDate { get; private set; }
        public string Category { get; private set; }

        public void SetCategory(DateTime referenceDate)
        {
            if ((referenceDate - NextPaymentDate).Days >= 30) 
            {
                Category = "EXPIRED"; return;
            }            

            if (Value > 1000000D)
            {
                if (ClientSector == "Private")
                    Category = "HIGHRISK";

                if (ClientSector == "Public")
                    Category = "MEDIUMRISK";
            }
        }
    }
}
