public class Unit
{
    // объ€вление приватного пол€ класса
    private float _health;

    // объ€вление свойства
    public string Name { get; }
    public float Health
    {
        get { return _health; }
    } 
    public int Damage { get; }
    public float Armor { get; }

    // конструктор 1
    public Unit() : this("Unknown Unit")
    {
    }

    // конструктор 2
    public Unit(string name)
    {
        Name = name;
        Damage = 5;
        Armor = 0.6f;
        _health = 100f;
    }

    public float GetRealHealth()
    {
        return Health * (1f + Armor);
    }

    public bool SetDamage(float value)
    {
        _health = Health - value * Armor;
        return Health <= 0f;
    }
}
