using System;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace osu_data
{
    class Methods
    {
        public static string addSpace(string myString)
        {
            myString = Reverse(myString);
            for (int i = 3; i <= myString.Length; i += 3)
            {
                myString = myString.Insert(i, " ");
                i++;
            }
            myString = Reverse(myString);
            return myString;
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        
        public static string removeFirstLastChar(string s)
        {
            s =  s.Remove(0,  1);
            s =  s.Remove(s.Length - 1,  1);
            return s;
        }
    }
}
