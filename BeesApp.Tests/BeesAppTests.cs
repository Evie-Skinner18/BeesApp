using NUnit.Framework;
using BeesApp;

namespace Tests
{
    public class BeesAppTests
    {
        private WorkerBee _workerBee;
        private DroneBee _droneBee;
        private QueenBee _queenBee;

        [SetUp]
        public void Setup()
        {
            _workerBee = new WorkerBee();
            _droneBee = new DroneBee();
            _queenBee = new QueenBee();
        }

        [Test]
        public void CanReduceWorkerBeesHealth_ShouldReturn80()
        {
            var currentHealth = _workerBee.Damage(20f);

            Assert.That(currentHealth, Is.Not.Null);
            Assert.AreEqual(currentHealth, 80f);
        }

        [Test]
        public void CanReduceDroneBeesHealth_ShouldReturn80()
        {
            var currentHealth = _droneBee.Damage(20f);

            Assert.That(currentHealth, Is.Not.Null);
            Assert.AreEqual(currentHealth, 80f);
        }

        [Test]
        public void CanReduceQueenBeesHealth_ShouldReturn80()
        {
            var currentHealth = _queenBee.Damage(20f);

            Assert.That(currentHealth, Is.Not.Null);
            Assert.AreEqual(currentHealth, 80f);
        }

        [Test]
        public void CanCheckIfWorkerBeeIsDead_ShouldReturnTrue()
        {
            _workerBee.Damage(50f);
            var isDead = _workerBee.CheckIfDead();
            var isReallyDead = _workerBee.IsDead;

            Assert.That(isDead, Is.Not.Null);
            Assert.AreEqual(isDead, true);
        }
    }
}