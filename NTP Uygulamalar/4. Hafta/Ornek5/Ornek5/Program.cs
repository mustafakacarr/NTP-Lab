namespace Ornek5
{
    internal class Program
    {
        static int BuyukBul(int a,int b)
        {
            if (a > b)
                return a;
            return b;
        }
        static void Main(string[] args)
        {
            int s1, s2;
            Console.Write("1. Sayıyı Girin:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Girin:");
            s2 = Convert.ToInt32(Console.ReadLine());
            int enbuyuk = BuyukBul(s1, s2);
            Console.WriteLine("En Büyük: {0}dir.", enbuyuk);
        }
    }
}