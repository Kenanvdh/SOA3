using BioscoopConsole.Domain;

public class Program
{
    public static void Main(string[] args)
    {
        Movie movie = new Movie("Test 123", new List<MovieScreening>());
        MovieScreening movieScreening = new MovieScreening(DateTime.Now, 30.0, movie);
        List<MovieTicket> tickets = new() { 
                        new MovieTicket(1, 12, true, movieScreening),
                        new MovieTicket(5, 13, true, movieScreening),
                        new MovieTicket(2, 14, true, movieScreening),
                        new MovieTicket(3, 15, true, movieScreening),
                        new MovieTicket(4, 16, true, movieScreening)
        };
        Order order = new Order(12, true, tickets);
        order.Export(TicketExportFormat.JSON);
    }
}
