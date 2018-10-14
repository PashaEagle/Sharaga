using System;
using System.Data;

namespace lab02_Irusha
{
    
    abstract class Tovar
    {
        
        public abstract bool check(string s);
        public abstract void info();
        public abstract string getType();
    };

    class Toy : Tovar
    {
        private string type = "toy";
        private string name;
        private double price;
        private string producer;
        private string material;
        private int age;

        public override string getType()
        {
            return type;
        }

        public Toy(string n, double v, string p, string m, int a)
        {
            name = n;
            price = v;
            producer = p;
            material = m;
            age = a;
        }

        public override bool check(string s)
        {
            if (s == type) return true;
            else return false;
        }

        public override void info()
        {
            Console.WriteLine("Type: " + type);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Producer: " + producer);
            Console.WriteLine("Material: " + material);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("**********************");
            Console.WriteLine();
        }
    };

    class Book : Tovar
    {
        private string type = "book";
        private string name;
        private double price;
        private string producer;
        private string author;
        private int age;


        public override string getType()
        {
            return type;
        }

        public Book(string n, double v, string p, string m, int a)
        {
            name = n;
            price = v;
            producer = p;
            author = m;
            age = a;
        }

        public override bool check(string s)
        {
            if (s == type) return true;
            else return false;
        }

        public override void info()
        {
            Console.WriteLine("Type: " + type);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Producer: " + producer);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("**********************");
            Console.WriteLine();
        }
    };
    
    class Inv :  Tovar
    {
        
        private string type = "inv";
        private string name;
        private double price;
        private string producer;
        private int age;
    
        public override string getType() { return type; }
        public Inv(string n, double v, string p, int a)
        {
            name = n;
            price = v;
            producer = p;
            age = a;
        }
    
        public override bool check(string s) 
        {
            if (s == type) return true;
            else return false;
        }
    
        public override void info() 
        {
            Console.WriteLine("Type: " + type);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Producer: " + producer);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("**********************");
            Console.WriteLine();
        }
    };
    
    internal class Program
    {
        public static int size = 6;
        
        public static void Main(string[] args)
        {
            Tovar[] n = new Tovar[size];
            n[0] = new Toy("Car", 10.10, "LEGO", "iron", 3);
            n[1] = new Book("Book1", 11, "Shelf", "Eastwood", 10);
            n[2] = new Inv("Sport", 100, "Sport", 13);
            n[3] = new Toy("House", 5.80, "LCC", "wood", 3);
            n[4] = new Book("Book2", 112, "Shelf", "Eastwood", 10);
            n[5] = new Inv("Camp", 200, "Sport", 17);
        
            //InFO
            Console.WriteLine("There are these tovars:");
            for (int i = 0; i < size; ++i)
            {
                n[i].info();
            }
        
        
            //Checking
            Console.WriteLine(n[0].check("toy"));
        
        
            //Search
            Console.Write("Enter type you want to find: (toy, book, inv): ");
            string s;
            s = Console.ReadLine();
        
            bool succ = false;
            for (int i = 0; i < size; ++i)
            {
                if (s == n[i].getType())
                {
                    if (!succ)
                    {
                        succ = true;
                        Console.WriteLine( "I find these tovars:");
                    }
                    n[i].info();
        
                };
            }
            if (!succ) Console.Write("Nothing..");
        
        
          
        
        }
    }
}