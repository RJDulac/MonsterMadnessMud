public abstract class Beings
{
    private int health;
    public string Name { get; protected set; }
    public int Health
    {
        get { return health; }
        protected set
        {
            health = value;
            if (health <= 0)
            {
                health = 0;
            }
        }
    }
    public int Damage { get; protected set; }


    protected Beings(string name, int health, int damage)
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