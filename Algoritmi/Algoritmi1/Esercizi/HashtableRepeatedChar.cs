using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algoritmi.Algoritmi1.Esercizi
{
    class HashtableRepeatedChar
    {
        public char GetFirstNotRepeatedChar(string content)
        {

           
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            foreach (char c in content)
            {
                int count = ht.ContainsKey(c) ? Convert.ToInt32(ht[c]) : 0; 
                    ht[c]= count+1; 
            }

            foreach (char c in content)
            {
                if (Convert.ToInt32(ht[c]) == 1)
                    return c;
            }
         
            return char.MinValue;
    }
        public char GetFirstRepeatedChar(string content)
        {
            HashSet<char> hs = new HashSet<char>();

            foreach (Char ch in content)
            {
                if (hs.Contains(ch))
                    return ch;

                    hs.Add(ch);
            }

            return Char.MinValue;
        }
    }
}
