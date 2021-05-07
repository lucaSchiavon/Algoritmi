//using System;
using Algoritmi.Algoritmi1;
namespace Algoritmi
{
    class Program
    {
        static void Main(string[] args)
        {
            //array
            Array array = new Array(4);
            array.Insert(10);
            array.Insert(20);
            array.Insert(30);
            array.Insert(40);
            array.InsertAt2(5, 1);
        }
    }
}
