using System;

static class CommonDefectsExample
{
    // Hard code constants: Better to use named constants or variables.
    private const int MAX_RETRY = 3; // Using constant instead of hardcoded value

    static void Main(string[] args)
    {
        // 1. Hard code constants
        // Bad: Hard-coded constant instead of using a named variable
        int retryLimit = 3; // Hard-coded value
        for (int i = 0; i < retryLimit; i++)
        {
            Console.WriteLine("Retrying...");
        }

        // 2. The Dangling else problem
        int score = 75;
        // Bad: Misleading nesting without braces
        if (score > 50)
        {
            if (score > 90)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Good job!"); // Rõ ràng rằng else này thuộc về if (score > 90)
            }
        }
        // 3. Null Pointer Exception
        string name = null;

        // Kiểm tra null trước khi truy cập thuộc tính hoặc phương thức
        if (name != null)
        {
            Console.WriteLine(name.Length);
        }
        else
        {
            Console.WriteLine("The name variable is null.");
        }

        // 4. Code redundant
        // Bad: Repetitive code blocks
        if (score > 60)
        {
            Console.WriteLine("Pass");
        }
        if (score > 60) // Redundant check
        {
            Console.WriteLine("Pass Again");
        }

        // 5. Create objects in loop
        // Bad: Creates new objects inside a loop, wasting memory
        for (int i = 0; i < 10; i++)
        {
            string message = new string("Iteration: " + i); // Inefficient use of memory
            Console.WriteLine(message);
        }

        // 6. Errors with string
        // Bad: String comparison using == instead of .Equals()
        string str1 = "hello";
        string str2 = new string("hello");
        if (str1 == str2) // Wrong way to compare strings
        {
            Console.WriteLine("Strings are equal"); // This will not print
        }

        // 7. Check String empty
        // Bad: Using .Length to check for an empty string instead of .IsNullOrEmpty()
        string input = "";
        if (input.Length == 0)
        {
            Console.WriteLine("Input is empty"); // Less readable than .IsNullOrEmpty()
        }

        // 8. Memory waste
        // Bad: Large unused data structures
        int[] largeArray = new int[1000000]; // Allocating large array unnecessarily
        Console.WriteLine("Large array created but not used");

        // 9. Errors by using Try/Catch code
        // Bad: Catching generic exceptions without proper handling
        try
        {
            int zero = 0;
            int result = 10 / zero;
        }
        catch (Exception e) // Catching a general exception
        {
            Console.WriteLine("Something went wrong"); // Generic error message without specific handling
        }
    }
}
