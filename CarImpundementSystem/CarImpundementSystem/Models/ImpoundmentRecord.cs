namespace CarImpundementSystem.Models
{
    public class ImpoundmentRecord
    {
        public string recordId { get; set; }

        public DateTime date { get; set; }

        public string location { get; set; }

        public string reason { get; set; }

        public double payment { get; set; }

        public string status { get; set; }
    }
}
