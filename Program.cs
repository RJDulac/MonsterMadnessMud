using System;
namespace mud

{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            bool startScreen = true;
            string playerStart = null;

            //player
            Player player = new Player("");
            //monsters
            Bestiary beasts = new Bestiary();
            beasts.DisplayBestiary();
            Combat combat = new Combat(beasts, player);
            while (playing == true)
            {
                StartScreen();
                if (playerStart == "yes")
                {

                    combat.Battle();
                }
                else
                {
                    startScreen = true;
                }
                PlayerDeath();
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
                    Console.WriteLine("Enter Yes to play!");
                    playerStart = Console.ReadLine().ToLower();
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
