using System;

class VideoGame:Library
{
    //Method to get list of companies who made the games
    public List<string> GetCompany(string info)
    {
        List<string> company = new List<string>();
        company.Add(info);
        return company;
    }

    //Method to get video game names
    public List<string> GetGameNames(string list)
    {
        List<string> games = new List<string>();
        games.Add(list);

        return games;
    }
}