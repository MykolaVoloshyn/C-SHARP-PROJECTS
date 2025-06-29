using System.Globalization;

namespace ConstructorSubmission
{
    internal class FootballClub
    {
        // Is needed to be able to call ToTitleCase method
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

        string Name, City; // Initializes variables

        // Constructor method with no parameters that is chained to constructor method with one parameter
        public FootballClub() : this("Tigers") { }

        // Constructor method with one parameter that is chained to constructor method with two parameters
        public FootballClub(string name) : this(name, "Seattle") { }

        // Constructor method with two parameters
        public FootballClub(string name, string city)
        {
            // Converts the passed argument name to titlecase and saves to the variable Name
            this.Name = textInfo.ToTitleCase(name);
            // Converts the passed argument city to titlecase and saves to the variable City
            this.City = textInfo.ToTitleCase(city);
        }

        // Returns a string with full name of the team 
        public string DisplayFullName()
        {
            return $"{this.City} {this.Name}";
        }
    }
}
