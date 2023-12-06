using System;

class DVDMovies:Library
{
    //Method to get list of companies who made the games
    public List<string> GetCompany(string info)
    {
        List<string> company = new List<string>();
        company.Add(info);
        return company;
    }

    //Method to get video game names
    public List<string> GetMovies(string list)
    {
        List<string> movies = new List<string>();
        movies.Add(list);

        return movies;
    }
}