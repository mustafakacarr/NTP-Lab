using System;
class notlar
{
    private int final;
    private int vize;
    public notlar(int f, int v)
    {
        if (v > 100)
        {
            throw new hatalınot(v, "yapıcı metot");
        }
        final = f;
        vize = v;
    }
    public void degerver(int f, int v)
    {
        if (v > 100)
            throw new hatalınot(v, "degerver metodu");
        final = f;
        vize = v;
    }


    public int Final
    {
        get
        { return final; }
        set
        { final = value; }
    }
    public int Vize
    {
        get
        { return vize; }
        set
        {
            if (value > 100)
                throw new hatalınot(value, "Vize Giriş Hatası");
            vize = value;
        }
    }


    public class hatalınot : ApplicationException
    {
        private int hatalıvize;
        private string hatakaynagı;
        public hatalınot(int hatalıvize, string hatakaynagı)
        {
            this.hatakaynagı = hatakaynagı;
            this.hatalıvize = hatalıvize;
        }
        public int Hatalıvize
        {
            get
            { return hatalıvize; }
        }
        public string Hatakaynagı
        {
            get
            { return hatakaynagı; }
        }

        public override string ToString()
        {
            string str1 = "Hata Kaynağı: " + hatakaynagı + "\n";
            string str2 = "Hata Değeri: " + hatalıvize;
            return str1 + str2;
        }
    }
}
class Program
{
    public static void Main()
    {
        notlar a = new notlar(50, 0);
        try
        { a.Vize = 120; }
        catch (notlar.hatalınot e)
        { Console.WriteLine(e.ToString()); }
    }
}