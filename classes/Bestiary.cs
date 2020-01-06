// using System;
// public class Bestiary
// {
//     Random rnd = new Random();


//     public Monsters[] MonsterGroup()
//     {

//         Monsters orc = new Monsters("Orc", 50, rnd.Next(8, 15));
//         Monsters skeleton = new Monsters("Skeleton", 50, rnd.Next(9, 11));
//         Monsters dragon = new Monsters("Dragon", 100, rnd.Next(7, 12));
//         Monsters golem = new Monsters("Golem", 120, rnd.Next(4, 8));
//         Monsters witch = new Monsters("Witch");
//         Monsters[] bestiary = { goblin, orc, skeleton, witch, dragon };
//         return bestiary;
//     }
//     public Monsters GetMonsters()
//     {
//         Monsters[] bestiary = MonsterGroup();
//         Monsters selectedMonster = bestiary[rnd.Next(bestiary.Length)];
//         return selectedMonster;
//     }
//     public void DisplayBestiary()
//     {
//         Monsters[] bestiary = MonsterGroup();
//         //list all monsters - list stats later
//         foreach (Monsters monster in bestiary)
//         {
//             Console.WriteLine(monster.Name);
//         }

//     }
// }


//may rewrite old code to store monsters and display bestiary.