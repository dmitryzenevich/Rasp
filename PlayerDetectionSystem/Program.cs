namespace PlayerDetectionSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var playerHealth = new Health(100);
            var player = new Player(playerHealth);
            
            var botWeapon = new Weapon(10, 10);
            var bot = new Bot(botWeapon);
            
            bot.OnSeePlayer(player);
        }
    }
}