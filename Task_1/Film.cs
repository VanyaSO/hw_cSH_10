public class Film: IDisposable
{
    public string Name { get; set; }
    public string Studio { get; set; }
    public string Genre { get; set; }
    public int Duration { get; set; }
    public int Year { get; set; }

    public Film(string name, string studio, string genre, int duration, int year)
    {
        Name = name;
        Studio = studio;
        Genre = genre;
        Duration = duration;
        Year = year;
    }

    public override string ToString()
    {
        Console.WriteLine($"Название: {Name}");
        Console.WriteLine($"Киностудия: {Studio}");
        Console.WriteLine($"Жанр: {Genre}");
        Console.WriteLine($"Длительность: {Duration}");
        Console.WriteLine($"Год: {Year}");
        return "";
    }

    public void Dispose()
    {
        Console.WriteLine("Фильм удален c помощью Dispose");
    }

    ~Film()
    {
        Console.WriteLine("Фильм удален");
    }
}