namespace Ornek6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0, j = 0; i < 20; i++, j++)
            {
                i *= j;
                Console.WriteLine("i = " + i + " j = " + j);
            }
        }
    }
}