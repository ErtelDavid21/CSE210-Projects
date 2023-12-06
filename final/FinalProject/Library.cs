using System;
using System.Reflection.Metadata;

class Library
{

    // A list of info
    protected List<string> library = new List<string>();

    

    public int StartLibrary(int task)
    {
        
        
        if (task == 1)
        {
            Console.WriteLine("You want to see the Library info");
            return task;
        }
        if (task == 2)
        {
            Console.WriteLine("You want to add info to your Library");
            return task;
        }
        if (task == 3)
        {
            Console.WriteLine("You want to change info given");
            return task;
        }
        else
        {
            Console.WriteLine("You have chosen a task that doesn't exist");
            return task;
        }

    }

    public void GetLibrary()
    {
        Console.WriteLine("What would you like to add too?");
    }

    // Set up variables to call to each class
    private Ebooks digital         = new Ebooks();
    private PhysicalBooks physical = new PhysicalBooks();
    private Location place         = new Location();
    private DVDMovies dvd          = new DVDMovies();
    private VHSMovies vhs          = new VHSMovies();
    private VideoGame game         = new VideoGame();
    private Music sounds           = new Music();

    public void DisplayInfo()
    {
        // Asks the user what they want to see and displays it
        Console.WriteLine("What info do you want displayed?");
        Console.WriteLine("(Author, Location, Movie Studio, Artist, Game Company)");

        string info = Console.ReadLine();

        if (info.ToLower() == "author")
        {
            // Calls author info from Ebooks.cs and PhysicalBooks.cs
            List<string> eAuthor = digital.GetAuthors(library);
            List<string> pAuthor = physical.GetAuthor(library);
            Console.WriteLine("The Authors are: ",eAuthor," ",pAuthor);
            
        }
        if (info.ToLower() == "location")
        {
            // Calls Storage location info from Location.cs
            List<string> setting = place.GetLocation(library);
            Console.WriteLine("The Locations are: ",setting);
            
        }
        if (info.ToLower() == "movie studio")
        {
            // Calls Movie Creator info from DVDMovies.cs and VHSMovies.cs
            List<string> newMovies = dvd.GetCompany(library);
            List<string> oldMovies = dvd.GetCompany(library);
            Console.WriteLine("The Movie Studios you have movies from are: ");
        }
        if (info.ToLower() == "artist")
        {
            // Calls Artist info from Music.cs
            List<string> artist = sounds.GetArtist(library);
        }
        if (info.ToLower() == "game company")
        {
            // Calls Video Game info from VideoGame.cs
            List<string> console = game.GetCompany(library);
        }
        else
        {
            // Not a valid input, so it doesn't go anywhere
            Console.WriteLine("The response given does not exist");
            Console.WriteLine("Would you like to try again?");
            
        }

    }
}
