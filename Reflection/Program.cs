using System;
using System.Reflection;

namespace Reflection
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Type T = Type.GetType("Reflection.Customer");

            Type T = typeof(Customer);

            Console.WriteLine("FullName = {0}", T.FullName);
            Console.WriteLine("Just the Name = {0}", T.Name);
            Console.WriteLine("Just the NameSpace = {0}", T.Namespace);

            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Properties in Customers Class");
            Console.WriteLine("----------------------------------");
            PropertyInfo[] properties = T.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine("");
                Console.WriteLine("Name = {0} \n Type = {1}", property.Name, property.PropertyType.Name);
            }
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Methods in Customers Class");
            Console.WriteLine("----------------------------------");
            MemberInfo[] methods = T.GetMethods();
            foreach (MemberInfo method in methods)
            {
                Console.WriteLine("");
                Console.WriteLine("Name = {0} \n Return Type = {1}", method.Name, method.ToString());
            }

        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }
        public void PrintId()
        {
            Console.WriteLine("Id = {0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Id);
        }

    }
}
