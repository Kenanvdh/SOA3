namespace BioscoopConsole.Domain
{
    public class Movie
    {
        private string Title { get; set; }

        public Movie(string Title)
        {
            this.Title = Title;
        }

        public void AddScreening(MovieScreening screening) { }

        public string ToString()
        {
            return "";
        }

    }
}
