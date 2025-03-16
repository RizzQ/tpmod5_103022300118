using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class HaloGeneric
    {
        public void SapaUser<T>(T user)

        {
            Console.WriteLine($"Halo User {user}");
        }

    }

    class Program
    {
        public static void Main()
        {
            HaloGeneric halo = new HaloGeneric();

            Console.Write("Masukkan nama Anda: ");
            string nama = Console.ReadLine();
            
            halo.SapaUser("Rizqie");
        }
    }
