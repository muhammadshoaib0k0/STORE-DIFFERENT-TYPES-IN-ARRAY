using System;

namespace STORE_DIFFERNT_TYPES_IN_ARRAY
{
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return this.Name ;
            
        }
    }







    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            object[] obj_array = new object[3];
            obj_array[0] = 101;
            obj_array[1] = "C#";
            Customer c = new Customer();
            c.ID = 99;
            c.Name = "ALI";
            obj_array[2] = c;
            foreach(object obj in obj_array)
            {
                Console.WriteLine(obj);
            }





        }
    }
}
