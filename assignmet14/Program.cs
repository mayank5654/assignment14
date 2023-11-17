using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmet14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create an instance of LargeDataCollection
            int[] initialData = { 1, 2, 3, 4, 5 };
            using (LargeDataCollection dataCollection = new LargeDataCollection(initialData))
            {
                // Demonstrate adding, removing, and accessing elements
                dataCollection.AddElement(9);
                dataCollection.RemoveElement(1);
                int elementAtIndex = dataCollection.GetElement(4);

                // Display the modified collection
                Console.WriteLine("Modified Collection:");
                for (int i = 0; i < dataCollection.Length; i++)
                {
                    Console.Write(dataCollection.GetElement(i) + " ");
                }
            } // Dispose will be called automatically when exiting the 'using' block

        }
    }
    



}

