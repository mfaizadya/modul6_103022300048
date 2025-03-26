// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        
        this.id = GenerateRandomId();
        this.title = title;
        this.playCount = 0;
    }

    private int GenerateRandomId()
    {
        Random random = new Random();
        return random.Next(10000, 99999);
    }

    public void IncreasePlayCount(int count)
    {
        this.playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Video details");
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("Title: " +  this.title);
        Console.WriteLine("Play count: " + this.playCount);
    }

    public int GetPlayCount()
    {
        return playCount;
    }

    public string GetTitle()
    {
        return title;
    }
}

public class SayaTubeUser
{
    private int id;
    public string username;
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public int GetTotalVideoPlayCount()
    {
        int totalPlayCount = 0;
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            totalPlayCount += uploadedVideos[i].GetPlayCount();
        }
        return totalPlayCount;
    }

    public void AddVideo(SayaTubeVideo stv)
    {
        this.uploadedVideos.Add(stv);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine($"User: {username}");
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}");
        }
    }

}

class Program
{
    static void
}



