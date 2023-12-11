using System;

class Location:Library
{

    public List<string> deLocal = new List<string>();
    public List<string> deArea = new List<string>();

    //Method to get list of locations
    public List<string> deGetLocation(string deInfo)
    {
        
        deLocal.Add(deInfo);
        return deLocal;
    }

    //Method to set location
    public List<string> deSetLocation(string deList)
    {
        
        deArea.Add(deList);

        return deArea;
    }
}