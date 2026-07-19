

public class Unit
{
    private float _health; // поле

    public string Name { get; } // свойство

    public float Health => _health; // свойство

    public Unit(): this(name:"Unknown name") // конструктор без аргуементо вызываюещего
    {
    }
    public Unit(string name) // конструктор с прокидыванием значения
    {
        Name = name;
    }
}