class Program
{
    static void Main()
    {
        List<string> actors = new List<string> { "Актер 1", "Актер 2", "Актер 3" };
        Performance performance1 = new Performance("Ромео и Джульетта", "Национальный театр", "Драма", 120, actors);
        
        performance1.PrintInfo();
    }
}