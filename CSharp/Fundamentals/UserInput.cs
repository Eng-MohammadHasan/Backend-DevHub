//-----------------------------------------------------------------
// User Input
//-----------------------------------------------------------------

// In C#, when using Console.ReadLine() to get user input from the console, 
// the input is always received as a string data type. This is the fundamental 
// behavior of Console.ReadLine().
//
// However, this does not mean you can only use string input. If you need to 
// work with other data types, such as integers (int), doubles (double), or 
// booleans (bool), you must explicitly convert the received string to the 
// desired data type. This process is known as parsing or type conversion.

Console.WriteLine("Please Enter your name : ");
String name = Console.ReadLine();

Console.WriteLine("What's your age?");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nHello " + name);
Console.WriteLine("Your are " + age + "years old");


