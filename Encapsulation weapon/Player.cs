namespace Encapsulation_weapon
{
    class Player : IDamageable
    {
        public int Health { get; private set; }

        public Player(int initialHealth)
        {
            Health = initialHealth;
        }

        public void TakeDamage(int amount)
        {
            Health = Math.Max(Health - amount, 0);
        }
    }
}