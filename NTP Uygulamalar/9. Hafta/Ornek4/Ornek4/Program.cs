namespace Ornek4
{
    class X
    {
        protected int a;
        public X(int a)
        {
            Console.WriteLine("X " + a);
            this.a = a;
        }
        public int A
        {
            get
            {
                Console.WriteLine("X Sınıfı=" + a);
                return a;
            }
        }
    }
    class Y : X
    {
        protected int b;
        public Y(int a) : base(a)
        {
            Console.WriteLine("Y " + a);
            this.b = a;
        }
        new public int A
        {
            get
            {
                Console.WriteLine("Y sınıfı=" + b);
                return b;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Y y = new Y(5);
            X yy = new X(6);
            int deneme = y.A;
            int deneme2 = yy.A;
        }
    }
}