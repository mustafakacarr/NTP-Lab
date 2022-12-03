namespace Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = { { 1, 2 }, { 2, 3 }, { 3, 4 }, { 4, 5 }, };
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<2; j++)
                {
                    Console.WriteLine(dizi[i,j]);
                }
            }
        }
    }
}