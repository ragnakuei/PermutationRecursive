using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PermutationRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = new List<string> { "1", "2", "3", "4" };
            Permutation permutation = new Permutation(source);
            var results = permutation.Result;
            foreach (var result in results)
            {
                foreach (var item in result)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
