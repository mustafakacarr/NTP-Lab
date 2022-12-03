using System;
class Program
{
    public delegate void KomutMetodu();
    //Geri dönüş tipi void olan ve parametre almayan bir temsilci bildirdik.
    public struct KomutYapisi
    { //KomutYapisi isminde bir yapı başlattık.
        public KomutMetodu KomutMetot;
        //Yapımıza geri dönüş tipi KomutMetodu temsilcisi olan bir özellik ekledik.
        public string Komut; //Yapımıza bir özellik daha ekledik.
    }
    public static void Komut1()
    { //Sınıfımıza bir metot ekledik.
        Console.WriteLine("Komut1 çalıştı.");
    }
    public static void Komut2()
    { //Sınıfımıza bir metot daha ekledik.
        Console.WriteLine("Komut2 çalıştı.");
    }
    public static void Komut3() //Sınıfımıza bir metot ekledik.
    {
        Console.WriteLine("Komut3 çalıştı.");
    }
    public static void Komut4() //Sınıfımıza bir metot ekledik.
    { Console.WriteLine("Komut4 çalıştı."); }
    static void Main()
    {
        KomutYapisi[] komutlar = new
    KomutYapisi[4]; //KomutYapisinesnelerinden oluşan bir dizi oluşturduk. (4 elemanlı)
        komutlar[0].Komut = "komut1";
        //komutlar[0] nesnesinin Komut özelliğine değer atadık.
        komutlar[0].KomutMetot = new
        KomutMetodu(Komut1); //Artık komutlar[0] nesnesinin KomutMetot özelliği Komut1'i temsil ediyor. Aynı durumlar diğer komutlar için de geçerli.
        komutlar[1].Komut = "komut2";
        komutlar[1].KomutMetot = new
        KomutMetodu(Komut2);
        komutlar[2].Komut = "komut3";
        komutlar[2].KomutMetot = new
        KomutMetodu(Komut3);
        komutlar[3].Komut = "komut4";
        komutlar[3].KomutMetot = new
        KomutMetodu(Komut4);
        Console.Write("Komut girin: "); string
        GirilenKomut = Console.ReadLine(); for (int
        i = 0; i < komutlar.Length; i++)//komutlar dizisi içinde dolaşmaya çıkıyoruz.
            if (GirilenKomut == komutlar[i].Komut)
                komutlar[i].KomutMetot();
    }
}