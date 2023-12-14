// See https://aka.ms/new-console-template for more information

Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

/* 
    Math Operations and operators
 */
// Add numbers
int sum = num1 + num2;
// multiply
int product = num1 * num2;
// Division
int quotient = num1 / num2;
// Subtraction
int difference = num1 - num2;
// Modulus
int mod = num1 % num2;

Console.WriteLine("***************** Math Results **************");
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine();
Console.WriteLine("***************** End Math Results **************");


/*
    Logic Operations and Operators
 */

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo =  num1 >= num2;
bool isLessThanOrEqualTo =  num1 <= num2;
bool isNotEqual =  num1 != num2;

Console.WriteLine("***************** Logic Results **************");
Console.WriteLine();
Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"Is Equal To: {isEqualTo}");
Console.WriteLine($"Is Greater Than Or Equal To: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than Or Equal To: {isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal: {isNotEqual}");
Console.WriteLine();
Console.WriteLine("***************** End Logic Results **************");

/*
    Assignment Operations and Operators
 */
Console.Write("Enter Random Value for Assignment Operations: ");
int randomValue = Convert.ToInt32(Console.ReadLine());
//int increaseValue = num1 + randomValue;

Console.WriteLine("***************** Assignment Results **************");
Console.WriteLine();
//num1 = num1 + randomValue;
num1 += randomValue;
Console.WriteLine($"Num 1 increased by {randomValue}: {num1}");
//num1 = num1 - randomValue;
num1 -= randomValue;
Console.WriteLine($"Num 1 reduced by {randomValue}: {num1}");
//num1 = num1 * randomValue;
num1 /= randomValue;
Console.WriteLine($"Num 1 divided by {randomValue}: {num1}");
//num1 = num1 / randomValue;
num1 %= randomValue;
Console.WriteLine($"Num 1 mod by {randomValue}: {num1}");
//num1 = num1 % randomValue;
num1 *= randomValue;
Console.WriteLine($"Num 1 multiplied by {randomValue}: {num1}");
Console.WriteLine();
Console.WriteLine("***************** End Assignment Results **************");
