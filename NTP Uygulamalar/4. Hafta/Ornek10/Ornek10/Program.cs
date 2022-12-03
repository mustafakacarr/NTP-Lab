namespace Ornek10
{
    internal class Program
    {
        static int Faktoriyel(int a)
        {
            if (a == 0)
                return 1;
            return a * Faktoriyel(a - 1); //fonksiyon kendi içerisinde çağrıldı
        }
        static void Main(string[] args)
        {
            Console.Write("Faktöriyelini alacağınız sayıyı giriniz :");
            int fak_değeri = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Girmiş olduğunuz sayının faktöriyeli :" +
            Faktoriyel(fak_değeri));

        }
    }
}