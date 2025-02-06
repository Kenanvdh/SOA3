using System.Text.Json;
using Newtonsoft.Json;

namespace BioscoopConsole.Domain
{
    public class Order
    {
        private int OrderNr { get; set; }
        private bool IsStudentOrder { get; set; }
        public List<MovieTicket> tickets { get; set; }

        public Order(int OrderNr, bool IsStudentOrder, List<MovieTicket> movieTickets)
        {
            this.OrderNr = OrderNr;
            this.IsStudentOrder = IsStudentOrder;
            this.tickets = movieTickets;
        }

        public int GetOrderNr()
        {
            return this.OrderNr;
        }

        public void AddSeatReservation(MovieTicket ticket)
        {
            tickets.Add(ticket);
        }

        public double CalculatePrice()
        {
            double totalPrice = 0;

            var numOfTickets = tickets.Count;

            for (int i = 0; i < tickets.Count(); i++)
            {
                double price = tickets[i].GetPrice();
                if (i % 2 == 1 && (IsStudentOrder || tickets[i].IsWeekday()))
                {
                    price = 0;
                }

                if (IsStudentOrder && tickets[i].IsPremiumTicket())
                {
                    price += 2;
                }

                else if (!IsStudentOrder && tickets[i].IsPremiumTicket())
                {
                    price += 3;
                }

                totalPrice += price;

                if (numOfTickets >= 6 && !IsStudentOrder && !tickets[i].IsWeekday())
                {
                    totalPrice *= 0.9;
                }
            }

            return totalPrice;
        }

        public void Export(TicketExportFormat exportFormat)
        {
            string content = string.Empty;
            string fileName = $"Order_{OrderNr}.{(exportFormat == TicketExportFormat.JSON ? "json" : "txt")}";

            if (exportFormat == TicketExportFormat.JSON)
            {
                content += JsonConvert.SerializeObject(tickets);
            }
            else
            {
                foreach (var ticket in tickets)
                {
                    content += ticket.ToString();
                }
            }

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"{fileName}");

            File.WriteAllText(path, content);
            Console.WriteLine($"Order exported to {path}");
        }
    }
}


