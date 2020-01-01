using System;
public class Monsters : Beings
{
    public Monsters(string name, int health, int damage) : base(name)
    {
        Health = health;
        Damage = damage;
    }
    public Monsters(string name) : this(name, 50, 5)
    {

    }
    public override void Info()
    {
        Console.WriteLine($"The monster's name is {Name}, his health is {Health}, and he deals {Damage} damage.");
    }

}