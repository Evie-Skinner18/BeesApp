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
            _workerBee = new WorkerBee(100);

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}