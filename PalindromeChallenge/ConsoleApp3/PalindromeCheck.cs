using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class PalindromeCheck
    {
        public PalindromeCheck(string palindrome)
        {
            TextCheck = new string(palindrome.Where(c => !char.IsPunctuation(c)).ToArray());
            I1 = new Stack<char>();
            I2 = new Stack<char>();
            for (int i = 0; i<TextCheck.Count();i++)
            {
                I1.Push(TextCheck[i]);
                Console.Write(TextCheck[i]+" ");
                I2.Push(TextCheck[TextCheck.Count() - i - 1]);
                Console.Write(TextCheck[TextCheck.Count() - i-1]+"\n");
            }
        }

        public string TextCheck { get; set; }
        public Stack<char> I1;
        public Stack<char> I2;
        

        public bool CheckText()
        {
            bool check = true;
            for (int i = 0; i < TextCheck.Count(); i++)
            {
                string d1 = I1.Pop().ToString();
                string d2 = I2.Pop().ToString();
                if (!(d1.Equals(d2, StringComparison.InvariantCultureIgnoreCase)))
                {
                    check = false;
                }
            }
            return check;
        }
    }
}
