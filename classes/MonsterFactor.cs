using System;

class MonsterFactory
{

    public static Monsters GetRandomMonster()
    {
        int randomNumber = new Random().Next(1, 5);
        switch (randomNumber)
        {
            case 1:
                return new Monsters("Orc", 50, new Random().Next(10, 12));
            case 2:
                return new Monsters("Skeleton", 50, new Random().Next(10, 12));
            case 3:
                return new Monsters("Dragon", 100, new Random().Next(10, 12));
            case 4:
                return new Monsters("Golem", 120, new Random().Next(6, 12));
            case 5:
                return new Monsters("Witch");
        }
        return new Monsters("NULL");
    }
}
