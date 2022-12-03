public class UrunTemel
{
    private int urunKodu;
    private double urunFiyati;
    private string urunBilgisi;
    public UrunTemel(int kod, double fiyat, string bilgi)
    {
        urunKodu = kod;
        urunFiyati = fiyat;
        urunBilgisi = bilgi;
    }
    public int UrunKodu
    {
        get { return urunKodu; }
    }
    public double BirimFiyat
    {
        get { return urunFiyati; }
    }
    public string UrunTanimi
    {
        get { return urunBilgisi; }
    }
}
public class Lastik : UrunTemel
{
    private int capi;
    private int genislik;
    private string tipi;
    public Lastik(int kodu, double fiyat,
  string bilgi) : base(kodu, fiyat, bilgi) { }
    public int Cap
    {
        get { return capi; }
        set
        { capi = value; }
    }
    public int Genislik
    {
        get { return genislik; }
        set { genislik = value; }
    }
    public string Tip
    {
        get { return tipi; }
        set { tipi = value; }
    }
    public override string ToString()
    {
        return UrunKodu.ToString() + " " +
    BirimFiyat.ToString() + " " + UrunTanimi + " "
    + Cap.ToString() + " " + Genislik.ToString() +
    Tip;
    }
}

public class Silecek : UrunTemel
{
    private int uzunluk;
    public Silecek(int kodu, double fiyat,
  string bilgi) : base(kodu, fiyat, bilgi)
    {
    }
    public int Uzunluk
    {
        get { return uzunluk; }
        set
        { uzunluk = value; }
    }
    public override string ToString()
    {
        return UrunKodu.ToString() + " " +
      BirimFiyat.ToString() + " " + UrunTanimi +
      " " + Uzunluk.ToString();
    }
}
public class Urunler<T> where T : UrunTemel
{
    private List<T> urunListe;
    public Urunler()
    {
        urunListe = new List<T>();
    }
    public void Ekle(T uye)
    {
        urunListe.Add(uye);
    }
    public void Sil(T uye)
    {
        urunListe.Remove(uye);
    }
    public void Listele()
    {
        foreach (T uye in urunListe)
        {

            Console.WriteLine(uye.ToString());
        }
    }
}

class Program
{
    static void Main()
    {
        Urunler<UrunTemel> urunler = new
Urunler<UrunTemel>();
        Lastik lst = new Lastik(1000, 10,
      "Otomobil Lastiği");
        lst.Tip = "Kış Lastiği";
        lst.Cap = 185;
        lst.Genislik = 75;
        Silecek slc = new Silecek(1001, 5,
      "On silecek takimi");
        slc.Uzunluk = 60;
        urunler.Ekle(lst);
        urunler.Ekle(slc);
        urunler.Listele();
    }
}