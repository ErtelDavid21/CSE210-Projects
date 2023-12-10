using System;

class VHSMovies:Library
{
    public List<string> company = new List<string>();
    public List<string> VHSmovies = new List<string>();

    //Method to get list of companies who made the games
    public List<string> AddCompanyInfo(string info)
    {
        
        company.Add(info);
        return company;
    }

    //Method to get video game names
    public List<string> AddMovies(string list)
    {
        
        VHSmovies.Add(list);

        return VHSmovies;
    }
}