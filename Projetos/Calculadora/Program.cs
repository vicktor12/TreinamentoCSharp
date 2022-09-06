namespace Calculadora {

    class Program {

        static void Main (string[] args){

            double num1, num2;
            string operador;

            Inicio:
            Console.Write("Informe o 1º numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o 2º numero: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Agora informa qual operação deseja realizar ### somar, subtrair, dividir, multiplicar | ou informe operador correspondente, exemplo + ###");
            operador = Console.ReadLine();

            switch(operador){
                case "somar":
                    Console.WriteLine(num1 + num2);
                    break;
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "subtrair":
                    Console.WriteLine(num1 - num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "dividir":
                    Console.WriteLine(num1 / num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                case "multiplicar":
                    Console.WriteLine(num1 * num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                default:
                    Console.WriteLine("Operador informado inválido!");
                    Console.WriteLine("Deseja tentar novamente?");
                    string res = Console.ReadLine();
                    if(res == "sim")
                        goto Inicio;
                    else
                        Console.WriteLine("Tudo bem! A aplicação será encerrada");
                        break;
            }
        }
    }
}