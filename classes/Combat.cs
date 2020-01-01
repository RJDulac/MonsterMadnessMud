using System;
//think needs to be static?
public class Combat
{
    private Bestiary Beasts = new Bestiary();
    private Player Player = new Player(" ");
    public Combat()
    { }
    public Combat(Bestiary beasts, Player player)
    {
        Beasts = beasts;
        Player = player;

    }

    public void Battle()
    {
        bool combatPlaying = true;
        bool playerTurn = true;

        Monsters selectedMonster = Beasts.GetMonsters();
        int monsterFullHealth = selectedMonster.Health;
        Console.WriteLine($"{selectedMonster.Name} appears!");
        while (combatPlaying == true)
        {
            if (playerTurn == true)
            {
                Console.WriteLine("Player's turn");
                Console.WriteLine($"You attack {selectedMonster.Name} for {Player.Damage} damage!");
                selectedMonster.TakesDamage(Player.Damage);
                Console.WriteLine($"{selectedMonster.Name} is left with {selectedMonster.Health} health!");
                Console.ReadLine();
                playerTurn = false;
            }
            else
            {
                Console.WriteLine("Monster's turn");
                Console.WriteLine($"{selectedMonster.Name} attacks you for {selectedMonster.Damage} damage!");
                Player.TakesDamage(selectedMonster.Damage);
                Console.WriteLine($"You have {Player.Health} health left!");
                Console.ReadLine();
                playerTurn = true;
            }
            if (selectedMonster.Health == 0)
            {
                selectedMonster.SetHealth(monsterFullHealth);
                Player.GoldReward(20);
                Player.LevelUp();
                Console.WriteLine($"You have slain {selectedMonster.Name}, earned 20 gold, and earned level {Player.PlayerLevel}!");
                Player.Info();
                combatPlaying = false;
            }
            if (Player.Health == 0)
            {
                Console.WriteLine("You died!");
                combatPlaying = false;
            }
        }
    }
}