using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class MyExtensions
    {
        public static bool ContainCharacter(this Control form1) 
        {
            bool marker= false;
               string a= form1.Text;
            for (int i = 0; i < a.Length; i++) 
            {
                if (Char.IsLetter(a[i]))
                {
                    if (a[i] == ',' || a[i] == '.')
                        continue;
                    marker = true; 
                }
                
                    
            }
            if (marker)
            {
                return true;
            }
            return false;
        }
        public static bool ContainWhiteSpace(this Control form1)
        {
            bool marker = false;
            string a = form1.Text;
            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsWhiteSpace(a[i]))
                {
                    if (a[i] == ',' || a[i] == '.')
                        continue;
                    marker = true;
                }


            }
            if (marker)
            {
                return true;
            }
            return false;
        }
    }
}
