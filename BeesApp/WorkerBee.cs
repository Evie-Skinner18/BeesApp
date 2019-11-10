namespace BeesApp
{
    public class WorkerBee : IBee
    {
        public bool IsDead { get; set;}

        public float Health { get; set; }

        public WorkerBee()
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

        public bool CheckIfDead() => IsDead = Health < 70f;

    }
}
