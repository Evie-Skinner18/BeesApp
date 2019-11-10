namespace BeesApp
{
    public interface IBee
    {
        bool IsDead { get; set; }

        float Health { get; set; }

        float Damage(float percentageDamage);
    }
}
