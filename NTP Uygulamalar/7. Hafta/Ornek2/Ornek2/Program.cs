namespace isimalan1
{
    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme 1");
        }
    }
}
namespace isimalan2
{
    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme 2");
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        isimalan1.Deneme d1 = new isimalan1.Deneme();
        isimalan2.Deneme d2 = new isimalan2.Deneme();
    }
}
