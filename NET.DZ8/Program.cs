using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book a1= new Book("dsfgb","fdgh","ergh","dfgh",523);
            Book a2 = new Book("lkjhh", "fdgh", "ergh", "dfgh", 423);
            Book a3 = new Book("rtgdhfnm", "fdgh", "ergh", "dfgh", 123);
            Book a4 = new Book("cvg", "fdgh", "ergh", "dfgh", 223);
            Book[] central = new Book[4];
            central[0]=a1 ; central[1]=a2 ; central[2]=a3 ; central[3]=a4 ;
            library central1=new library(central);

            foreach (Book b in central1)
            {
               b.Print();
            }


            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                central[i].Print();
            }
            Console.WriteLine();
            Array.Sort(central, new Book.SortByname());
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                central[i].Print();
            }
            Console.WriteLine();
            Array.Sort(central, new Book.SortByyear());
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                central[i].Print();
            }
            Console.WriteLine();

            Book e = new Book();
            Book a = e;
            a.genre = "cvgbh";
            a.writer = "vcb hnjbg";
            a.year = 2345;
            a.publisher = "dfgfhyh";
            a.name = "dfgnuhb;";
            Console.WriteLine(e.ToString());
            Func(e);
            Console.WriteLine(e.ToString());

        }
        static void Func(ICloneable cloneable)
        {
            object b = cloneable.Clone();
            Console.WriteLine(b.ToString());
            Book e = b as Book;
            e.name = "ewrtgh";
            e.year = 2134;
            e.writer = "werfgbfh";
            e.publisher = "dsfdgfhn";
            e.genre = "cvbhgj";
            Console.WriteLine(b.ToString());


        }
    }
}
