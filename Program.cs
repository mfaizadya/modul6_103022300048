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
        try
        {
            if (title == null)
            {
                throw new ArgumentException("Judul tidak boleh kosong");
            }
            if (title.Length > 200)
            {
                throw new ArgumentException("Judul tidak boleh lebih dari 200 kata");
            }
            this.id = GenerateRandomId();
            this.title = title;
            this.playCount = 0;
        } catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        
    }

    private int GenerateRandomId()
    {
        Random random = new Random();
        return random.Next(10000, 99999);
    }

    public void IncreasePlayCount(int count)
    {
        try
        {
            if (count > 25000000)
            {
                throw new ArgumentException("Penambahan play count tidak boleh lebih dari 25000000");
            }
            if (count < 0)
            {
                throw new ArgumentException("Penambahan play count tidak boleh kurang dari 0");
            }
            checked
            {
                this.playCount += count;
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Terjadi overflow saat menambah play count");
        }

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
        try
        {
            if (username == null)
            {
                throw new ArgumentException("Username tidak boleh kosong");
            }
            if (username.Length > 100)
            {
                throw new ArgumentException("Username tidak boleh lebih dari 100 karakter");
            }

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        } catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        
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
        try
        {
            if (stv == null)
            {
                throw new ArgumentException("Video kosong");
            }
            this.uploadedVideos.Add(stv);
        } catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
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
    static void Main(string[] args)
    {
        SayaTubeUser userFaiz = new SayaTubeUser("Faiz");

        SayaTubeVideo film1 = new SayaTubeVideo("Review Film Oppenheimer oleh Faiz");
        film1.IncreasePlayCount(100000);
        userFaiz.AddVideo(film1);

        SayaTubeVideo film2 = new SayaTubeVideo("Review Film Interstellar oleh Faiz");
        film1.IncreasePlayCount(100000);
        userFaiz.AddVideo(film2);

        SayaTubeVideo film3 = new SayaTubeVideo("Review Film Avengers oleh Faiz");
        film1.IncreasePlayCount(100000);
        userFaiz.AddVideo(film3);

        SayaTubeVideo film4 = new SayaTubeVideo("Review Film Batman: The Dark Knight oleh Faiz");
        film1.IncreasePlayCount(100000);
        userFaiz.AddVideo(film4);

        SayaTubeVideo film5 = new SayaTubeVideo("Review Film Fight Club oleh Faiz");
        film1.IncreasePlayCount(100000);
        userFaiz.AddVideo(film5);

        SayaTubeVideo film6 = new SayaTubeVideo("Review Film The Incridible oleh Faiz");
        film1.IncreasePlayCount(100000);
        userFaiz.AddVideo(film6);

        SayaTubeVideo film7 = new SayaTubeVideo("Review Film Despicable Me oleh Faiz");
        film1.IncreasePlayCount(100000);
        userFaiz.AddVideo(film7);

        SayaTubeVideo film8 = new SayaTubeVideo("Review Film Cars oleh Faiz");
        film1.IncreasePlayCount(100000);
        userFaiz.AddVideo(film8);

        SayaTubeVideo film9 = new SayaTubeVideo("Review Film The Silent Voice oleh Faiz");
        film1.IncreasePlayCount(100000);
        userFaiz.AddVideo(film9);

        SayaTubeVideo film10 = new SayaTubeVideo("Review Film Ratatouile oleh Faiz");
        film1.IncreasePlayCount(100000);
        userFaiz.AddVideo(film10);

        film1.PrintVideoDetails();

        Console.WriteLine($"Total play count: {userFaiz.GetTotalVideoPlayCount()}");

        userFaiz.PrintAllVideoPlayCount();

    }
}



