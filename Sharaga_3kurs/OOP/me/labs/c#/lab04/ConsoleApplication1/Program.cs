using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        interface IDerzhava
        {
            uint Population { get; set; }
            
            string Name { get; set; }
            
            void Info();
        }

        class Republic : IDerzhava
        {
            public string Name { get; set; }

            public uint Population { get; set; }
            
            public void Info()
            {
                Console.WriteLine("Republic " + Name + ", population = " + Population);
            }

            public Republic(string name, uint population)
            {
                Name = name;
                Population = population;
            }
            
            public Republic(){}
        }
        
        class Monarchy : IDerzhava
        {
            public string Name { get; set; }

            public uint Population { get; set; }
            
            public void Info()
            {
                Console.WriteLine("Monarchy " + Name + ", population = " + Population);
            }

            public Monarchy(string name, uint population)
            {
                Name = name;
                Population = population;
            }
            
            public Monarchy(){}
        }
        
        class Kingdom : IDerzhava
        {
            public string Name { get; set; }

            public uint Population { get; set; }
            
            public void Info()
            {
                Console.WriteLine("Kingdom " + Name + ", population = " + Population);
            }

            public Kingdom(string name, uint population)
            {
                Name = name;
                Population = population;
            }
            
            public Kingdom(){}
        }
        
        
        
        public static void Main(string[] args)
        {
            Republic ukraine = new Republic();
            Monarchy spain = new Monarchy("Spain", 70000000);
            Kingdom uk = new Kingdom("United Kingdom", 140000000);
            ukraine.Name = "Ukraine";
            ukraine.Population = 41000000;
            
            ukraine.Info();
            spain.Info();
            uk.Info();

            Console.WriteLine();
            
            IDerzhava[] masiv = new IDerzhava[3];

            masiv[0] = ukraine;
            masiv[1] = spain;
            masiv[2] = uk;

            foreach (IDerzhava derzh in masiv)
            {
                derzh.Info();
            }
            Console.WriteLine("Hello, rider !");
        }
    }
}