namespace BioscoopConsole.Domain
{
    public class MovieScreening
    {
        private DateTime DateAndTime { get; set; }
        private double PricePerSeat { get; set; }

        public MovieScreening(DateTime DateAndTime, double PricePerSeat)
        {
            this.DateAndTime = DateAndTime;
            this.PricePerSeat = PricePerSeat;
        }

        public double GetPricePerSeat() { }
        public string ToString() { }
    }
}
