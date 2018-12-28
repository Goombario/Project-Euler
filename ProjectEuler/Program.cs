using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public abstract class Question
    {
        public abstract bool Run();
    }

    class Program
    {
        static void Main(string[] args)
        {
            var question1 = new Question1();
            question1.Run();


            Console.ReadKey();
        }
    }
}
