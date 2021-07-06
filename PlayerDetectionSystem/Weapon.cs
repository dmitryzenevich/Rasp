using System;

namespace PlayerDetectionSystem
{
    public class Weapon
    {
        public int Damage { get; private set; }
        public int Bullets { get; private set; }

        public Weapon(int damage, int bullets)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            if (bullets < 0)
                throw new ArgumentOutOfRangeException(nameof(bullets));

            Damage = damage;
            Bullets = bullets;
        }

        public void Fire(IDamageable damageable)
        {
            if (Bullets > 0)
            {
                damageable.TakeDamage(Damage);
                Bullets -= 1;
            }
        }
    }
}