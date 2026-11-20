//My name is Amin Torabi
//Here we're gonna enter a four-digit number
//And this number is gonna be reversed
//first part
Console.Clear();
try
{
    Console.ForegroundColor=ConsoleColor.Red;
    Console.WriteLine("Tap to start reversing your input number");
    Console.ForegroundColor=ConsoleColor.White;
    Console.ReadKey(true);
    await Task.Delay(2000);
    Console.Clear();
    Console.ForegroundColor=ConsoleColor.Red;
    Console.WriteLine("Please enter just four-digit numbers");
    Console.ForegroundColor=ConsoleColor.White;
    Console.Write("\nNumber: ");
    var number=Convert.ToInt32(Console.ReadLine());
    var number1=number%10;
    var d1=number/10;
    var number2=d1%10;
    var d2=d1/10;
    var number3=d2%10;
    var d3=d2/10;
    var number4=d3;
    await Task.Delay(2000);
    Console.Write($"Reversed number: {number1}{number2}{number3}{number4}");
}
catch(FormatException)
{
    Console.WriteLine("Invalid input, please enter number");
}
catch(OverflowException)
{
    Console.WriteLine("Invalid input, please enter the correct number");
}
catch
{
    Console.WriteLine("Invalid input, please try again");
}
//try-catch added    