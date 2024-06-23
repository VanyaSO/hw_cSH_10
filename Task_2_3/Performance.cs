namespace Task_2_3;

public class Performance : IDisposable
{
    public string Name { get; set; }
    public string Theatre { get; set; }
    public string Genre { get; set; }
    public int Duration { get; set; }
    public List<string> Actors { get; set; }

    public Performance(string name, string theatre, string genre, int duration, List<string> actors)
    {
        Name = name;
        Theatre = theatre;
        Genre = genre;
        Duration = duration;
        Actors = actors;
    }

    public override string ToString()
    {
        Console.WriteLine($"Название спектакля: {Name}");
        Console.WriteLine($"Театр: {Theatre}");
        Console.WriteLine($"Жанр: {Genre}");
        Console.WriteLine($"Длительность: {Duration}");
        Console.WriteLine("Актеры:");
        foreach (var actor in Actors)
        {
            Console.WriteLine($"{actor}");
        }

        return "";
    }

    public void Dispose()
    {
        Console.WriteLine("Спектакль закончился с помощью Dispose");
    }
    
    ~Performance()
    {
        Console.WriteLine("Спектакль закончился");
    }
}