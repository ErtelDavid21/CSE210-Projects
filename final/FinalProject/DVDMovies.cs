using System;

class DVDMovies:Library
{

    public List<string> company = new List<string>();
    public List<string> movies = new List<string>();

    //Method to get list of companies who made the games
    public List<string> GetCompany(string info)
    {
        
        company.Add(info);
        return company;
    }

    //Method to get video game names
    public List<string> GetMovies(string list)
    {
    
        movies.Add(list);

        return movies;
    }
}