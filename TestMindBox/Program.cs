// See https://aka.ms/new-console-template for more information


using TestMindBox;

void PrintMenu()
{
    Console.WriteLine("1: Треугольник");
    Console.WriteLine("2: Круг");
}

PrintMenu();
Console.WriteLine("Какую фигуру вы хотите создать?");
var key = Convert.ToInt32(Console.ReadLine());

switch (key)
{
    case 1:
    {
        Console.WriteLine("Введите 3 стороны треуголника через пробел");
        var str = Console.ReadLine();
        var sides = str.Split(" ").Select(double.Parse).ToArray();
        var triangle = new Triangle(sides[0], sides[1], sides[2]);
        var square = triangle.GetSquare();
        Console.WriteLine(triangle.IsRectangular() ? $"Треугольник прямоугольный. Площадь равна {square}" : $"Треугольник не прямоугольный. Площадь равна {square}");
        break;
    }
    case 2:
    {
        Console.WriteLine("Введите радиус круга");
        var circle = new Circle(Convert.ToInt32(Console.ReadLine()));
        var square = circle.GetSquare();
        Console.WriteLine($"Площадь круга равна {square}");
        break;
    }
}