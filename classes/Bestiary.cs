using System;
public class Bestiary
{

    public Monsters[] MonsterGroup()
    {
        Monsters goblin = new Monsters("Goblin", 40, 5);
        Monsters orc = new Monsters("Orc", 50, 15);
        Monsters skeleton = new Monsters("Skeleton", 50, 3);
        Monsters witch = new Monsters("Witch");
        Monsters[] bestiary = { goblin, orc, skeleton, witch };
        return bestiary;
    }
    public Monsters GetMonsters()
    {
        Monsters[] bestiary = MonsterGroup();
        Random rnd = new Random();
        Monsters selectedMonster = bestiary[rnd.Next(bestiary.Length)];
        return selectedMonster;
    }
    public void DisplayBestiary()
    {
        Monsters[] bestiary = MonsterGroup();
        //list all monsters - list stats later
        foreach (Monsters monster in bestiary)
        {
            Console.WriteLine(monster.Name);
        }

    }
}