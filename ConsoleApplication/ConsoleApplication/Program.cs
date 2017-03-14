using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s;
            long result;

            Console.WriteLine("Type the word");

            Program hash = new Program();

            s = Console.ReadLine();

            result = Hashing(s);

            Console.WriteLine(Hashing(s));
            Console.Read();
        }

        public static Int64 Hashing(string s){

            Int64 h;
            string letters;
            int i;
            int index;
            long inc;

            h = 7;
            letters = "acdegilmnopratuw";

            for (i=0; i<s.Length; i++){
                inc = (h * 37);
                index = letters.IndexOf(s[i]);
                h = inc + index;
            }
            return h;
        }
    }
}
