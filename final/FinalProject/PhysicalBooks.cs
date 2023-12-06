using System;

class PhysicalBooks:Library
{
    //Method to get list of companies who made the games
    public List<string> GetAuthor(string info)
    {
        List<string> author = new List<string>();
        author.Add(info);
        return author;
    }

    //Method to get video game names
    public List<string> GetBookTitle(string list)
    {
        List<string> books = new List<string>();
        books.Add(list);

        return books;
    }
}