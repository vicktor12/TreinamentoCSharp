namespace CalcularIMC {
    
    class Program {

        static void Main (string[] args) {

            double peso = 0;
            double altura = 0;
            double imc = 0;

            Console.Write("Qual o seu peso? ");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua altura? ");
            Console.WriteLine("### Digite com ponto, EXEMPLO: 1.80 ###");
            altura = double.Parse(Console.ReadLine());
            //imc = peso / Math.Pow(altura, 2);
            imc = peso / (altura * altura);
            Console.WriteLine("Seu IMC é de: " + imc);

            #region Verificando Estado de IMC usando IF e ELSE
                if( imc <= 18.5){
                    Console.WriteLine("IMC considerado em estado de magreza");
                } else if (imc > 18.5 && imc <= 24.9){
                    Console.WriteLine("IMC considerado em estado normal");
                } else if (imc > 25 && imc <= 29.9) {
                    Console.WriteLine("IMC considerado em estado de sobrepeso");
                } else if (imc > 30 && imc <= 39.9) {
                    Console.WriteLine("IMC considerado em estado de obesidade");
                } else {
                    Console.WriteLine("IMC considerado em estado de obesidade grave");
                }
            #endregion

        }
    }
}