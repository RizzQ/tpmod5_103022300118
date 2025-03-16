using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenericApp
{
    class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)

        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {data}");
        }

    }

    class Program
    {
        public static void Main()
        {
            DataGeneric<string> dataNIM = new DataGeneric<string>("103022300118");

            dataNIM.PrintData();
            Console.ReadLine();
        }
    }
}