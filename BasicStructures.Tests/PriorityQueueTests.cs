namespace BasicStructures.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestOfPrioritets()
        {
            BasicStructures.PriorityQueue<int> queue = new BasicStructures.PriorityQueue<int>();

            Assert.AreEqual(0, queue.Size);
            queue.Enqueue(5, 55);
            queue.Enqueue(0, 0);
            queue.Enqueue(1, 11);
            queue.Enqueue(0, 10);
            queue.Enqueue(5, 555);
            queue.Enqueue(2, 22);
            queue.Enqueue(3, 33);
            queue.Enqueue(3, 333);
            queue.Enqueue(3, 3333);
            queue.Enqueue(0, 100);
            queue.Enqueue(9, 90);
            queue.Enqueue(8, 80);
            queue.Enqueue(7, 70);

            Assert.AreEqual(13, queue.Size);
            Assert.AreEqual(0, queue.Dequeue());
            Assert.AreEqual(10, queue.Dequeue());
            Assert.AreEqual(100, queue.Dequeue());
            Assert.AreEqual(11, queue.Dequeue());
            Assert.AreEqual(22, queue.Dequeue());
            Assert.AreEqual(33, queue.Dequeue());
            Assert.AreEqual(333, queue.Dequeue());
            Assert.AreEqual(3333, queue.Dequeue());
            Assert.AreEqual(55, queue.Dequeue());
            Assert.AreEqual(555, queue.Dequeue());
            Assert.AreEqual(70, queue.Dequeue());
            Assert.AreEqual(80, queue.Dequeue());
            Assert.AreEqual(90, queue.Dequeue());
            Assert.AreEqual(0, queue.Size);
        }
    }
}