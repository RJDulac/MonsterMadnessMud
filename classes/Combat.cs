using System;
using System.Threading.Tasks;
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
        Console.WriteLine($"{selectedMonster.Name} appears!\n");
        //store  
        bool isShopping = false;
        Shop shop = new Shop();
        string storeInput = "";
        while (combatPlaying == true)
        {

            //players turn
            if (playerTurn == true)
            {
                Console.WriteLine("----------------------------------\n");
                Console.WriteLine("Player's turn \n");
                //player attack waits
                Task.WaitAll(Wait(800));
                Console.WriteLine($"You attack {selectedMonster.Name} for {Player.Damage} damage!\n");
                selectedMonster.TakesDamage(Player.Damage);
                //wait to show health
                Task.WaitAll(Wait(1200));
                Console.WriteLine($"{selectedMonster.Name} is left with {selectedMonster.Health} health!\n");
                storeInput = Console.ReadLine().ToLower();
                //go to shop
                if (storeInput == "shop" || storeInput == "s")
                {
                    isShopping = true;
                    shop.Shopping(isShopping);
                }
                playerTurn = false;
            }
            //monsters turn
            else
            {
                Console.WriteLine("----------------------------------\n");
                Console.WriteLine("Monster's turn\n");
                //monster attack waits
                Task.WaitAll(Wait(800));
                Console.WriteLine($"{selectedMonster.Name} attacks you for {selectedMonster.Damage} damage!\n");
                Player.TakesDamage(selectedMonster.Damage);
                //wait to show health
                Task.WaitAll(Wait(1200));
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
    public static async Task Wait(int duration)
    {
        await WaitDelay(duration);
        //Console.WriteLine("Attacks");
    }
    public static async Task<int> WaitDelay(int duration)
    {
        await Task.Delay(duration);
        return 1;
    }
}