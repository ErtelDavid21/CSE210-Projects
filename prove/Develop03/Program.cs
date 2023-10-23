using System;

class Program
{
    static void Main(string[] args)
    {   
        //Start by asking what the user wants to memorize
        Console.WriteLine("Please enter what you would like to study.");
        string studyMaterial = Console.ReadLine();
        
        Boolean truth = false;
        int compare;
        
        Scripture learn = new Scripture();
        learn.Referring();

        do
        {
            Console.WriteLine("hello");
            Console.WriteLine("Enter");
            string DEinput = Console.ReadLine();
            truth = int.TryParse(DEinput, out compare);
            
        } while (! truth);
        Console.WriteLine("You have finished, have a nice day.");
        
    }
}

/*
int i;
bool valid = false;
do {
    Console.WriteLine("Enter an int: ");
    string input = Console.ReadLine();
    valid = int.TryParse(input, out i);
} while(! valid);
*/