namespace BeesApp
{
    public class QueenBee : IBee
    {
        public bool IsDead { get; set; }

        public float Health { get; set; }

        public QueenBee()
        {
            Health = 100f;
        }

        public float Damage(int percentageDamage)
        {
            var floatPercentage = (float)percentageDamage;
            var amountToDeduct = Health * (floatPercentage / 100f);
            Health -= amountToDeduct;
            return Health;
        }

        public bool CheckIfDead() => IsDead = Health < 20f;
    }
}
