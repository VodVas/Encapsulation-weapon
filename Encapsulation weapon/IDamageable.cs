namespace Encapsulation_weapon
{
    interface IDamageable
    {
        public void TakeDamage(int amount);

        public int Health { get; }
    }
}