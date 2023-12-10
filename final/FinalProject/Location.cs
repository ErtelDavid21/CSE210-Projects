using System;

class Location:Library
{

    public List<string> local = new List<string>();
    public List<string> area = new List<string>();

    //Method to get list of companies who made the games
    public List<string> GetLocation(string info)
    {
        
        local.Add(info);
        return local;
    }

    //Method to get video game names
    public List<string> SetLocation(string list)
    {
        
        area.Add(list);

        return area;
    }
}