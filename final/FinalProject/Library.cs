using System;
using System.Reflection.Metadata;

class Library
{

    // A list of info
    protected List<string> library = new List<string>();

    // Set up variables to call to each class
    private Ebooks digital         = new Ebooks();
    private PhysicalBooks physical = new PhysicalBooks();
    private Location place         = new Location();
    private DVDMovies dvd          = new DVDMovies();
    private VHSMovies vhs          = new VHSMovies();
    private VideoGame game         = new VideoGame();
    private Music sounds           = new Music();

    //Load info
    protected string ebook;
    protected string pbook;
    protected string locale;
    protected string oldMovieStudio;
    protected string newMovieStudio;
    protected string composer;
    protected string gaming;



    

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
        Console.WriteLine("");
    }

    public void SetLibrary()
    {
        Console.WriteLine("What would you like to add too?");
        Console.WriteLine("(1: Ebook, 2: Physical Book, 3: Location, 4: DVDs,");
        Console.WriteLine("5: VHS, 6: Music, 7: Video game");
        string addInfo = Console.ReadLine();
        int addTo = Convert.ToInt32(addInfo);

        if (addTo <=3 || addTo >=1)
        {
            // only cares about the inputs 1 to 3
            if (addTo == 1)
            {
                //call to Ebook info creator
                digital.DESetAuthors(ebook);
            }
            if (addTo == 2)
            {
                //call to Physical book info creator
            }
            else
            {
                // call to location info creator
            }
        }
        if (addTo <=7 || addTo >=4)
        {
            // only cares about the inputs from 4 to 7
        }
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
            digital.DEGetAuthors();
            List<string> pAuthor = physical.GetAuthor(pbook);
            Console.WriteLine("The Authors are: "," ",pAuthor);
            
        }
        if (info.ToLower() == "location")
        {
            // Calls Storage location info from Location.cs
            List<string> setting = place.GetLocation(locale);
            Console.WriteLine("The Locations are: ",setting);
            
        }
        if (info.ToLower() == "movie studio")
        {
            // Calls Movie Creator info from DVDMovies.cs and VHSMovies.cs
            List<string> newMovies = dvd.GetCompany(newMovieStudio);
            List<string> oldMovies = dvd.GetCompany(oldMovieStudio);
            Console.WriteLine("The Movie Studios you have movies from are: ");
        }
        if (info.ToLower() == "artist")
        {
            // Calls Artist info from Music.cs
            List<string> artist = sounds.GetArtist(composer);
        }
        if (info.ToLower() == "game company")
        {
            // Calls Video Game info from VideoGame.cs
            List<string> console = game.GetCompany(gaming);
        }
        else
        {
            // Not a valid input, so it doesn't go anywhere
            Console.WriteLine("The response given does not exist");
            Console.WriteLine("Would you like to try again?");
            
        }

    }
}
