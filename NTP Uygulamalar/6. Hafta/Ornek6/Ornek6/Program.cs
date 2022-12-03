using Ornek6;

namespace Ornek6
{
    struct üniversite
    {
        public string fakulte; public string bolum; public string Ogr_gor;
        public üniversite(string a, string b, string c)
        { fakulte = a; bolum = b; Ogr_gor = c; }
    }
    class Program
    {
        public static void Main()
        {
            üniversite k1 = new üniversite("Teknoloji Fakültesi", "Yazılım Mühendisliği", "2.sınıf");
            üniversite k2;
            Console.WriteLine(k1.fakulte);
            Console.WriteLine(k1.bolum);
            Console.WriteLine(k1.Ogr_gor);
            k2.fakulte = "Tıp Fakultesi";
            Console.WriteLine();
            Console.WriteLine(k2.fakulte);
        }
    }
}