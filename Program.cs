using System;
using System.Collections;

namespace HastTableExample {
    class Program {
        static void Main(string[] args) {
            // ArrayListDemo();

            HashtableDemo();
        }

        private static void HashtableDemo() {
            //Creating Hashtable collection with default constructor
            Hashtable ht = new Hashtable();
            //Adding elements to the Hash table using key value pair
            ht.Add("EId", 1001); //Here key is Eid and value is 1001
            ht.Add("Name", "James"); //Here key is Name and value is James
            ht.Add("Job", "Developer");
            ht.Add("Salary", 3500);
            ht.Add("Location", "Mumbai");
            ht.Add("Dept", "IT");
            ht.Add("EmailID", "a@a.com");

            //Checking the key using the ContainsKey methid
            Console.WriteLine("Is EmailID Key Exists : " + ht.ContainsKey("EmailID"));
            Console.WriteLine("Is Department Key Exists : " + ht.ContainsKey("Department"));

            //Checking the value using the ContainsValue method
            Console.WriteLine("Is Mumbai value Exists : " + ht.ContainsValue("Mumbai"));
            Console.WriteLine("Is Technology value Exists : " + ht.ContainsValue("Technology"));

            Console.WriteLine("Is job key exist : " + ht.ContainsKey("Job"));
 
            Console.ReadKey();
        }

        private static void ArrayListDemo() {
            ArrayList al = new ArrayList();
            al.Add(1001); //EId
            al.Add("James"); //Name
            al.Add("Manager"); //Job
            al.Add(3500); //Salary
            al.Add("Mumbai"); //Location
            al.Add("IT"); //Dept
            al.Add("a@a.com"); // Emailid
            //I want to print the Location, index position is 4
            Console.WriteLine("Location : " + al[4]);
            //I want to print the Email ID, index position is 6
            Console.WriteLine("Emaild ID : " + al[6]);
            Console.ReadKey();
        }
    }
}
