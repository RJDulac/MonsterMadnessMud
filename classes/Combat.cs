using System;
public class Combat
{
    public void Battle(Bestiary beasts, Player player)
    {
        bool combatPlaying = true;
        bool playerTurn = true;

        Monsters selectedMonster = beasts.GetMonsters();
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
}