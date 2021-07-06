using System;

namespace PlayerDetectionSystem
{
    public class Health : IDamageable
    {
        public int Value { get; private set; }

        public Health(int value)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(value));
            
            Value = value;
        }
        
        public void TakeDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            damage = damage > Value ? Value : damage;
            Value -= damage;
        }
    }
}