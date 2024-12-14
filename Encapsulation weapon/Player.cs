namespace Encapsulation_weapon
{
    class Player : IDamageable
    {
        public int Health { get; private set; }

        public Player(int initialHealth)
        {
            if (initialHealth <= 0)
                throw new ArgumentOutOfRangeException(nameof(initialHealth), "Начальное здоровье не может быть отрицательным или 0");

            Health = initialHealth;
        }

        public void TakeDamage(int amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Количество урона не может быть отрицательным");

            Health = Math.Max(Health - amount, 0);
        }
    }
}