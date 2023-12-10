using System;

class Ebooks:Library
{

    public List<string> DEauthor = new List<string>();
    public List<string> DEtitle = new List<string>();

    //Method to get list of companies who made the title
    public List<string> DESetAuthors(string DEinfo)
    {
        
        DEauthor.Add(DEinfo);
        return DEauthor;
    }

    //Method to list titles
    public List<string> DESetTitles(string DElist)
    {
        
        DEtitle.Add(DElist);

        return DEtitle;
    }

    //Tell the Authors
    public void DEGetAuthors()
    {
        Console.WriteLine("Do you want the full list or an individual point? (1:Full, 2:Individual)");
        string DEshow = Console.ReadLine();
        int DEpoints = Convert.ToInt32(DEshow);

        if (DEpoints == 1)
        {
            Console.WriteLine("The list of Authors is ",DEauthor);
        }
        if (DEpoints == 2)
        {
            Console.WriteLine("What point in the list do you want to find?");
            string DElistPoint = Console.ReadLine();
            int DEfound = Convert.ToInt32(DElistPoint);

            Console.WriteLine("The author listed at point ",DEfound," is ",DEauthor[DEfound]);
        }
    }
}