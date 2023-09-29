using System;
using System.Threading.Tasks.Dataflow;

class Programa {
    static void Main () {
        Console.WriteLine("Escriba el tamaño de la matriz");
        int TM = int.Parse(Console.ReadLine()!);
        int[,] matriz = new int[TM,TM];

        Cal gus = new();
        int[,] resultados = gus.PonerUnos(TM, matriz);

        Console.WriteLine("Resultados de la matriz");
        for (int i = 0; i < TM; i++)
        {
            for (int j = 0; j < TM; j++)
            {
                Console.Write("{0} ", resultados[i,j]);
            }
            Console.WriteLine();
        }
    }
}
public class Cal {
    public int[,] PonerUnos (int TM, int[,] matriz) {
        for (int i = 0; i < TM; i++)
        {
            for (int j = 0; j < TM; j++)
            {
                if (i == j) {
                    matriz[i,j] = 1;
                } else {
                    matriz[i,j] = 0;
                }
            }
        }
        return matriz;
    }
}