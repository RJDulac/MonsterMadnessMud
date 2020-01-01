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

            //player
            Player player = new Player("");
            Bestiary mob = new Bestiary();
            mob.DisplayBestiary();
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

                Monsters selectedMonster = mob.GetMonsters();
                int monsterFullHealth = selectedMonster.Health;
                Console.WriteLine($"{selectedMonster.Name} appears!");
                while (combatPlaying == true)
                {


                    if (playerTurn == true)
                    {
                        Console.WriteLine("Player's turn");
                        Console.WriteLine($"You attack {selectedMonster.Name} for {player.Damage} damage!");
                        selectedMonster.TakesDamage(player.Damage);
                        Console.WriteLine($"{selectedMonster.Name} is left with {selectedMonster.Health} health!");
                        Console.ReadLine();
                        playerTurn = false;
                    }
                    else
                    {
                        Console.WriteLine("Monster's turn");
                        Console.WriteLine($"{selectedMonster.Name} attacks you for {selectedMonster.Damage} damage!");
                        player.TakesDamage(selectedMonster.Damage);
                        Console.WriteLine($"You have {player.Health} health left!");
                        Console.ReadLine();
                        playerTurn = true;
                    }
                    if (selectedMonster.Health == 0)
                    {
                        selectedMonster.SetHealth(monsterFullHealth);
                        Console.WriteLine($"You have slain {selectedMonster.Name}!");
                        combatPlaying = false;
                    }
                    if (player.Health == 0)
                    {
                        Console.WriteLine("You died!");
                        combatPlaying = false;
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
