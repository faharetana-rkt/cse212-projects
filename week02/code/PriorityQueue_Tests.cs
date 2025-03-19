using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: enqueueing mark 10, sally 5, and james 1. 
    // Expected Result: Expected result is [Mark (Pri:10), Sally (Pri:5), James (Pri:1)]
    // Defect(s) Found: no defect found
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();        
        priorityQueue.Enqueue("Mark", 10);
        priorityQueue.Enqueue("Sally", 5);
        priorityQueue.Enqueue("James", 1);

        var result = priorityQueue.ToString();
        Assert.AreEqual("[Mark (Pri:10), Sally (Pri:5), James (Pri:1)]", result);
    }

    [TestMethod]
    // Scenario: enqueueing mark 10, sally 5, and james 1 and dequeuing highest priority target
    // Expected Result: the dequeuing result should be mark 10
    // Defect(s) Found: the for loop isn't going through all the queue, modified queue.Count -1 to queue.Count
    // The high priority target isn't removed from the queue also. 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Mark", 10);
        priorityQueue.Enqueue("Sally", 5);
        priorityQueue.Enqueue("James", 1);

        var result1 = priorityQueue.Dequeue();
        var result2 = priorityQueue.Dequeue();
        var result3 = priorityQueue.Dequeue();
        Assert.AreEqual("Mark", result1);
        Assert.AreEqual("Sally",result2);
        Assert.AreEqual("James", result3);

        // Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    // Scenario: dequeuing an empty queue
    // Expected Result: should throw an error
    // Defect(s) Found: no defect found
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();
    }
}