using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add several items with varying priorities, dequeue returns highest priority first
    // Expected Result: Dequeue returns items in order: "C" (priority 3), "B" (priority 2), "A" (priority 1)
    // Defect(s) Found: If Dequeue removes in FIFO order regardless of priority, test will fail.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);

        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add multiple items with same highest priority, dequeue removes first added of those
    // Expected Result: Dequeue returns "B" then "C" (both priority 3, B enqueued first), then "A" (priority 1)
    // Defect(s) Found: If Dequeue does not preserve FIFO for same priority, test will fail.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 3);

        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue on empty queue should throw InvalidOperationException
    // Expected Result: Exception thrown with appropriate message
    // Defect(s) Found: If exception not thrown, test will fail.
    public void TestPriorityQueue_EmptyDequeue()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() =>
        {
            priorityQueue.Dequeue();
        });
    }
}
