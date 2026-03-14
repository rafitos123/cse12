using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add Bob (priority 1), Tim (priority 3), and Sue (priority 2). Run until the queue is empty.
    // Expected Result: Tim, Sue, Bob
    // Defect(s) Found: The Assert.Fail() was not removed so the program always fails. 
    //the loop was wrong because is not checking the last item and the item was never removed.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        

            priorityQueue.Enqueue("Bob", 1);
            priorityQueue.Enqueue("Tim", 3);
            priorityQueue.Enqueue("Sue", 2);

            string[] expectedResult = ["Tim", "Sue", "Bob"];

            for (int i = 0; i < expectedResult.Length; i++)
            {
                var result = priorityQueue.Dequeue();
                Assert.AreEqual(expectedResult[i], result);
                Console.WriteLine(result);
            }
                
        
    }

    [TestMethod]
    // Scenario: Adding a priority draw case. Add Bob (priority 1), Tim (priority 3), Sue (priority 2), and Ann (priority 3). Run until the queue is empty.
    // Expected Result: Tim, Ann, Sue, Bob
    // Defect(s) Found: The Assert.Fail() was not removed so the program always fails. 
    //the loop was wrong because is not checking the last item and the item was never removed.

    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
       

        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 3);
        priorityQueue.Enqueue("Sue", 2);
        priorityQueue.Enqueue("Ann", 3);

        string[] expectedResult = ["Tim", "Ann", "Sue", "Bob"];

        for (int i = 0; i < expectedResult.Length; i++)
        {
            var result = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], result);
            Console.WriteLine(result);
        }

    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: InvalidOperationException with a message of "The queue is empty."
    // Defect(s) Found:

    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected an InvalidOperationException to be thrown.");
        }
        catch (InvalidOperationException empty)
        {
            Assert.AreEqual("The queue is empty.", empty.Message);
            Console.WriteLine(empty.Message);
        }
    }

}