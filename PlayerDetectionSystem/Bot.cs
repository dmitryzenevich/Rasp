using System;

namespace PlayerDetectionSystem
{
    public class Bot
    {
        public Weapon Weapon { get; }

        public Bot(Weapon weapon)
        {
            Weapon = weapon ?? throw new ArgumentNullException(nameof(weapon));
        }

        public void OnSeePlayer(Player player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            Weapon.Fire(player);
        }
    }
}