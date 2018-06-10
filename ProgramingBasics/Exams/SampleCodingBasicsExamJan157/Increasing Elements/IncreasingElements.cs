using System;

namespace TaskFive
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Finding the longest sequence of equal elements in array.");

            //some vars to ensure int is entered
            int elemCount = 0;
            string str = null;
            bool testParse = false;

            while (testParse == false)// checks if elemCount is integer
            {
               // Console.WriteLine("Enter the number of the array's elements (integer value):");
                str = Console.ReadLine();
                testParse = int.TryParse(str, out elemCount);
            }
            testParse = false;

            int[] myArray;
            myArray = new int[elemCount];

            for (int i = 0; i < elemCount; i++)
            {
                while (testParse == false)// geting integer values for each element of the array
                {
                    //Console.WriteLine("Enter the array's element {0}:", i);
                    str = Console.ReadLine();
                    testParse = int.TryParse(str, out myArray[i]);
                }
                testParse = false;
            }
            int iterStarter = 0; //used as starting value for the nested 'for' loop
            int iterModifier = 0; //used to modify the starting value without making mess of the current loop
            int longSeq = 0;
            int currLength = 0;
            for (int iStr = 0; iStr < elemCount; iStr++)
            {
                for (int i = iterStarter; i < elemCount; i++)
                {
                    if (i != (elemCount - 1))
                    {
                        if (myArray[i] < myArray[i + 1])
                        {
                            currLength = currLength + 1 /*+ ", "*/;
                            iterModifier++;
                        }
                        else
                        {
                            currLength = currLength + 1;
                            iterModifier++;
                            i = elemCount + 1;
                        }
                    }
                    else
                    {
                        currLength = currLength + 1;
                        iterModifier = elemCount;
                    }
                }
                iterStarter = iterModifier;
                
                if (longSeq <= currLength)
                {
                      longSeq = currLength;
                      currLength = 0;
                }
                
            }
            
            Console.Write(longSeq);
            Console.ReadKey();
        }
    }
}
