using static MindBox.GeometryLibrary;

Circle circle = new Circle(5);
Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");

Triangle triangle = new Triangle(3, 4, 5);
Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
Console.WriteLine($"Прямоугольный треугольник: {triangle.IsRightTriangle()}");

Console.ReadLine();