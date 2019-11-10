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

        public float Damage(float percentageDamage)
        {
            var amountToDeduct = Health * (percentageDamage / 100f);
            return Health - amountToDeduct;
        }

        public bool CheckIfDead() => Health < 70;

    }
}
