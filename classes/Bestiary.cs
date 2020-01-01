using System;
public class Bestiary
{
    public Monsters GetMonsters()
    {
        Monsters goblin = new Monsters("Goblin", 40, 5);
        Monsters orc = new Monsters("Orc", 50, 15);
        Monsters skeleton = new Monsters("Skeleton", 50, 3);
        Monsters witch = new Monsters("Witch");
        Monsters[] bestiary = { goblin, orc, skeleton, witch };
        Random rnd = new Random();
        Monsters selectedMonster = bestiary[rnd.Next(bestiary.Length)];
        return selectedMonster;
    }
    public void GetMonsters(bool displayBestiary)
    {
        Monsters goblin = new Monsters("Goblin", 40, 5);
        Monsters orc = new Monsters("Orc", 50, 15);
        Monsters skeleton = new Monsters("Skeleton", 50, 3);
        Monsters witch = new Monsters("Witch");
        Monsters[] bestiary = { goblin, orc, skeleton, witch };
        if (displayBestiary == true)
        {
            void DisplayBestiary()
            {
                //list all monsters - list stats later
                foreach (Monsters monster in bestiary)
                {
                    Console.WriteLine(monster.Name);
                }
            }
            DisplayBestiary();
        }

    }
}