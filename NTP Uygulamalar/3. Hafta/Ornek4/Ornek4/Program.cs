namespace Ornek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0; //döngü kontrol değişkeni
            do
            {
                Console.WriteLine("i = " + i);
                i++;
            } while (i < 0);
        }
    }
}