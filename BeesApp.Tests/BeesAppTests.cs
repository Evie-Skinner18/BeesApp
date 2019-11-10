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
            var currentHealth = _workerBee.Damage(20);

            Assert.That(currentHealth, Is.Not.Null);
            Assert.AreEqual(currentHealth, 80f);
        }

        [Test]
        public void CanReduceDroneBeesHealth_ShouldReturn80()
        {
            var currentHealth = _droneBee.Damage(20);

            Assert.That(currentHealth, Is.Not.Null);
            Assert.AreEqual(currentHealth, 80f);
        }

        [Test]
        public void CanReduceQueenBeesHealth_ShouldReturn80()
        {
            var currentHealth = _queenBee.Damage(20);

            Assert.That(currentHealth, Is.Not.Null);
            Assert.AreEqual(currentHealth, 80f);
        }

        [Test]
        public void CanCheckIfWorkerBeeIsDead_ShouldReturnTrue()
        {
            _workerBee.Damage(50);
            var isDead = _workerBee.CheckIfDead();
            var isReallyDead = _workerBee.IsDead;

            Assert.That(isDead, Is.Not.Null);
            Assert.AreEqual(isDead, true);
            Assert.AreEqual(isReallyDead, isDead);
        }

        [Test]
        public void CanCheckIfDroneBeeIsDead_ShouldReturnFalse()
        {
            _droneBee.Damage(50);
            var isDead = _droneBee.CheckIfDead();
            var isReallyDead = _droneBee.IsDead;

            Assert.That(isDead, Is.Not.Null);
            Assert.AreEqual(isDead, false);
            Assert.AreEqual(isReallyDead, isDead);
        }

        [Test]
        public void CanCheckIfQueenBeeIsDead_ShouldReturnFalse()
        {
            _queenBee.Damage(50);
            var isDead = _queenBee.CheckIfDead();
            var isReallyDead = _queenBee.IsDead;

            Assert.That(isDead, Is.Not.Null);
            Assert.AreEqual(isDead, false);
            Assert.AreEqual(isReallyDead, isDead);
        }
    }
}