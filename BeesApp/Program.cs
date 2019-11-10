using System;

namespace BeesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the beehive!");

            var worker = new WorkerBee();
            var reducedHealth = worker.Damage(20);
            var workerDeadStatus = worker.CheckIfDead();

            Console.WriteLine(reducedHealth);
            Console.WriteLine(workerDeadStatus);
            Console.WriteLine(worker.IsDead);
        }
    }
}
