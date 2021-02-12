using System;
using System.Collections.Generic;

namespace ExternalPractical
{
    class Range 
    {
        //checks whether the entered number is in the range provided or not 
        static int ReadNumber(int start, int end)
        {
            int no;
            Console.WriteLine("Enter the input: ");
            try
            {
                no = Convert.ToInt32(Console.ReadLine());
                if (no > end || no < start)  
                {
                    throw new ArgumentOutOfRangeException();
                }
                else return no;
            }
            catch(FormatException e) //INVALID INPUT
            {
                Console.WriteLine("Input is not a number : FORMAT EXCEPTION \n" + e);
            }
            catch(ArgumentOutOfRangeException e) //INPUT ENTERED IS OUT OF RANGE
            {
                Console.WriteLine("Input out of Range : ARGUMENT OUT OF RANGE EXCEPTION \n" + e);
            }
            catch(Exception e) //ANY OTHER EXCEPTION
            {
                Console.WriteLine(e);
            }
            return 0;
        }
        
        //method to get 10 integers in the list and sort the list
        static List<int> GetTenIntegers(int start, int end) 
        {
            List<int> arr = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                int no = ReadNumber(start, end);
                if(no!=0)
                    arr.Add(no);
            }
            arr.Sort();
            return arr;
        }
        
        //display the integers that are saved/present in the list 
        static void display(List<int> arr) 
        {
            Console.WriteLine("Displaying the Numbers");
            foreach(int no in arr)
            {
                Console.WriteLine(no);
            }
        }
        
        
        static void Main(string[] args)
        {
            List<int> arr= GetTenIntegers(1, 100);
            display(arr);
        }
    }
}
