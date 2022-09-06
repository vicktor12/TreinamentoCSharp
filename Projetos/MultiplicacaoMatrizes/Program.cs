namespace MultiplicacaoMatrizes {
    
    class Program {

        static void Main (string[] args) {

            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[3, 2];
            int[,] matriz3 = new int[2, 2];

            Console.WriteLine("### Populando as matrizes ###");
            #region Matriz 1
                Console.WriteLine("Informe o valor para a 1ª linha e a 1ª coluna da 1ª matriz: ");
                matriz1[0, 0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor para a 1ª linha e a 2ª coluna da 1ª matriz: ");
                matriz1[0, 1] = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor para a 1ª linha e a 3ª coluna da 1ª matriz: ");
                matriz1[0, 2] = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o valor para a 2ª linha e a 1ª coluna da 1ª matriz: ");
                matriz1[1, 0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor para a 2ª linha e a 2ª coluna da 1ª matriz: ");
                matriz1[1, 1] = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor para a 2ª linha e a 3ª coluna da 1ª matriz: ");
                matriz1[1, 2] = int.Parse(Console.ReadLine());
            #endregion

            #region Matriz 2
                Console.WriteLine("Informe o valor para a 1ª linha e a 1ª coluna da 2ª matriz: ");
                matriz2[0, 0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor para a 1ª linha e a 2ª coluna da 2ª matriz: ");
                matriz2[0, 1] = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o valor para a 2ª linha e a 1ª coluna da 2ª matriz: ");
                matriz2[1, 0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor para a 2ª linha e a 2ª coluna da 2ª matriz: ");
                matriz2[1, 1] = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o valor para a 3ª linha e a 1ª coluna da 2ª matriz: ");
                matriz2[2, 0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor para a 3ª linha e a 2ª coluna da 2ª matriz: ");
                matriz2[2, 1] = int.Parse(Console.ReadLine());
            #endregion

            #region Matriz Multiplicada
                Console.WriteLine("### Efetuando multiplicação ###");
                matriz3[0, 0] = ((matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0])) + 
                (matriz1[0, 2] * matriz2[2, 0]);

                matriz3[0, 1] = ((matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1])) + 
                (matriz1[0, 2] * matriz2[2, 1]);

                matriz3[1, 0] = ((matriz1[1, 0] * matriz2[0, 0]) + (matriz1[1, 1] * matriz2[1, 0])) + 
                (matriz1[1, 2] * matriz2[2, 0]);

                matriz3[1, 1] = ((matriz1[1, 0] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1])) + 
                (matriz1[1, 2] * matriz2[2, 1]);
            #endregion

            #region Exibindo matriz 3
                Console.WriteLine("Multiplicação entre as 2 matrizes são: ");
                Console.Write(matriz3[0, 0] + " ");
                Console.WriteLine(matriz3[0, 1]);
                Console.Write(matriz3[1, 0] + " ");
                Console.WriteLine(matriz3[1, 1]);
            #endregion
        }
    }
}