using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms_InCSharp.Interfaces.Algorithms
{
    internal interface ImethodAlgorithms
    {
        void Sort(int[] array);
        void Sort(double[] array);
        void Sort(int[] array, ListBox listBX);
        void Sort(double[] array, ListBox listBX);
    }
}
