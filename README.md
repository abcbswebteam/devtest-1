# Dev Test 1

## Scenario
You have taken up maintenance on an application created by another developer.  
This application has a function that generates a CSV report based on a list of customers.  
The users are complaining that the CSV report takes 10 seconds or more to generate.  
They would like report to generate in 2 seconds or less.

## Your Task
In your pull request
* Describe in detail the reason that the CSV report is generating slowly.
  * Hint, it's not just because of the 100,000 iteration loop.
* Optimize the code to generate the report in under 2 seconds.

## Constraints
* Do not change the Customers class.
* Do not use any additional libraries (no additional nuget packages).


## Explanation
* In the HomeController.vb file, there is a For Each loop over the list of customers.
* In the code provided, the csvBody string variable is being concatenated 3 times per iteration.
* Since, in the CLR, strings are immutable, this is adding a new string object to the heap
    * 3 times per iteration. This is a very large memory and performance problem.
* Using a StringBuilder object is a much better solution because it allows you to have a mutable string object.
    * This allows you to append values to a string without adding new memory allocations to the heap.
    * Once the appending is done, the StringBuilder.ToString() method returns a string (object) value.
* Thus, using a StringBuilder object in lieu of repeatedly concatenting a string should decrease the run time.