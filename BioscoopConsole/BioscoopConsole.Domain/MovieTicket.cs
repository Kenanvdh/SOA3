using System.Text;

namespace BioscoopConsole.Domain
{
    public class MovieTicket
    {
        private int RowNr { get; set; }
        private int SeatNr { get; set; }
        private bool IsPremium { get; set; }
        private MovieScreening screening { get; init; }

        public MovieTicket(int rowNr, int seatNr, bool isPremium, MovieScreening screening)
        {
            RowNr = rowNr;
            SeatNr = seatNr;
            IsPremium = isPremium;
            this.screening = screening;
        }

        public bool IsPremiumTicket()
        {
            if (IsPremium)
            {
                return true;
            }
            return false;
        }

        public bool IsWeekday()
        {
            if (screening.GetDateAndTime().DayOfWeek >= DayOfWeek.Monday || screening.GetDateAndTime().DayOfWeek <= DayOfWeek.Thursday)
            {
                return true;
            }
            return false;
        }

        public double GetPrice()
        {
            return screening.GetPricePerSeat();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(screening.ToString());
            sb.AppendLine("Row: " + RowNr);
            sb.AppendLine("Seat: " + SeatNr);
            sb.AppendLine("Is premium ticket: " + IsPremiumTicket());
            return sb.ToString();
        }
    }
}
