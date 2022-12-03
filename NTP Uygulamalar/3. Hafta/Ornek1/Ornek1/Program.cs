namespace Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2; int b = 3; int c = 6; int d = 1;
            /* (a < b) = bu ifadenin doğru (true) olduğunu biliyoruz
            (c < d) = bu ifadenin yanlış (false) olduğunu biliyoruz */
            Console.WriteLine(" (a<b)&&(c<d) --> " + ((a < b) && (c < d)));
            Console.WriteLine(" (a<b)||(c<d) --> " + ((a < b) || (c < d)));
            Console.WriteLine(" ! (a<b) -->" + (!(a < b)));
            Console.WriteLine(" (a<b)&(c<d) --> " + ((a < b) & (c < d)));
            Console.WriteLine(" (a<b)|(c<d) --> " + ((a < b) | (c < d)));
            Console.WriteLine(" (a<b)^(c<d) --> " + ((a < b) ^ (c < d)));
        }
    }
}