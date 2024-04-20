using FiguresCalculations;

double a = double.Parse(Console.ReadLine());

double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());
double r = double.Parse(Console.ReadLine());


var rectangle = new Rectangle(a, b);
var triangle = new Triangle(a, b, c);
var circle = new Circle(r);

rectangle.Calculations(rectangle.Side1, rectangle.Side2);
triangle.Calculations(triangle.Side1, triangle.Side2, triangle.Side3);
circle.Calculations(circle.Radius);




Figure[] figures = [ rectangle, triangle, circle, triangle, rectangle ];

SumOfAllPerimeters(figures);

static void SumOfAllPerimeters(Figure[] figures)
{
    double perimall = 0;

    for (int i = 0; i < figures.Length; i++)
    {
        perimall += figures[i].Perimeter;
    }
    Console.WriteLine($"Sum of all perimeters is {perimall}");
}