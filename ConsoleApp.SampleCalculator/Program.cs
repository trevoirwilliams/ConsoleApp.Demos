// See https://aka.ms/new-console-template for more information

// Welcome Message
Console.WriteLine("******** - Welcome to the sample calculator! - ********");

// Show calculator options / Show menu
Console.WriteLine("Please select an operation (-1 to exit program) ");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Fibonacci sequence");
int choice = Convert.ToInt32(Console.ReadLine());

while(choice != -1)
{
    Console.Write("Please enter the first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Please enter the second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    // Decide which operation is needed based on selected option
    /*If statements */
    //if (choice == 1)
    //{
    //    /* do addition */
    //}
    //else if (choice == 2)
    //{
    //    /* subtraction*/
    //}
    //else if (choice == 3)
    //{
    //    /*Multiplication*/
    //}
    //else if (choice == 4)
    //{
    //    /*Division*/
    //}
    //else
    //{
    //    Console.WriteLine("Invalid choice");
    //}
    // Prompt for user input
    
    /* Switch statement */
    int answer = 0;
    switch (choice)
    { 
        case 1:
            answer = num1 + num2;
            break;
        case 2:
            answer = num1 - num2;
            break;
        case 3:
            answer = num1 * num2;
            break;
        case 4:
            answer = num1 / num2;
            break;
        case 5:
            for (int i = num1; i <= num2; i++)
            {
                answer += i;
            }
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }

    // print output 
    Console.WriteLine($"The result is: {answer}");
    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();
    Console.Clear();

    Console.WriteLine("Please select an operation (-1 to exit program) ");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci sequence");
    choice = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("******** - Thank you for using the sample calculator! - ********");
