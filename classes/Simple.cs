Person john = new Person();
Person mike = new Person("Mike");
Person lisa = new Person("Lisa", 39);

john.Print();
mike.Print();
lisa.Print();

class Person
{
    public string name; // объявление поля класса
    public int age; // объявление поля класса
    public Person() { name = "Unknown"; age = 20; } // объявление конструктора класса 
    public Person(string name) { this.name = name; }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Print() => Console.WriteLine($"Name: {name}, Age: {age}"); // метода вывода в консоль
}