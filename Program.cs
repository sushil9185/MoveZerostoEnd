using System.ComponentModel.Design;

namespace MoveZerostoEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = new int[] { 1, 0, 2, 3, 2, 0, 0, 4, 5, 1 };
            Console.WriteLine("Orignal Array");
            PrintArray(myarray);

            Console.WriteLine("Move all the zeros to the end of array");
            //MoveZerosBrute(myarray);
            MoveZeroOptimal(myarray);
        }

        static void MoveZerosBrute(int[] a)
        {
            int n = a.Length;
            List<int> temp = new List<int>();
            for(int i = 0; i < n; i++)
            {
                if (a[i] != 0)
                {
                    temp.Add(a[i]);
                }       
            }
            
            for(int i =0; i < temp.Count; i++)
            {
                a[i] = temp[i];
            }

            for(int i = temp.Count();i < n; i++)
            {
                a[i] = 0;
            }

            PrintArray(a);
        }

        static int[] MoveZeroOptimal(int[] a)
        {
            int j = int.MinValue;
            int n = a.Length;
            for(int i =0; i<n; i++)
            {
                if (a[i] == 0)
                {   j = i; 
                    break; 
                }
            }

            if(j == int.MinValue) { return a; }
            for(int i = j+1; i < n; i++)
            {
                if (a[i] != 0)
                {
                    int temp = a[j];
                    a[j] = a[i];
                    a[i] = temp;
                    j++;
                }
            }
            PrintArray(a);
            return a;
            
        }

        static void PrintArray(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}