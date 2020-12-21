# Get User Input

You have already learned that Console.WriteLine() is used to output (print) values. Now we will use Console.ReadLine() to get user input.

In the following example, the user can input his or hers username, which is stored in the variable userName. Then we print the value of userName:


# User Input and Numbers

The Console.ReadLine() method returns a string. Therefore, you cannot get information from another data type, such as int. The following program will cause an error:
        Example

        Console.WriteLine("Enter your age:");
        int age = Console.ReadLine();
        Console.WriteLine("Your age is: " + age);

        The error message will be something like this:
        Cannot implicitly convert type 'string' to 'int' 

        Like the error message says, you cannot implicitly convert type 'string' to 'int'.

        Luckily, for you, you just learned from the previous chapter (Type Casting), that you can convert any type explicitly, by using one of the Convert.To methods:
        Example

        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age is: " + age);
