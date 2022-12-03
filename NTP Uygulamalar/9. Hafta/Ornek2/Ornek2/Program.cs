namespace Ornek2
{
    class Kedi
    {
        protected int ayakSayisi = 4;
        public void yakalaAv()
        {
            Console.WriteLine("Kedi sinifi Av yakaladi");
        }
    }
    class Kaplan : Kedi
    {
        public Kaplan()
        {
            Console.WriteLine("Ayak Sayisi = " + ayakSayisi);
        }
    }
    class deneme
    {
        public static void Main(string[] args)
        {
            Kedi kd = new Kedi();
            kd.yakalaAv();
            Kaplan kp = new Kaplan();
            kp.yakalaAv();
        }
    }
}