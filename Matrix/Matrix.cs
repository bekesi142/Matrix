using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Matrix
    {
        private int[,] matrixTomb;
        private int sorok;
        private int oszlopok;
        private string nev;

        public string Nev { get => nev; set => nev = value; }

        public Matrix(int sorok, int oszlopok, string nev)
        {
            matrixTomb = new int[sorok, oszlopok];
            this.sorok = sorok;
            this.oszlopok = oszlopok;
            this.nev = nev;
        }

        public static Matrix Osszeadas(Matrix a, Matrix b)
        {
            if (a.sorok != b.sorok || a.oszlopok != b.oszlopok)
            {
                throw new ArgumentException("A mátrixok méretének meg kell egyeznie");
            }

            Matrix eredmeny = new Matrix(a.sorok, a.oszlopok, "matrixC");
            for (int i = 0; i < a.sorok; i++)
            {
                for (int j = 0; j < a.oszlopok; j++)
                {
                    eredmeny.matrixTomb[i, j] = a.matrixTomb[i, j] + b.matrixTomb[i, j];
                }


            }

            return eredmeny;
        }

        public static void SzamHozzadasa(Matrix valasztottMatrix, int szam)
        {
            for (int i = 0; i < valasztottMatrix.sorok; i++)
            {
                for (int j = 0; j < valasztottMatrix.oszlopok; j++)
                {
                    valasztottMatrix.matrixTomb[i, j] += szam;
                }
            }

        }

        public void FeltoltesRandomszamokkal(int minimum, int maximum)
        {
            Random random = new Random();
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    matrixTomb[i, j] = random.Next(minimum, maximum + 1);
                }
            }
        }

        public void Kiiratas()
        {
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    Console.Write(matrixTomb[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
