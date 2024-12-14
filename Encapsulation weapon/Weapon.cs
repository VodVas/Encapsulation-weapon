namespace Encapsulation_weapon
{
    class Weapon
    {
        private int _damage;
        private int _bullets;

        public Weapon(int damage, int bullets)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage), "Урон не может быть отрицательным");

            if (bullets < 0)
                throw new ArgumentOutOfRangeException(nameof(bullets), "Количество пуль не может быть отрицательным");

            _damage = damage;
            _bullets = bullets;
        }

        public bool CanFire => _bullets > 0;

        public void Fire(IDamageable target)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target), "Цель не может быть null");

            if (CanFire == false)
                throw new InvalidOperationException("Нет патронов");

            target.TakeDamage(_damage);

            _bullets--;
        }
    }
}