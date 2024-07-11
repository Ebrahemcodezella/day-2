using System;
namespace day2
{ 
     class program
    { 
        class student
        {
            int id = 12; 
            string name="Ebrahem hany";
            int age = 19;
            string phone ="012213243"; 

            public void print()
            {
                Console.WriteLine($"id : {id} - name : {name} - age : {age} - phone : {phone} ");
            }

        }
        static void Main(String[] args)
        {
            student s = new student();
            s.print();
            Console.WriteLine("Enter your information \n" +
                "ID \n" +
                "name\n" +
                "age\n");
            int ID =int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            while(age < 0)
            {
                Console.WriteLine("plz enter valued age \n ");
                 age = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($" your information is " +
                $"  ID : {ID}  " +
                $"  name : {name}  " +
                $"  age : {age} " );
         
        }
    }
}