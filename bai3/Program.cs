using System;
using System.Text;

namespace bai3
{
    class Program
    {
        static bool kiemTra(int A)
        {
            int sum = 0;
            for (int i = 1; i <= (A / 2); i++)
            {
                if (A % i == 0)
                {
                    sum += i;
                    if (sum == A)
                    {
                        return true;
                    }
                }

            }
            return false;

        }
        static void Main(string[] args)
        {
            //chữ có daasu
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap so ");
            int A = int.Parse(Console.ReadLine());
            if (kiemTra(A))
            {
                Console.WriteLine("Là số hoàn hảo");
            }
            else
            {
                Console.WriteLine("không phải số hoàn hảo");
            }
            Console.ReadLine();
        }
    }
}
