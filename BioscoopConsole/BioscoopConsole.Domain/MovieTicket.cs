namespace BioscoopConsole.Domain
{
    public class MovieTicket
    {
        private int RowNr { get; set; }
        private int SeatNr { get; set; }
        private bool IsPremium { get; set; }

        public MovieTicket(int rowNr, int seatNr, bool isPremium)
        {
            RowNr = rowNr;
            SeatNr = seatNr;
            IsPremium = isPremium;
        }

        public bool IsPremiumTicket()
        {
            if (IsPremium)
            {
                return true;
            }
            return false;
        }

        public double getPrice()
        {
            return 0.0;
        }

        public string ToString()
        {
            return "";
        }
    }
}
