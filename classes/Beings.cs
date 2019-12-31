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


    protected Beings(string name)
    {
        Name = name;

    }

    public int TakesDamage(int num)
    {
        return Health -= num;
    }
    public string GiveName(string name)
    {
        Name = name;
        return Name;
    }
    public int SetHealth(int num)
    {
        return Health = num;
    }
    public abstract void Info();

}