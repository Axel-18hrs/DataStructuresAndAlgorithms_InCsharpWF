using DataStructuresAndAlgorithms_InCSharp.Classes.Algorithms;
using DataStructuresAndAlgorithms_InCSharp.Interfaces.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Operations.Algorithms
{
    internal class OperationsAlgorithm
    {
        private static Random _rand = new Random();
        public static double[] GenerarVectorDouble(int Minon = 0, int Lenght = 10, int values = 5)
        {
            List<double> _List = new List<double>();

            for (int i = Minon; i < Lenght; i++)
            {
                if (i < values)
                {
                    double NewValor = _rand.NextDouble();
                    _List.Add(NewValor);
                }
                else
                {
                    break;
                }
            }
            return _List.ToArray();
        }

        public static int[] GenerarVector(int Minon = 0, int Lenght = 10, int values = 5)
        {
            List<int> _List = new List<int>();

            for (int i = Minon; i < Lenght; i++)
            {
                if (i < values)
                {
                    int NewValor = _rand.Next(Minon, Lenght + 1);
                    if (_List.Contains(NewValor))
                    {
                        i--;
                        continue;
                    }
                    _List.Add(NewValor);
                }
                else
                {
                    break;
                }
            }
            return _List.ToArray();
        }
    }
}
