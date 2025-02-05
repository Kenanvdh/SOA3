using System.Text;

namespace BioscoopConsole.Domain
{
    public class MovieScreening
    {
        private DateTime DateAndTime { get; set; }
        private double PricePerSeat { get; set; }
        private Movie Movie { get; set; }

        public MovieScreening(DateTime DateAndTime, double PricePerSeat, Movie movie)
        {
            this.DateAndTime = DateAndTime;
            this.PricePerSeat = PricePerSeat;
            this.Movie = movie;
        }

        public double GetPricePerSeat()
        {
            return this.PricePerSeat;
        }

        public DateTime GetDateAndTime()
        {
            return this.DateAndTime;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Movie.ToString());
            sb.AppendLine(DateAndTime.ToString());
            return sb.ToString();
        }
    }
}
