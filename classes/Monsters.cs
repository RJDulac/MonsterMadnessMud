
class Monsters
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Damage { get; private set; }


    public Monsters(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public int TakesDamage(int num)
    {
        return Health -= num;
    }

}