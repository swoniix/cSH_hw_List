using System;
using System.Collections.Generic;

abstract class SeaAnimal
{
    public string Name;
    public int Age;

    public SeaAnimal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract string Info();
}

class Dolphin : SeaAnimal
{
    public int SwimSpeed { get; set; }

    public Dolphin(string name, int age, int swimSpeed)
        : base(name, age)
    {
        SwimSpeed = swimSpeed;
    }

    public override string Info()
    {
        return $"Dolphin: {Name}, age: {Age}, speed: {SwimSpeed} km/h";
    }
}

class Shark : SeaAnimal
{
    public int TeethCount { get; set; }

    public Shark(string name, int age, int teethCount)
        : base(name, age)
    {
        TeethCount = teethCount;
    }

    public override string Info()
    {
        return $"Shark: {Name}, age: {Age}, teeth count: {TeethCount}";
    }
}

class Turtle : SeaAnimal
{
    public string ShellColor { get; set; }

    public Turtle(string name, int age, string shellColor)
        : base(name, age)
    {
        ShellColor = shellColor;
    }

    public override string Info()
    {
        return $"Turtle: {Name}, age: {Age}, shell color: {ShellColor}";
    }
}

class Oceanarium
{
    private List<SeaAnimal> residents = new List<SeaAnimal>();

    public void AddSeaItem(SeaAnimal item)
    {
        residents.Add(item);
    }

    public void ShowAllResidents()
    {
        foreach (SeaAnimal item in residents)
        {
            Console.WriteLine(item.Info());
        }
    }
}

class Player
{
    public string Name { get; set; }
    public int Number { get; set; }
    public string Position { get; set; }

    public Player(string name, int number, string position)
    {
        Name = name;
        Number = number;
        Position = position;
    }

    public override string ToString()
    {
        return $"Player: {Name}, number: {Number}, position: {Position}";
    }
}

class FootballTeam
{
    private List<Player> players = new List<Player>();

    public void AddPlayer(Player player)
    {
        players.Add(player);
    }

    public void ShowAllPlayers()
    {
        foreach (Player player in players)
        {
            Console.WriteLine(player);
        }
    }
}

class Program
{
    static void Main()
    {
        Oceanarium oceanarium = new Oceanarium();
        oceanarium.AddSeaItem(new Dolphin("Qiqi", 5, 40));
        oceanarium.AddSeaItem(new Shark("Megalodon", 8, 50));
        oceanarium.AddSeaItem(new Turtle("Ahaha", 20, "green"));

        Console.WriteLine("Sea Animals:");
        oceanarium.ShowAllResidents();

        FootballTeam team = new FootballTeam();
        team.AddPlayer(new Player("Player1", 10, "forward"));
        team.AddPlayer(new Player("Player2", 1, "goalkeeper"));

        Console.WriteLine("Team Players:");
        team.ShowAllPlayers();
    }
}