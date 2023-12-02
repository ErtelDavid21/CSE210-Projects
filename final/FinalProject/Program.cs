using System;
using System.Reflection;
using Microsoft.VisualBasic;

class Program
{
    public ManifestResourceAttributes()
    {
        Console.WriteLine("This is the final Project");
        do
        {
            Console.WriteLine("Do you want to open up your library? (yes or no)");
            string open = "access";
        
        

            if (open.ToLower() == "yes")
            {
                //start the library
                Library user = new Library();
            }
            if (open.ToLower() == "no")
            {
                //Quits the program

                Console.WriteLine("You have chosen to exit, have a good day");
                return false;
            }
            else
            {
                Console.WriteLine("Unrecognized input, please try again.");

            }
        }while (true);
    }
    
        
    


    
    
}


/*Book Library

phrsical books
location
ebooks
movies
music
etc.*/
