using System;

namespace PlayerDetectionSystem
{
    public class Player : IDamageable
    {
        public Health Health { get; private set; }

        public Player(Health health)
        {
            Health = health ?? throw new ArgumentNullException(nameof(health));
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));
            
            Health.TakeDamage(damage);
        }
    }
}