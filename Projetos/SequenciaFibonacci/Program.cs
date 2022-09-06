namespace SequenciaFibonacci {

    class Program {

        static void Main (string[] args){

            int num1 = 0, num2 = 1, c = 0;
            
            Console.Write("Deseja que seja impresso quantos numeros? ");
            int valor = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < valor; i++){
                if(i < valor -1)
                    Console.Write(num1 + ", ");
                else
                    Console.Write(num1);

                c = num1 + num2;
                num1 = num2;
                num2 = c;
            }
        }
    }
}