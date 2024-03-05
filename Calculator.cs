class Calculator
{
        static void Main(string[] args)
        {
            

           int a = 10;
		   int b = 6;
		   

            Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + penambahan(a, b));
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, pembagian(a, b));

                Console.WriteLine("\nTekan sembarang key untuk keluar");
                Console.ReadKey();
            
        
           

        }

        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}

