namespace lista_ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            
            int[] num = new int[n];
            Console.WriteLine("Digite 10 números");
            for (int i = 0; i < n; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine($"Moda: {Moda(num)}");
            static int Moda( int[] numero) 
            {
                int rep = 0;
                int dif = numero[0];
                int count = 1;

                for (int i = 0;i < numero.Length;i++) 
                {
                    if (dif != numero[i])
                    {
                        dif = numero[i];
                        count++;
                    }
                    else
                    {
                        if (dif == numero[i])
                        {
                            rep = numero[i];
                            count++;
                        }
                        else
                        {
                            count--;
                        }
                    }
                }
                return rep;
            }

        }
    }
}