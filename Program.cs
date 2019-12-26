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

            Monsters[] bestiary = { goblin, orc };
            //Console.WriteLine(bestiary[1].Health);

            Console.WriteLine(goblin.Health);
            goblin.TakesDamage(30);
            Console.WriteLine(goblin.Health);

            //player
            Player player = new Player("", 100, 10);
            //Console.WriteLine(bestiary[1].Name);
            while (playing == true)
            {
                StartScreen();

                player.DamageTaken(10);

                Console.WriteLine($"Your health is: {player.Health}");
                PlayerDeath();

            }
            void StartScreen()
            {
                if (startScreen == true)
                {

                    Console.WriteLine("Game Started \n press any key to play");
                    //creat player
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

        }

    }
}
