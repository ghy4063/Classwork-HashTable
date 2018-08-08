using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main()
        {
            //creates a dictionary that can store 2 string variables
            Dictionary<string, string> books = new Dictionary<string, string>();
            
            //creates items for our hashtable
            books.Add("Call of Cthulu", "H.P Lovecraft");
            books.Add("Cat in the Hat", "Dr. Seuss");
            books.Add("Percy Jackson", "Rick Riordan");
            books.Add("The art of Innovation", "Tom Kelly");
            //creates a List that stores all of the keys 
            List<string> bookcollection = new List<string>(books.Keys);
            //runs through a for each loop for each item in the dictionary  and prints them
            foreach(string title in bookcollection)
            {
                Console.WriteLine("{0},{1}", title, books[title]);
                
            }
            // removes Cat in the Hat from the dictionary
            Console.WriteLine("checking out Cat in The Hat");
            books.Remove("Cat in the Hat");



            Console.WriteLine("Checking to see if Dr. Seuss has been checked out");
            // confirms that cat in the Hat has been removed 
            if (!books.ContainsKey("Cat in the Hat"))
            {
                Console.WriteLine("Cat in the Hat has been checked out");

            }


            //confirms Percy Jackson is still here and has not been removed
            Console.WriteLine("Checking to see if percy Jackson is still available");
            if (books.ContainsKey("Percy Jackson"))
            {
                Console.WriteLine("Percy Jackson is still available");

            }

 


            
            Console.ReadLine();
        }
    }
}
