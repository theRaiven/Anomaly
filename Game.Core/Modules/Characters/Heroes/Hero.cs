namespace Game.Core.Modules.Characters.Heroes;

public interface ICombatant
{
    string Name { get; }
    int MaxHealth { get; }
    int CurrentHealth { get; }
}

public class Hero : ICombatant
{
    public string Name { get; }
    public int MaxHealth { get; }
    public int CurrentHealth { get; private set; }

    public Hero(string name, int maxHealth)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Имя героя не должно быть пустым.", nameof(name));
        }

        if (maxHealth <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(maxHealth), "Максимальное здоровье должно быть положительным.");
        }

        Name = name;
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;
    }
}