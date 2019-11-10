﻿namespace BeesApp
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
            Health += Health - amountToDeduct;
            return Health - amountToDeduct;
        }

        public bool CheckIfDead() => Health < 50f;
    }
}
