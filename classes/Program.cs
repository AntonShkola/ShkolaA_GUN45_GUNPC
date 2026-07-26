// Демонстрация Unit

Console.WriteLine("=== Unit ===");
Unit hero = new Unit("Hero");
Console.WriteLine($"Name: {hero.Name}");
Console.WriteLine($"Health: {hero.Health}");
Console.WriteLine($"Damage: {hero.Damage}");
Console.WriteLine($"Armor: {hero.Armor}");
Console.WriteLine($"RealHealth: {hero.GetRealHealth()}");

bool isDead = hero.SetDamage(50);
Console.WriteLine($"After SetDamage(50) — Health: {hero.Health}, Dead: {isDead}");

Unit unknown = new Unit();
Console.WriteLine($"Default unit name: {unknown.Name}");
