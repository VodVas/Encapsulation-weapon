namespace Encapsulation_weapon
{
    class Weapon
    {
        private int _damage;
        private int _bullets;

        public Weapon(int damage, int bullets)
        {
            _damage = damage;
            _bullets = bullets;
        }

        public bool CanFire => _bullets > 0;

        public void Fire(IDamageable target)
        {
            if (CanFire == false)
            {
                Console.WriteLine("out of ammo");

                return;
            }

            target.TakeDamage(_damage);

            _bullets--;
        }
    }
}