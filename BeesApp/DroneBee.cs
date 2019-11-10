namespace BeesApp
{
    public class DroneBee : IBee
    {
        public bool IsDead { get; set; }

        public float Health { get; set; }

        public DroneBee()
        {
            Health = 100f;
        }

        public float Damage(float percentageDamage)
        {
            var amountToDeduct = Health * (percentageDamage / 100f);
            Health -= amountToDeduct;
            return Health;
        }

        public bool CheckIfDead() => IsDead = Health < 50f;
    }
}
