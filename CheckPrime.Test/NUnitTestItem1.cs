using NUnit.Framework.Legacy;
using System.Diagnostics;

namespace CheckPrime.Test;


public class LifeCycleTest
{
    private int _sharedResource; // Example: Shared database connection, file path, etc.

    // Executes once before any tests in this fixture are run.
    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        TestContext.Progress.WriteLine("OneTimeSetUp: Setting up the entire test fixture.");
        _sharedResource = 10; // Initialize your shared resource
    }

    // Executes once after all tests in this fixture have been run.
    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        TestContext.Progress.WriteLine("OneTimeTearDown: Cleaning up after all tests.");
        // Release resources (e.g., close database connection, delete temporary files)
    }

    // Executes before each test in this fixture.
    [SetUp]
    public void Setup()
    {
        Console.WriteLine("SetUp: Setting up before each test.");
        _sharedResource++; //Modify resource for each test
    }

    // Executes after each test in this fixture.
    [TearDown]
    public void TearDown()
    {
        Console.WriteLine("TearDown: Cleaning up after each test.");
        //Reset resource
    }

    [Test]
    public void Test1()
    {
        Console.WriteLine("Test1: Running test 1.");
        ClassicAssert.Greater(_sharedResource, 10); //Example Assertion
                                             // Perform your test logic here
    }

    [Test]
    public void Test2()
    {
        Console.WriteLine("Test2: Running test 2.");
        ClassicAssert.Greater(_sharedResource, 10); //Example Assertion
                                             // Perform your test logic here
    }
}