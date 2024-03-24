// See https://aka.ms/new-console-template for more information

class SayaTubeVideo
{
    private int id;
    private String title;
    private int playCount;

    public SayaTubeVideo(String title)
    {
        this.title = title;

        Random idrandom = new Random();
        id = idrandom.Next(10000, 99999);

        playCount = 0;
    }

    public void IncreasePlayCount(int tambahan)
    {
        playCount += tambahan;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("\n" + $"ID: {id}");
        Console.WriteLine($"Title Video: {title}");
        Console.WriteLine($"PlayCount Video: {playCount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("How To Make Doodle Artwork");
        SayaTubeVideo video2 = new SayaTubeVideo("Tutorial Design By Contract - Hasan Nurrahman Pane");

        video1.IncreasePlayCount(13022);
        video2.IncreasePlayCount(20031);

        video1.PrintVideoDetails();
        video2.PrintVideoDetails();
    }
}
