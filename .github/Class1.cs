using System;

public class ConvexQuadrilateral
{
    public (double, double) Vertex1 { get; }
    public (double, double) Vertex2 { get; }
    public (double, double) Vertex3 { get; }
    public (double, double) Vertex4 { get; }

    public ConvexQuadrilateral((double, double) vertex1, (double, double) vertex2,
                               (double, double) vertex3, (double, double) vertex4)
    {
        Vertex1 = vertex1;
        Vertex2 = vertex2;
        Vertex3 = vertex3;
        Vertex4 = vertex4;
    }

    // Метод для обчислення відстані між двома точками
    private double Distance((double, double) point1, (double, double) point2)
    {
        return Math.Sqrt(Math.Pow(point2.Item1 - point1.Item1, 2) + Math.Pow(point2.Item2 - point1.Item2, 2));
    }

    // Метод для обчислення периметра чотирикутника
    public double Perimeter()
    {
        double side1 = Distance(Vertex1, Vertex2);
        double side2 = Distance(Vertex2, Vertex3);
        double side3 = Distance(Vertex3, Vertex4);
        double side4 = Distance(Vertex4, Vertex1);

        return side1 + side2 + side3 + side4;
    }
}

public class Program
{
    public static void Main()
    {
        // Створення об'єкта чотирикутника
        var quad = new ConvexQuadrilateral((0, 0), (4, 0), (4, 3), (0, 3));

        // Обчислення і виведення периметра
        Console.WriteLine("Perimeter: " + quad.Perimeter());
    }
}
