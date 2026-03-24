namespace Matrici6
{
    internal class Program
    {

        static void creare(int[,] M)
        {

            int c = 10;
            int c1 = 10;
            int c2 = 10;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                c = 10;
                Console.WriteLine();

                for(int j=0;  j < M.GetLength(1); j++)
                {
                    M[i, j] = c * c2;
                    c--;
                    Console.Write($"[{M[i, j]}]");

                }
                c2--;

                
            }
        }
        static int intervallo(int[,] M, int x,  int y)
        {
            int contatore = 0;
            for (int i = 0;i < M.GetLength(0); i++)
            {
                for(int j = 0; j < M.GetLength(1); j++)
                {
                    if( M[i, j] >= x && M[i,j]<=y )
                    {
                        contatore++;
                    }
                }
            }
            return contatore;
        }

        static float media(float[,] M)
        {
            float [] V=new float[M.GetLength(0)];
        }
        static void Main(string[] args)
        {
            int[,] M = new int[10, 10];
            creare(M);

            int stampa;

            Console.WriteLine("\nDimmi il primo numero dell intervallo");
            int x=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDimmi il secondo numero dell intervallo");
            int y=Convert.ToInt32(Console.ReadLine());

            stampa = (intervallo(M, x, y));
            Console.WriteLine((stampa));

        }
    }
}
