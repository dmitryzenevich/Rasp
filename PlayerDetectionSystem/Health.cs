using System;

namespace PlayerDetectionSystem
{
    public class Health : IDamageable
    {
        public int Value { get; private set; }
        
        public void TakeDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            Value -= damage;
            Value = Value < 0 ? 0 : Value;
        }
    }
}