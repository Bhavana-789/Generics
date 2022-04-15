using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class MaxMethod<T>
    {
        public int[] arr= new int[5];
        public T[] value;

        public MaxMethod(T[]value)
        {
            this.value = value;
        }
        
        public T[] Sort(T[]value)
        {
            Array.Sort(this.value, value);
            return value;
        }

        public T FindMax()
        {
            T[] res = Sort(value);
            return res[res.Length - 1];
        }

        public void PrintResult()
        {
            T res = FindMax();
            Console.WriteLine("Max value is:"+res);
        }
        

        
    }
}
