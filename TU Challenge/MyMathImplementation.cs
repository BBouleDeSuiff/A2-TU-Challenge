using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static bool IsDivisible(int a, int b)
        {
            return (a % b == 0);
        }        
        public static bool IsEven(int a)
        {
            return (a % 2 == 0);
        }
        public static bool IsMajeur(int age)
        {
            if (age < 0)
                throw new ArgumentException();
            if (age > 145)
                throw new ArgumentException();
            return age >= 18;
        }        
        public static bool IsPrimary(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if ((a % i) == 0){
                    return false;
                }
            }
            return true;
        }        
        public static List<int> GetAllPrimary(int a)
        {
            List<int> listPrimary = new();
            for (int i = 2; i <= a; i++)
            {
                if(IsPrimary(i))
                    listPrimary.Add(i);
            }
            return listPrimary;
        }
        public static List<int> GenericSort(List<int> toSort, Func<int,int,int> isInOrder)
        {
            List<int> list = toSort;
            while (!IsListInOrder(list))
            {
                for (int i = 0; i <= list.Count - 2; i++)
                {
                    if (isInOrder(list[i], list[i + 1]) == -1)
                    {
                        list.Reverse(i, 2);
                    }
                }
            }
            return list;
        }

        public static int IsInOrder(int a, int b)
        {
            if (a > b)
                return -1;
            else if (a < b)
                return 1;
            return 0;
        }
        public static int IsInOrderDesc(int arg1, int arg2)
        {
            return -IsInOrder(arg1, arg2);
        }

        public static bool IsListInOrder(List<int> list)
        {
            for (int i = 0; i <= list.Count-2; i++)
            {
                if (IsInOrder(list[i], list[i + 1]) == -1)
                    return false;
            }
            return true;
        }
        public static bool IsListInOrderDesc(List<int> list)
        {
            for (int i = 0; i <= list.Count - 2; i++)
            {
                if (IsInOrder(list[i], list[i + 1]) == 1)
                    return false;
            }
            return true;
        }

        public static int Power(int a, int b)
        {
            int c = a;
            for (int i = 0; i < b-1; i++)
            {
                c *= a;
            }
            return c;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static List<int> Sort(List<int> toSort)
        {
            List<int> list = toSort;
            while (!IsListInOrder(list))
            {
                for (int i = 0; i <= list.Count - 2; i++)
                {
                    if (IsInOrder(list[i], list[i + 1]) == -1)
                    {
                        list.Reverse(i, 2);
                    }
                }
            }
            return list;
        }

        public static List<int> GenericSortDesc(List<int> toSort, Func<int, int, int> isInOrderDesc)
        {
            List<int> list = toSort;
            while (!IsListInOrderDesc(list))
            {
                for (int i = 0; i <= list.Count - 2; i++)
                {
                    if (isInOrderDesc(list[i], list[i + 1]) == -1)
                    {
                        list.Reverse(i, 2);
                    }
                }
            }
            return list;
        }
    }
}
