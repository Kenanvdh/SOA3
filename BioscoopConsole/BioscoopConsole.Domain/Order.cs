namespace BioscoopConsole.Domain
{
    public class Order
    {
        private int OrderNr { get; set; }
        private bool IsStudentOrder { get; set; }

        public Order(int OrderNr, bool IsStudentOrder)
        {
            this.OrderNr = OrderNr;
            this.IsStudentOrder = IsStudentOrder;
        }

        public int GetOrderNr()
        {
            return this.OrderNr;
        }

        public void AddSeatReservation(MovieTicket ticket)
        {

        }

        public double CalculatePrice()
        {
            return 0.0;
        }

        public void Export(TicketExportFormat exportFormat)
        {

        }
    }
}
