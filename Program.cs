using System;

namespace mud


{

    class Program
    {

        static void Main(string[] args)
        {
            bool playing = true;
            bool startScreen = true;
            //bool combat = true;
            string playerStart = null;

            Monsters goblin = new Monsters("Goblin", 40, 5);
            Monsters orc = new Monsters("Orc", 10, 15);
            Monsters skeleton = new Monsters("Skeleton", 5, 3);

            Monsters[] bestiary = { goblin, orc, skeleton };

            //player
            Player player = new Player("", 100, 10);

            while (playing == true)
            {
                StartScreen();
                if (playerStart == "yes")
                {
                    Combat();
                }
                else
                {
                    startScreen = true;
                }
                PlayerDeath();
            }
            void Combat()
            {
                bool combatPlaying = true;
                bool playerTurn = true;

                while (combatPlaying == true)
                {
                    if (playerTurn == true)
                    {
                        Console.WriteLine("Player's turn");
                        Console.ReadLine();
                        playerTurn = false;
                    }
                    else
                    {
                        Console.WriteLine("Monster's turn");
                        Console.ReadLine();
                        playerTurn = true;
                    }
                }
            }
            void StartScreen()
            {
                if (startScreen == true)
                {

                    Console.WriteLine("Game Started");
                    //create player
                    Console.WriteLine("Choose your name!");
                    string input = Console.ReadLine();
                    player.GiveName(input);


                    Console.WriteLine($"Your player name is: {player.Name} and stats are {player.Health} health and you deal {player.Damage} damage");
                    //more semantic than break;
                    Console.WriteLine("Enter Yes to play!");
                    playerStart = Console.ReadLine().ToLower();
                    startScreen = false;
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
