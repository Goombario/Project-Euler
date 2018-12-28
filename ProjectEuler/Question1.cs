using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Question1 : Question
    {
        public override bool Run()
        {
            int sum = Attempt1();
            Console.WriteLine($"The total sum was {sum}");
            return true;
        }

        public int Attempt1()
        {
            // Process 1: Use sets to get all the unique multiples
            HashSet<int> uniqueMultiples = new HashSet<int>();

            FindAndAddMultiplesToSet(3, 1000, uniqueMultiples);
            FindAndAddMultiplesToSet(5, 1000, uniqueMultiples);

            Console.WriteLine($"There are {uniqueMultiples.Count} unique multiples in this set.");

            return uniqueMultiples.Sum();
        }

        private void FindAndAddMultiplesToSet(int naturalNumberToMultiply, int maxExclusive, HashSet<int> set)
        {
            // Error checking to make sure the number is natural
            if (naturalNumberToMultiply <= 0) return;

            for (var i = naturalNumberToMultiply; i < maxExclusive; i += naturalNumberToMultiply)
            {
                set.Add(i);
            }
        }
    }
}
