Console.WriteLine("Hello Friends.");
Console.WriteLine("Hello from Tested CI/CD! Press any key to exit.");
int i = 10;
try
{
    int x = 10 / i; // This will cause a divide-by-zero error

}
catch (DivideByZeroException divide)
{

    throw new Exception("Divide by zero occurred", divide);
} 
Console.ReadKey();
