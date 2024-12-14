namespace Encapsulation_weapon
{
    class Bot
    {
        private readonly Weapon _weapon;

        public Bot(Weapon weapon)
        {
            if (weapon == null)
                throw new ArgumentNullException(nameof(weapon), "Оружие не может быть null");

            _weapon = weapon;
        }

        public void OnSeePlayer(IDamageable target)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target), "Цель не может быть null");

            _weapon.Fire(target);
        }
    }
}