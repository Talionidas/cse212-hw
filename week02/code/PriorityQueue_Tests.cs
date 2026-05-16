using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Adds items with different priorities (1, 5, 3) and remove one item.
    // Expected Result: Item with highest priority should be removed first.
    // Defect(s) Found: none
    public void TestPriorityQueue_HighestPriorityFirst()
    {
        var pq = new PriorityQueue();

        pq.Enqueue("Low", 1);
        pq.Enqueue("High", 5);
        pq.Enqueue("Medium", 3);

        var result = pq.Dequeue();

        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: Add multiple items with the same priority (in this case 5).
    // Expected Result: Items should be removed in FrstInFirstOut (FIFO) order.
    // Defect(s) Found: Expected:<First>. Actual:<Second>.
    public void TestPriorityQueue_FIFO_SamePriority()
    {
        var pq = new PriorityQueue();

        pq.Enqueue("First", 5);
        pq.Enqueue("Second", 5);
        pq.Enqueue("Third", 5);

        Assert.AreEqual("First", pq.Dequeue());
        Assert.AreEqual("Second", pq.Dequeue());
        Assert.AreEqual("Third", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Add items in mixed order of priorities.
    // Expected Result: Items should be removed by their priority, not by their insertion order. 
    // Defect(s) Found: Expected:<C>. Actual:<B>.
    public void TestPriorityQueue_PriorityOverridesOrder()
    {
        var pq = new PriorityQueue();

        pq.Enqueue("A", 1);
        pq.Enqueue("B", 10);
        pq.Enqueue("C", 5);

        Assert.AreEqual("B", pq.Dequeue());
        Assert.AreEqual("C", pq.Dequeue());
        Assert.AreEqual("A", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Calling Dequeue on an empty PriorityQueue.
    // Expected Result: InvalidOperationException should be thrown with the message "The queue is empty."
    // Defect(s) Found: none
    public void TestPriorityQueue_EmptyQueueException()
    {
        var pq = new PriorityQueue();

        try
        {
            pq.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

}