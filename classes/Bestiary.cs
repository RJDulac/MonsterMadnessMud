using System;
public class Bestiary
{
    Random rnd = new Random();


    public Monsters[] MonsterGroup()
    {
        Combat combat = new Combat();

        Monsters goblin = new Monsters("Goblin", 40, rnd.Next(4, 10));
        Monsters orc = new Monsters("Orc", 50, rnd.Next(3, 15));
        Monsters skeleton = new Monsters("Skeleton", 50, rnd.Next(5, 11));
        Monsters witch = new Monsters("Witch");
        Monsters[] bestiary = { goblin, orc, skeleton, witch };
        return bestiary;
    }
    public Monsters GetMonsters()
    {
        Monsters[] bestiary = MonsterGroup();
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