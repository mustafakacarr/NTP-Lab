using System;

public void Reset() { indeks = -1; }
// Burada sınıfımıza bir metot ekledik. Bu metodu sınıfımızın kullandığı IEnumerator arayüzü gerektiriyordu.
public bool MoveNext()
{
    indeks++; if (indeks < koleksiyon.Dizi.Length)
        return true;
    else return false;
}
// Burada sınıfımıza bir metot daha ekledik. Yine bu metodu da IEnumerator arayüzü gerektiriyordu.
object IEnumerator.Current
{
get { return(koleksiyon.Dizi[indeks]); }
}
// Burada IEnumerator arayüzünün gerektirdiği bir sahte özelliği açık arayüz uygulama yöntemiyle 
hazırladık.
class Program
{
    static void Main()
    {
        // Artık programımızın çalışmaya başlayacağı kısmı yazmaya başlıyoruz.
int[] dizi = { 1, 2, 3, 8, 6, 9, 7 };
        Koleksiyon k = new Koleksiyon(dizi);
        // Dizimizi ve yeni bir Koleksiyon nesnesi oluşturduk.
    foreach (int i in k) Console.Write(i + " ");
        //Ve başardık. nesne2'yi kendi türümüz yaptık. Şimdi nesne1'i kendi türümüz yapacak programı yazalım:
class A
    {
        public int Ozellik;
        public A(int a) { Ozellik = a; }
    }
    class Ana
    {
        static void Main()
        {
            A[] dizi = new A[3]; dizi[0] = new A(10);
            dizi[1] = new A(20); dizi[2] = new A(50);
            foreach (A i in dizi)
                Console.WriteLine(i.Ozellik);
        }
    }
    // Gördüğünüz gibi kendi oluşturduğumuz sınıf türünden 
    nesnelerle diziler oluşturabiliyoruz.Nasıl ki int[] ile int
    türündeki veriler bir araya geliyorsa bizim örneğimizde de
    A türünden nesneler bir araya geldi