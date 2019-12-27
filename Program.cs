using System;

namespace mud
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            bool startScreen = true;

            Monsters goblin = new Monsters("Goblin", 40, 5);
            Monsters orc = new Monsters("Orc", 10, 15);
            Monsters skeleton = new Monsters("Skeleton", 5, 3);

            Monsters[] bestiary = { goblin, orc, skeleton };
            //Console.WriteLine(bestiary[1].Health);


            DisplayBestiary();

            Console.WriteLine(goblin.Health);
            goblin.TakesDamage(30);
            Console.WriteLine(goblin.Health);




            //player
            Player player = new Player("", 100, 10);
            //Console.WriteLine(bestiary[1].Name);

            player.PlayerInfo();
            player.LevelUp();
            player.PlayerInfo();
            player.LevelUp();
            player.PlayerInfo();

            while (playing == true)
            {
                StartScreen();


                player.DamageTaken(10);

                player.PlayerInfo();
                PlayerDeath();


            }
            void StartScreen()
            {
                if (startScreen == true)
                {

                    Console.WriteLine("Game Started \n press any key to play");
                    //create player
                    Console.WriteLine("Choose your name!");
                    string input = Console.ReadLine();
                    player.NamePlayer(input);


                    Console.WriteLine($"Your player name is: {player.Name} and stats are {player.Health} health and you deal {player.Damage} damage");
                    //more semantic than break;
                    startScreen = false;
                }
            }
            void PlayerDeath()
            {
                if (player.Health <= 0)
                {
                    Console.WriteLine("Game ended");

                    playing = false;
                }
            }
            void DisplayBestiary()
            {
                //list all monsters - list stats later
                foreach (Monsters monster in bestiary)
                {
                    Console.WriteLine(monster.Name);
                }
            }

        }

    }
}
