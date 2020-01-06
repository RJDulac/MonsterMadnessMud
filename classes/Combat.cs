using System;
using System.Threading.Tasks;

public class Combat
{
    private Player Player = new Player(" ");
    public Combat()
    { }
    public Combat(Player player)
    {
        Player = player;

    }
    public void Battle()
    {
        bool combatPlaying = true;
        bool playerTurn = true;

        Monsters monster = MonsterFactory.GetRandomMonster();
        Console.WriteLine($"{monster.Name} appears!\n");
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
                Console.WriteLine($"You attack {monster.Name} for {Player.Damage} damage!\n");
                monster.TakesDamage(Player.Damage);
                //wait to show health
                Task.WaitAll(Wait(1200));
                Console.WriteLine($"{monster.Name} is left with {monster.Health} health!\n");
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
                Console.WriteLine($"{monster.Name} attacks you for {monster.Damage} damage!\n");
                Player.TakesDamage(monster.Damage);
                //wait to show health
                Task.WaitAll(Wait(1200));
                Console.WriteLine($"You have {Player.Health} health left!");
                Console.ReadLine();
                playerTurn = true;
            }
            if (monster.Health == 0)
            {
                Player.GoldReward(20);
                Player.LevelUp();
                Console.WriteLine($"You have slain {monster.Name}, earned 20 gold, and earned level {Player.PlayerLevel}!");
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
    }
    public static async Task<int> WaitDelay(int duration)
    {
        await Task.Delay(duration);
        return 1;
    }
}