namespace ConversorTemperaturas {

    class Program {

        static void Main (string[] args){

            double c, f, k;

            Console.WriteLine("### CONVERSOR DE TEMPERATURAS ####");
            Console.Write("Insira a Temperatura em Celsius ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            f = ((c * 9)/5) + 32;
            k = c + 273.15;

            Console.WriteLine("A temperatura em Celsius informada foi : " + c);
            Console.WriteLine("Em Fahrenheit fica: " + f);
            Console.WriteLine("Em Kelvin fica: " + k);
        }
    }
}