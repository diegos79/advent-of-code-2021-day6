using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aocd6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 3, 5, 1, 5, 3, 2, 1, 3, 4, 2, 5, 1, 3, 3, 2, 5, 
                1, 3, 1, 5, 5, 1, 1, 1, 2, 4, 1, 4, 5, 2, 1, 2, 4, 3, 1, 2, 3, 4, 3, 4, 4, 5, 1, 
                1, 1, 1, 5, 5, 3, 4, 4, 4, 5, 3, 4, 1, 4, 3, 3, 2, 1, 1, 3, 3, 3, 2, 1, 3, 5, 2, 
                3, 4, 2, 5, 4, 5, 4, 4, 2, 2, 3, 3, 3, 3, 5, 4, 2, 3, 1, 2, 1, 1, 2, 2, 5, 1, 1, 
                4, 1, 5, 3, 2, 1, 4, 1, 5, 1, 4, 5, 2, 1, 1, 1, 4, 5, 4, 2, 4, 5, 4, 2, 4, 4, 1, 
                1, 2, 2, 1, 1, 2, 3, 3, 2, 5, 2, 1, 1, 2, 1, 1, 1, 3, 2, 3, 1, 5, 4, 5, 3, 3, 2, 
                1, 1, 1, 3, 5, 1, 1, 4, 4, 5, 4, 3, 3, 3, 3, 2, 4, 5, 2, 1, 1, 1, 4, 2, 4, 2, 2, 
                5, 5, 5, 4, 1, 1, 5, 1, 5, 2, 1, 3, 3, 2, 5, 2, 1, 2, 4, 3, 3, 1, 5, 4, 1, 1, 1, 
                4, 2, 5, 5, 4, 4, 3, 4, 3, 1, 5, 5, 2, 5, 4, 2, 3, 4, 1, 1, 4, 4, 3, 4, 1, 3, 4, 
                1, 1, 4, 3, 2, 2, 5, 3, 1, 4, 4, 4, 1, 3, 4, 3, 1, 5, 3, 3, 5, 5, 4, 4, 1, 2, 4, 
                2, 2, 3, 1, 1, 4, 5, 3, 1, 1, 1, 1, 3, 5, 4, 1, 1, 2, 1, 1, 2, 1, 2, 3, 1, 1, 3, 
                2, 2, 5, 5, 1, 5, 5, 1, 4, 4, 3, 5, 4, 4 };
            int day = 0; //counter of the days
            while (day <= 80) //loop through days
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"\nAfter {day} days, there are: {list.Count} elements");
                if (day == 0)   
                    Console.WriteLine("This is initial state:");
                else 
                    Console.WriteLine($"\nThis is Day: {day}");
                //PrintList(list);
                var zerosInList = FindZerosIndexes(list); //find indexes of zeros in the list 
                
                if (zerosInList.Count > 0)
                {
                    DecreaseItemOfList(list, 1);
                    for (int i = 0; i < zerosInList.Count; i++) //reset zeros to 6 AND increase with 8
                    {
                        ResetElementofAList(list, zerosInList[i], 6);
                        IncreaseListWithItem(list, 8);
                    }
                }
                else //if there aren't zeros in the list, decrease only
                {
                    DecreaseItemOfList(list, 1);
                }
            
                day++;
            }
            Console.ReadKey();
        } //end Main()

        /******************************************************************/
        //finding zeros in list
        public static List<int> FindZerosIndexes (List<int> list)
        {
            var indexesOfZeros = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 0)
                {
                    indexesOfZeros.Add(i);
                }
            }
            return indexesOfZeros;
        }

        


        /******************************************************************/

        // Print items in the list
        public static void PrintList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++) 
            {
                Console.Write(list[i] + (i == list.Count-1 ? "": ","));
            }
            Console.WriteLine();
        }

        /******************************************************************/


        // Decrease of items of a list (by x value)

        public static List<int> DecreaseItemOfList (List<int> list, int qtyToDecrease)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i]-1;
            }
            return list;
        }


        /******************************************************************/


        // Reset an element of a list to x value (6)

        public static List<int> ResetElementofAList (List<int> list, int indexOfElement, int value)
        {
            list[indexOfElement] = value;
            return list;
        }


        /******************************************************************/


        //increase list quantity of one item at the end of the list (8)

        public static List<int> IncreaseListWithItem (List<int> list, int item)
        {
            list.Add(item);
            return list;
        }


        /******************************************************************/
    } //end main



} //end namespace
