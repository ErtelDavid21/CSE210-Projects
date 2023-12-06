using System;

class Ebooks:Library
{
    //Method to get list of companies who made the games
    public List<string> GetAuthors(string info)
    {
        List<string> company = new List<string>();
        company.Add(info);
        return company;
    }

    //Method to get video game names
    public List<string> GetTitles(string list)
    {
        List<string> games = new List<string>();
        games.Add(list);

        return games;
    }
}