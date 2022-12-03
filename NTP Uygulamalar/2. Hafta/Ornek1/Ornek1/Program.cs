namespace Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0; int d = (int)6.0; //float -> integer dönüşüm
            object k = "merhaba" + 15; //object türü, hem karakter hem sayısal
            float b = 10.5f; //float tanımı
            double c = 20.1; //double tanımı
            Double dd = new double(); //referans olarak double tanımı
            const double pi = 3.14; //sabit tanımı
            string[] isimler = { "Ozlem", "Nesrin", "Ozge", "Fulya" }; //string dizi tanımı
            object[] isim = { "Ozlem", "Nesrin", "Ozge", "Fulya" }; //object dizi tanımı 
            string s = "true"; //string tanımı
            string ad ="12.45";
            b = float.Parse(ad); //string tip float’a çevriliyor
            b = Convert.ToSingle(dd); //String float’a çevriliyor
            a = Convert.ToInt32(b + c); //float -> integer
            bool cevap = (Convert.ToBoolean(s)); //boolean tanımı
            Console.Write((float)a / d + "\n"); // () operatörü ile float dönüşümü
            Console.WriteLine("cevap=" + cevap); // cevap = true yazar
            Console.WriteLine(k.GetType()); //bulunduğu sınıf,alanadını verir.
            Single cd = Convert.ToSingle(Console.ReadLine()); //girilen değer float’a çevriliyor
            Console.WriteLine("a ={ 0} b = { 1} c ={ 2} d ={ 3} ", cd, b, c,d);
if (isimler[0].Equals("Ozlem") == true) //eğer dizinin ilk elemanı Ozlem ise yazar
                Console.WriteLine("birinci isim Ozlem");
            foreach (string ss in isimler) // string dizi içindeki her bir eleman yazdırılıyor
            { Console.WriteLine(ss); }

        }
    }
}