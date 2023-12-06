using System;

class Music:Library
{
    //Method to get artist list
    public List<string> GetArtist(string info)
    {
        List<string> creator = new List<string>();
        creator.Add(info);
        return creator;
    }

    //Method to get song names
    public List<string> GetSongNames(string names)
    {
        List<string> songs = new List<string>();
        songs.Add(names);

        return songs;
    }
}