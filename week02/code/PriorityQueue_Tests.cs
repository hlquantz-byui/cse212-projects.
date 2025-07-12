using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue a single item into the priority queue.
    // Expected Result: The queue should contain the item.
    // Defect(s) Found: None
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        Assert.AreEqual("[Item1 (Pri:1)]", priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities.
    // Expected Result: The queue should maintain the order of insertion.
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", 2);
        Assert.AreEqual("[Item1 (Pri:1), Item2 (Pri:2)]", priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Dequeue from a queue with one item.
    // Expected Result: The item should be returned and the queue should be empty.
    // Defect(s) Found: None
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Item1", result);
        Assert.AreEqual("[]", priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Dequeue from a queue with multiple items of different priorities.
    // Expected Result: The item with the highest priority should be returned.
    // Defect(s) Found: None
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", 3);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Item2", result);
    }

    [TestMethod]
    // Scenario: Dequeue from a queue with multiple items of the same highest priority.
    // Expected Result: The first added item with the highest priority should be returned.
    // Defect(s) Found: None
    public void TestPriorityQueue_5()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 3);
        priorityQueue.Enqueue("Item2", 3);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Item1", result);
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: An InvalidOperationException should be thrown.
    // Defect(s) Found: None
    public void TestPriorityQueue_6()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Verify the state of the queue after multiple enqueue and dequeue operations.
    // Expected Result: The queue should reflect the correct items after operations.
    // Defect(s) Found: None
    public void TestPriorityQueue_7()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", 2);
        priorityQueue.Dequeue(); // Removes Item2
        priorityQueue.Enqueue("Item3", 3);
        Assert.AreEqual("[Item1 (Pri:1), Item3 (Pri:3)]", priorityQueue.ToString());
    }
}
