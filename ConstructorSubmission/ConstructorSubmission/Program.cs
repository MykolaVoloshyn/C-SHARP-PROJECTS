using ConstructorSubmission;


const string gameName = "Football Simulator 2025"; // Creates constant variable
// Prints welcome message in the console
Console.WriteLine($"Welcome to {gameName}.\nTo start create your football team.");
FootballClub userTeam; // Initiates a variable

Console.Write("\nType your team name or press 'Enter' to skip: ");
// Saves the user input after removing all white-spaces and converting it to lowercase
var userTeamName = Console.ReadLine().Trim().ToLower();

if (!string.IsNullOrEmpty(userTeamName)) // Checks if the userTeamName isn't empty
{
    Console.Write("\nType your team location or press 'Enter' to skip: ");
    // Saves the user input after removing all white-spaces and converting it to lowercase
    var userTeamCity = Console.ReadLine().Trim().ToLower();

    if (!string.IsNullOrEmpty(userTeamCity)) // Checks if the userTeamCity isn't empty
    {
        // Assigns a new instance of FootballClub class passing two arguments
        userTeam = new FootballClub(userTeamName, userTeamCity);
    }
    else
    {
        // Assigns a new instance of FootballClub class passing one argument
        userTeam = new FootballClub(userTeamName);
    }
}
else
{
    // Assigns a new instance of FootballClub class passing no arguments 
    // if the user did not input name of the team
    userTeam = new FootballClub();
}
// Prints a message to the user.
Console.WriteLine($"\nYou are now the manager of: {userTeam.DisplayFullName()}");

Console.WriteLine("Press any key to exit the program.");
Console.ReadKey();