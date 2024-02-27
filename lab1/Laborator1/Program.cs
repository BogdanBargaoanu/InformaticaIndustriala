namespace Laborator1
{
    class Numere 
    {
        private int a;
        private int b;
        public Numere(int a, int b) 
        {
            this.a = a;
            this.b = b;
        }
        public int Suma()
        {
            return a + b;
        }

        public int Scadere()
        {
            return a - b;
        }

        public int Inmultire()
        {
            return a * b;
        }

        public float Divizare()
        {
            float aa = a;
            float bb = b;
            return aa / bb;
        }
    }

    internal class Program
    {

        private void Fibbonaci(int n)
        {
            int a = 0, b = 1, c = 0;
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(c);
            }
        }

        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Numere num = new Numere(a, b);
        }
    }
    
}