namespace P11.RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double pyramidLenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double pyramidWidth = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double pyramidHeight = double.Parse(Console.ReadLine());
            double pyramidVolume = (pyramidLenght * pyramidWidth * pyramidHeight) / 3;
            Console.WriteLine($"Pyramid Volume: {pyramidVolume:f2}");
        }
    }
}