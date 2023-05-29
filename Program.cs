internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter the height: ");
        int h=int.Parse(Console.ReadLine());
        Console.WriteLine("enter width: ");
        int w =int.Parse(Console.ReadLine());
        if (h > w)
        {
            Console.WriteLine("this image is in portrait mode!");
        }
        else
        {
            Console.WriteLine("the image is in landscape mode!");
        }
    }
}