using System;
class Player : Beings
{


    //use check for empty string just in case player enters no characters. Might need this logic in startup screen
    public int PlayerLevel { get; private set; }

    public Player(string name, int health, int damage) : base(name, health, damage)
    {
        PlayerLevel = 0;
    }
    public void LevelUp()
    {
        Health += 20;
        Damage += 2;
        PlayerLevel += 1;
    }
    public void PlayerInfo()
    {
        Console.WriteLine($"Your name is {Name}, your health is {Health}, and you deal {Damage} damage. Your current level is {PlayerLevel}");
    }


}