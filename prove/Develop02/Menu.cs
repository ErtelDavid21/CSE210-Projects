/* 
CSE210

Journal Menu
Journal Entry System
Navigate
Inputs: Write, Read, Load, Quit
Outputs: Declare which input was accepted

David Ertel
(c)2023
*/

using System;

class Menu
{
    static void Main(string[] args)
    {
        Boolean journalTask = false;
        while (journalTask != true)
        {
        
            // Ask for what the user would like to do.
            Console.WriteLine("What would you like to do?");

            // Give options for the user to choose
            Console.WriteLine("Type in: Write, Read, Load, Save, or Quit");

            //Obtain the users input
            string userRequest = Console.ReadLine();
        
        
            // Sort what request the user wants to do.
            if (userRequest.ToLower() == "quit")
            {
                Console.WriteLine("You have chosen to exit, come back soon.");
                journalTask = true;
            }

            else if (userRequest.ToLower() == "write")
            {
                Entry e = new Entry();
                e.Prompt();
                Console.WriteLine("You have chosen to write, please start typing.");
                string entry = Console.ReadLine();

            }

            else if (userRequest.ToLower() == "save")
            {
                List<string> Journal = new List<string>();
                Console.WriteLine("You have chosen to save the last entry");

            }

            else if (userRequest.ToLower() == "read")
            {
                Console.WriteLine("You have chosen to read entries");
            }

            else if (userRequest.ToLower() == "load")
            {
                Console.WriteLine("You have chosen to load a different Journal, enter in the journal name and location.");
                string loadJournal = Console.ReadLine();
            
            }

            // Failsafe to make sure user chooses 1 of the 5 valid inputs.
            else
            {
                Console.WriteLine("Input invalid, try again");

            }
        }
    
    }

    
}