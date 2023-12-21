// See https://aka.ms/new-console-template for more information

// Variable Declarations
int choice = 0;
int num1, num2 = 0;

// Show calculator options / Show menu
while (choice != -1)
{
    try
    {
        // Welcome Message
        Console.Clear();
        Console.WriteLine("******** - Welcome to the sample calculator! - ********");
        Console.WriteLine("Please select an operation (-1 to exit program) ");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Fibonacci sequence");

        choice = Convert.ToInt32(Console.ReadLine());
        
        if (choice == -1)
        {
            break;
        }
        
        Console.Write("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
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
                throw new Exception("Invalid Menu Item Selected.");
        }

        // print output 
        Console.WriteLine($"The result is: {answer}");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Press any key to continue.");
        Console.ReadLine();
    }
}

Console.WriteLine("******** - Thank you for using the sample calculator! - ********");
