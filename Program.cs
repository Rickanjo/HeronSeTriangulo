// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Digite o lado 'a' do triângulo: ");
double a = double.Parse(Console.ReadLine()!);

Console.Write("Digite o lado 'b' do triângulo: ");
double b = double.Parse(Console.ReadLine()!);

Console.Write("Digite o lado 'c' do triângulo: ");
double c = double.Parse(Console.ReadLine()!);

if (a < b + c && b < a + c && c < a + b && a > Math.Abs(b - c) && b > Math.Abs(a - c) && c > Math.Abs(a - b))
{

    if (a == b && b == c)
     {
        Console.WriteLine("\nO triângulo é equilátero.");
    }
    else if (a != b && a != c && b != c) 
    {
        Console.WriteLine("O triângulo é escaleno.");
    }
    else 
    {
        Console.WriteLine("O triângulo é isósceles.");
    }

    double p = (a + b + c) / 2;
    double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

    Console.WriteLine($"A área do triângulo é {area:F2}.");
}
else 
{
    Console.WriteLine("Os lados informados não formam um triângulo válido.");
}