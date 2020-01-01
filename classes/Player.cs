using System;
public class Player : Beings
{


    //use check for empty string just in case player enters no characters. Might need this logic in startup screen
    public int PlayerLevel { get; private set; }
    public int Gold { get; private set; }
    //set default health and damage. Not needed in constructor - just name is needed
    public Player(string name) : base(name)
    {
        Health = 100;
        Damage = 10;
        Gold = 100;
        PlayerLevel = 0;
    }
    public void LevelUp()
    {
        Health += 20;
        Damage += 2;
        PlayerLevel += 1;
    }
    public override void Info()
    {
        Console.WriteLine($"Your name is {Name}, your health is {Health}, and you deal {Damage} damage. Your current level is {PlayerLevel}. You have {Gold} gold!");
    }
    public void GoldReward(int num) => Gold += num;
    public void GoldLost(int num) => Gold -= num;



}