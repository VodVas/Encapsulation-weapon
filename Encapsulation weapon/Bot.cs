namespace Encapsulation_weapon
{
    class Bot
    {
        private Weapon _weapon;

        public Bot(Weapon weapon)
        {
            _weapon = weapon;
        }

        public void OnSeePlayer(IDamageable target)
        {
            _weapon.Fire(target);
        }
    }
}