namespace Ornek5
{
    enum notu : byte { basarisiz, basarili }

    internal class Program
    {
        static void Main(string[] args)
        {
            notu a = notu.basarili;
            if (a == (notu)1)
                Console.Write("Başarılısınız");
            else
                Console.Write("Başarısızsınız");
        }
    }
}