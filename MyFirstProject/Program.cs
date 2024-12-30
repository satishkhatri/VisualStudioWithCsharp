using MyFirstProject;
Console.WriteLine("Hello, World!");
Console.WriteLine("Please enter first number");

float a = 0; ;
string a1 = Console.ReadLine();
try
{
    a = float.Parse(a1 ?? "0");
}

catch (FormatException ex)
{

    Console.WriteLine("Invalid input. Please enter a valid number.{ ex.Message}");
}

Console.WriteLine("Please enter 2nd number");

float b1 = 0;
try
{
    string? b = Console.ReadLine();
    b1 = float.Parse(b ?? "0");
}
catch (FormatException ex)
{
    Console.WriteLine("Invalid input. Please enter a valid number.{ ex.Message}");

}


float result = ClassLibrary1.Calculator.add(a, b1);
Console.WriteLine("Adding is " + result);

float result1 = ClassLibrary1.Calculator.sub(a, b1);
Console.WriteLine("Substraction is : " + result1);

multply(a, b1);


static void multply(float a, float b)
{

    float result2 = ClassLibrary1.Calculator.multiply(a, b);
    Console.WriteLine("Multiply is " + result2);
    Console.WriteLine("Hello");
}


MathProblam mathproblam = new MathProblam();
string reuslt20 = mathproblam.somOfNumber(23, 34).ToString();



Console.WriteLine(reuslt20);
Console.WriteLine("hello Satios");
