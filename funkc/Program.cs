using System;

namespace funkc
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());

           Program.FidRec(k);
            
        }
        static int FidRec(int n )
        {
          int F1;
          int F2;
          int Fk = 0;
            for (int i = 2; i < 7; i++)
            {

                F1 = n - 2;
                F2 = n - 1;
                if (F1 == 2 || F2 == 1)
                {
                    F1 = 1;
                    F1 = 1;

                    Fk += (F1) + (F2);
                    Console.WriteLine(Fk);
                }
                else
                {

                    Fk += (F1) + (F2);
                    Console.WriteLine(Fk);
                }
            }
            return Fk;
        }
    }
}
