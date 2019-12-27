using System;
class Player
{
    //fields
    private int health;
    //properties

    //use check for empty string just in case player enters no characters. Might need this logic in startup screen
    public string Name { get; private set; }
    public int Health
    {
        get { return health; }
        set
        {
            //do this for monster's health too -- use inheritance
            health = value;
            if (health <= 0)
            {
                health = 0;
            }
        }
    }
    public int Damage { get; private set; }

    public Player(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;

    }

    public string NamePlayer(string name)
    {
        Name = name;
        return Name;
    }
    public int DamageTaken(int num)
    {
        return Health = -num;
    }
    public int SetPlayerHealth(int num)
    {
        return Health = num;
    }
    public void LevelUp()
    {
        Health += 20;
        Damage += 2;
    }
    public void PlayerInfo()
    {
        Console.WriteLine($"Your name is {Name}, your health is {Health}, and you deal {Damage} damage.");
    }



}