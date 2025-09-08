//-----------------------------------------------------------------
// Type Casting
//-----------------------------------------------------------------

// double → int
double a = 3.14;
int b = Convert.ToInt32(a);

Console.WriteLine(b);
Console.WriteLine(a.GetType());   // display data type

// int → double
int c = 123;
double d = Convert.ToDouble(c) + 0.1;

Console.WriteLine(d);
Console.WriteLine(d.GetType());

// int → string
int e = 321;
String f = Convert.ToString(e);

Console.WriteLine(f);
Console.WriteLine(f.GetType());

// string → char
String g = "$";
char h = Convert.ToChar(g);

Console.WriteLine(h);
Console.WriteLine(h.GetType());

// string → boolean
string i = "true";
bool j = Convert.ToBoolean(i);

Console.WriteLine(j);
Console.WriteLine(j.GetType());