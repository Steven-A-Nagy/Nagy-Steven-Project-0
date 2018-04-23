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
            for (int i = 0; i<palindrome.Count();i++)
            {
                I1.Push(palindrome[i]);
                I2.Push(palindrome[palindrome.Count() - i-1]);
            }
        }

        public string TextCheck { get; set; }
        public Stack<char> I1;
        public Stack<char> I2;
        

        public bool CheckText(string TC)
        {
            bool check = true;
            for (int i = 0; i < TC.Count(); i++)
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
