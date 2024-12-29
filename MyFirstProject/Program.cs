using MyFirstProject;



// See https://aka.ms/new-console-template for more information



Console.WriteLine("Hello, World!");
Console.WriteLine("Please enter first number");
float a = float.Parse(Console.ReadLine());
Console.WriteLine("Please enter 2nd number");
float b = float.Parse(Console.ReadLine());

float result = ClassLibrary1.Calculator.add(a, b);
Console.WriteLine("Adding is " + result);

float result1 = ClassLibrary1.Calculator.sub(a, b);
Console.WriteLine("Substraction is " + result1);

multply(a, b);


static void multply(float a, float b)
{

    float result2 = ClassLibrary1.Calculator.multiply(a, b);
    Console.WriteLine("Multiply is " + result2);
    Console.WriteLine("Hello");
}


MathProblam mathproblam = new MathProblam();
string reuslt20 = mathproblam.somOfNumber(23, 34).ToString();



Console.WriteLine(reuslt20);

