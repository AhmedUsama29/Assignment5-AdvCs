using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment5_Adv_C_.Program;

namespace Assignment5_Adv_C_
{

    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> blist , BookDetails fPtr) {

            foreach (Book B in blist)
            {
                Console.WriteLine(fPtr.Invoke(B));
            }
        }
    } 
}