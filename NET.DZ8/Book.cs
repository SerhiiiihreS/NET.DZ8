using System;
using System.Collections;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ8
{
    internal class Book:IComparable,ICloneable 
    {
        public string name { get; set; }
        public string writer { get; set; }
        public string genre { get; set; }
        public string publisher { get; set; }
        public int year { get; set; }
        public Book() {
        }

        public Book(string nm, string wrtr,string gnr,string pbler,int yr)
        {
            name = nm;
            writer = wrtr;
            genre = gnr;
            publisher = pbler;
            year = yr;
        } 
        public void Print()
        {
            Console.Write(name);
            Console.Write("|");
            Console.Write(writer);
            Console.Write("|");
            Console.Write(genre);
            Console.Write("|");
            Console.Write(publisher);
            Console.Write("|");
            Console.Write(year);
            Console.Write("|");
        }
        public int CompareTo(object obj)
        {
            if (obj is Book)
            {
                return name.CompareTo((obj as Book).name);
            }
            throw new NotImplementedException();
        }
        public class SortBywriter : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Book && obj2 is Book)
                {
                    return (obj1 as Book).writer.CompareTo((obj2 as Book).writer);
                }
                throw new NotImplementedException();
            }
        }
        public class SortBygenre : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Book && obj2 is Book)
                {
                    return (obj1 as Book).genre.CompareTo((obj2 as Book).genre);
                }
                throw new NotImplementedException();
            }
        }

        public class SortBypublisher : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Book && obj2 is Book)
                {
                    return (obj1 as Book).publisher.CompareTo((obj2 as Book).publisher);
                }
                throw new NotImplementedException();
            }
        }

        public class SortByyear : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Book && obj2 is Book)
                {
                    return (obj1 as Book).year.CompareTo((obj2 as Book).year);
                }
                throw new NotImplementedException();
            }
        }
        public class SortByname : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Book && obj2 is Book)
                {
                    return (obj1 as Book).name.CompareTo((obj2 as Book).name);
                }
                throw new NotImplementedException();
            }
        }

        public object Clone()
        {
            return new Book( name,writer,genre,publisher,year);
        }
    }
}
