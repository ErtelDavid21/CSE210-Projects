using System;
using System.Reflection;
using Microsoft.VisualBasic;

class Program
{
    public static void Main()
    {
        Console.WriteLine("This is the final Project");
        Boolean activate = true;
        do
        {
            Console.WriteLine("Do you want to open up your library? (yes or no)");
            string open = Console.ReadLine();
        

            // Determine if the Library is being used
            if (open.ToLower() == "yes")
            {
                //start the library
                Library user = new Library();
                
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("(1: Display Info, 2: Add Info, 3. Alter Info)");

                string task = Console.ReadLine();
                int choice = Convert.ToInt32(task);
                int toDo = 0;

                if (choice >= 1 || choice <= 3)
                {
                    toDo = choice;
                }

                user.StartLibrary(toDo);

                
            }
            if (open.ToLower() == "no")
            {
                //Quits the program

                Console.WriteLine("You have chosen to exit, have a good day");
                activate = false;
            }
            else
            {
                Console.WriteLine("Unrecognized input, please try again.");

            }
        }while (activate == true);
    }
    
        
    


    
    
}


/*Book Library

phrsical books
location
ebooks
movies
music
etc.*/
