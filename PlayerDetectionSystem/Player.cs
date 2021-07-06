using System;

namespace PlayerDetectionSystem
{
    public class Player : IDamageable
    {
        private Health Health { get; }

        public Player(Health health)
        {
            Health = health ?? throw new ArgumentNullException(nameof(health));
        }

        public void TakeDamage(int damage) => Health.TakeDamage(damage);
    }
}