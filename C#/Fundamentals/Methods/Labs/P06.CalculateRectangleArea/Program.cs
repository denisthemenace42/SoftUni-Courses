static double getRectangleAre(double width, double height)
{
    return width * height;
     
}

double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

double area = getRectangleAre(width,height);
Console.WriteLine(area);