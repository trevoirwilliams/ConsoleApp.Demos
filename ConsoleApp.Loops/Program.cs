// See https://aka.ms/new-console-template for more information

// Simple For Loop Demo
// Print Hello World 10 times
// 0 1 2 3 4 5 6 7 8 9
Console.WriteLine("***************** Simple For Loop **************");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello, World! - {i}");
}

// Ask User how many times they wish to print hello world and print accordingly
Console.WriteLine("How many times should we print hello world?");
int userCount = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < userCount; i++)
{
    Console.WriteLine($"Hello, World! - {i}");
}

Console.WriteLine("***************** Simple For Loop Completed **************");

// While Loop
Console.WriteLine("***************** While Loop **************");

int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Hello, World! - {counter}");
    counter += 2;
}

// Ask the user for a number and find the total for each number that is entered. Print final sum when the user enters -1 to exit. 
int sum = 0;
int num = 0;
while(num != -1)
{
    Console.Write("Please number to be summed. (-1 to stop or exit): ");
    num = Convert.ToInt32(Console.ReadLine());
    // nested if statement
    if (num != -1)
    {
        sum += num;
    }

    //// using break keyword
    //if (num == -1)
    //{
    //    break;
    //}
}

Console.WriteLine($"Your sum is: {sum}");
Console.WriteLine("***************** While Loop Completed **************");

Console.WriteLine("***************** Do While Loop **************");
sum = 0;
num = -1;
do
{
    Console.Write("Please number to be summed. (-1 to stop or exit): ");
    num = Convert.ToInt32(Console.ReadLine());
    // nested if statement
    if (num != -1)
    {
        sum += num;
    }
} while (num != -1);
Console.WriteLine($"Your sum is: {sum}");
Console.WriteLine("***************** Do While Loop Completed **************");
