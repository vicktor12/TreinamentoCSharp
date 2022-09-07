namespace FatorialDeNumero
{
    
    class Program
    {

        static void Main (string[] args)
        {

            Console.Write("calcular fatorial de qual numero? ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("O fatorial de " + num + " é " + Fatorial(num));
        }

        static int Fatorial(int num)
        {
            if (num <= 0)
            {
                return 1;
            }
            return num * Fatorial(num -1);
        }
    }
}