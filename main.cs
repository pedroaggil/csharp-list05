using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Bem vindo(a) à 4° Lista de Exercícios em C#! \n");
            Console.WriteLine("Espero que as soluções aqui dispostas sejam-lhe de seu agrado! :D");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();

    // Ex 001
            Console.WriteLine("Escreva 15 números: \n");
    
            int[] vetor = new int[15];
            int i;

            for (i = 0; i < 15; i++) {
              Console.Write("Digite o {0}° número: ", i+1);
              vetor[i] = int.Parse(Console.ReadLine());
            }
    
            Console.WriteLine("\nOs registros com índices pares entre os digitados são: ");

            for (i = 0; i < 15; i++) {
              if (i % 2 != 0) {
                Console.WriteLine("{0}. número: {1}", i+1, vetor[i]);
              }
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();

    // Ex 002
            Console.WriteLine("Cadastre 10 produtos: \n");
            string[] name = new string[10];
            double[] value = new double[10];
            int a;

            for(a = 0; a < 10; a++) {
                Console.Write("Digite o nome do {0}º produto: ", a+1);
                name[a] = Console.ReadLine().ToUpper();
            }
    
            Console.WriteLine();
    
            for (a = 0; a < 10; a++) {
                Console.Write("Digite o valor do produto '{0}': ", name[a]);
                value[a] = double.Parse(Console.ReadLine());
            }
    
            Console.WriteLine();

            Console.WriteLine("Digite os dinheiros disponíveis: R$ ");
            Console.WriteLine();
    
            double wallet = double.Parse(Console.ReadLine());
    
            Console.WriteLine("Produtos disponíveis para compra: \n");
    
            for (a = 0; a < 10; a++) {
                if(wallet > value[a]) { 
                    Console.WriteLine("'{0}' ... R$ {1}", name[a], value[a]);
                }
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();

    // Ex 003
            Console.WriteLine("Escreva 3 números por registro e, ao final, veja a soma dos valores de cada registro: \n");
            int[,] matrix = new int[5, 3];
            int b, c;

            for (c = 0; c < 5; c++) {
                for(b = 0; b < 3; b++) {
                    Console.Write("Digite o {0}° número do {1}° linha: ", b+1, c+1);
                    matrix[c, b] = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }
    
            Console.WriteLine();

            int res;
            for (c = 0; c < 5; c++) {
                res = 0;
                for (b = 0; b < 3; b++) {
                    res = res + matrix[c, b];
                }
              
                Console.WriteLine("Soma n° {0}: {1} + {2} + {3} = {4}", c + 1, matrix[c, 0], matrix[c, 1], matrix[c, 2], res);
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();

    // Ex 004
            Console.WriteLine("Cadastre 25 números em uma tabela 5x5 e veja apenas os números das células diagonais: \n");

            double[,] matriz = new double[5, 5];
            int d, e;

            for (d = 0; d < 5; d++) {
                for (e = 0; e < 5; e++) {
                    Console.Write("Digite o {0}° número da linha n° {1}: ", e+1, d+1);
                  
                    matriz[d, e] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (d = 0; d < 5; d++) {
                for (e = 0; e < 5; e++) {
                    if (e == 0) {
                        Console.WriteLine("{0} {1} {2} {3} {4}", matriz[d, 0].ToString("00"), matriz[d, 1].ToString("00"), matriz[d, 2].ToString("00"), matriz[d, 3].ToString("00"), matriz[d, 4].ToString("00"));
                    }
                }
            }
            Console.WriteLine();
            Console.ReadKey();

            //mostando diagonais
            Console.WriteLine("{0} * * * {1}", matriz[0, 0].ToString("00"), matriz[0, 4].ToString("00"));
            Console.WriteLine("* {0} * {1} *", matriz[1, 1].ToString("00"), matriz[1, 3].ToString("00"));
            Console.WriteLine("* * {0} * *", matriz[2, 2].ToString("00"));
            Console.WriteLine("* {0} * {1} *", matriz[3, 1].ToString("00"), matriz[3, 3].ToString("00"));
            Console.WriteLine("{0} * * * {1}", matriz[4, 0].ToString("00"), matriz[4, 4].ToString("00"));
    
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();

    // Ex 005
            Console.WriteLine("Cadastre 10 alunos e três menções para cada um; ao final, receba a média para avaliação individual: \n");
    
            string[] students = new string[10];
            double[,] rating = new double[10, 3];
            int x, y;

            for (x = 0; x < 10; x++) {
                Console.Write("Digite o nome do {0}° aluno: ", x+1);
                students[x] = Console.ReadLine().ToUpper();
            }

            for (x = 0; x < 10; x++) {
                Console.Clear();
                for (y = 0; y < 3; y++) {
                    Console.Write("Digite a {0}° menção do aluno '{1}': ", y + 1, students[x]);
                    rating[x, y] = double.Parse(Console.ReadLine());
                  
                    Console.Clear();
                }
            }

            for (x = 0; x < 10; x++)
            {
                double result = rating[x, 0] + rating[x, 1] + rating[x, 2];
                double average = Average(3, result);
                string approval = Approval(average);

                if (approval == "Recusado")
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                
                Console.WriteLine("\n '{0:n}' \n Menção 01: {1:n} \n Menção 02: {2:n} \n Menção 03: {3:n} \n MÉDIA: {4:n} \n SITUAÇÃO: {5}", students[x], rating[x, 0], rating[x, 1], rating[x, 2], average, approval);
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();

  } static double Average(double quantity, double result) {
      // Retorna a média das menções do aluno
    
      double average = result / quantity;
      return average;
    
  } static string Approval(double average) {
      // Retorna a situação de aprovação do aluno
    
      if (average < 7)
        return "Recusado";
      else
        return "Aprovado";
    
  }
}