using System;

namespace Matrix 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrixA = new Matrix(2, 3, "matrixA");
            Matrix matrixB = new Matrix(2, 3, "matrixB");

            matrixA.FeltoltesRandomszamokkal(1, 10);
            matrixB.FeltoltesRandomszamokkal(1, 10);

            Console.WriteLine("matrixA:");
            matrixA.Kiiratas();
            Console.WriteLine("\nmatrixB:");
            matrixB.Kiiratas();

            Console.WriteLine("\nKét matrix összege (matrixC):   ");
            Matrix matrixC = Matrix.Osszeadas(matrixA, matrixB);
            matrixC.Kiiratas();

            List<Matrix> matrixList = new List<Matrix>() { matrixA, matrixB, matrixC };
            
            Console.Write("\nAdja meg melyik Matrix értékeit akarja növelni:  ");
            string valasztottMatrix = Console.ReadLine();
            Console.Write("Adja meg mennyivel szeretné növelni a választott Matrix értékeit:  ");
            int valasztottNoveles = Convert.ToInt32(Console.ReadLine());


            
            for (int i = 0; i < matrixList.Count; i++)
            {
                if (matrixList[i].Nev == valasztottMatrix)
                {
                    Matrix.SzamHozzadasa(matrixList[i],valasztottNoveles);
                    matrixList[i].Kiiratas();
                }
            }


        }
    }
}