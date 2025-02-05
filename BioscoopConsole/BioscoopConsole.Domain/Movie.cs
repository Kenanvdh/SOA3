using System.Text;

namespace BioscoopConsole.Domain
{
    public class Movie
    {
        private string Title { get; set; }
        private List<MovieScreening> Screens { get; set; }

        public Movie(string Title, List<MovieScreening> screens)
        {
            this.Title = Title;
            this.Screens = screens;
        }

        public void AddScreening(MovieScreening screening) {
            this.Screens.Add(screening);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Title);
            return sb.ToString();
        }

    }
}
