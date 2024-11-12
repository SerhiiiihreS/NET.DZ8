using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NET.DZ8
{
     class library: IEnumerable, IEnumerator
    {

        Book [] Array;
        int curpos = -1;


        public library(int size)
        {
            Array = new Book[size];
            for(int i = 0; i < size; i++)
            {
                Array[i] = new Book();
            }
        }

        public library(Book[] array) 
        { 
            Array = array;
        }
        public void Output()
        {
            for (int i = 0; i < Array.Length; i++) { Array[i].Print();Console.WriteLine(); }
        }
        public void Reset()
        {
            curpos = -1;    
        }
        public object Current 
        {  
            get { return Array[curpos]; }
        }
        public bool MoveNext()
        {
            if (curpos < Array.Length - 1)
            {
                curpos++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }

        }
        public IEnumerator GetEnumerator() {
            for (int i = 0; i < Array.Length; i++)
            {
                yield return Array[i];
            }

        }
    }
}
