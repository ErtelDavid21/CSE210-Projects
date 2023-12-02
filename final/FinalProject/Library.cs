using System;

class Library: Ebooks, DVDMovies, Location, PhysicalBooks, VHSMovies, VideoGame
{
    public void GetLibrary()
    {

    }

    public void DisplayInfo()
    {
        // Asks the user what they want to see and displays it
        Console.WriteLine("What info do you want displayed?");
        Console.WriteLine("(Author, Location, Movie Studio, Artist, Game Company)");

        string info = Console.ReadLine();

        if (info.ToLower() == "author")
        {
            // Calls author info from Ebooks.cs and PhysicalBooks.cs
        }
        if (info.ToLower() == "location")
        {
            // Calls Storage location info from Location.cs
        }
        if (info.ToLower() == "movie studio")
        {
            // Calls Movie Creator info from DVDMovies.cs and VHSMovies.cs
        }
        if (info.ToLower() == "artist")
        {
            // Calls Artist info from Music.cs
        }
        if (info.ToLower() == "game company")
        {
            // Calls Video Game info from VideoGame.cs
        }
        else
        {
            // Not a valid input, so it doesn't go anywhere
            Console.WriteLine("The response given does not exist");
            Console.WriteLine("Would you like to try again?");
            
        }

    }
}
