using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class GenericMax<T> where T : IComparable
    {
        public T first, second, third;

        public GenericMax(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        public static T FindMax(T first, T second, T third)
        {
            //to check if first number is maximum or not
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 || first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 || first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine("first number is maximum" + first);
                return first;
            }
            //to check if second number is maximum or not
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 || second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 || second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("second number is maximum" + second);
                return second;
            }
            //to check if third number is maximum or not
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0 || third.CompareTo(first) >= 0 && third.CompareTo(second) > 0 || third.CompareTo(first) > 0 && third.CompareTo(second) >= 0)
            {
                Console.WriteLine("third number is maximum" + third);
                return third;
            }
            else
            {
                Console.WriteLine("2 or 3 values might be equal");
                return default;
            }

        }
    }
}
