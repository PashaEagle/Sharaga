using System;

namespace lab05
{
    internal class Program
    {
        abstract class Wheels
        {
            protected int amount;
            public abstract void Info();
        }

        class Yamaha : Wheels
        {
            private int amount;

            public Yamaha(int amount)
            {
                this.amount = amount;
            }
            
            public override void Info()
            {
                Console.WriteLine("Wheels Yamaha, amount " + amount);
            }
            
        }
        
        class BBC : Wheels
        {
            private int amount;

            public BBC(int amount)
            {
                this.amount = amount;
            }

            public override void Info()
            {
                Console.WriteLine("Wheels BBC, amount " + amount);
            }
        }

        class Engine
        {
            private int power;

            public Engine(int power)
            {
                this.power = power;
            }
            
            public void Info()
            {
                Console.WriteLine("Engine power = " + power);
            }
        }

        class Body
        {
            private string color;

            public Body(string color)
            {
                this.color = color;
            }
            
            public void Info()
            {
                Console.WriteLine("Body color = " + color);
            }
        }
        
        class Car_Agregation
        {
            private Wheels wheels;
            private Engine engine;
            private Body body;

            public Car_Agregation(Wheels wheels, Engine engine, Body body)
            {
                this.wheels = wheels;
                this.engine = engine;
                this.body = body;
            }
            
            public void Info()
            {
                Console.WriteLine("\tCar Agregation:\n");
                wheels.Info();
                engine.Info();
                body.Info();
                Console.WriteLine("\n");
            }
        }

        class Car_Composition
        {
            private Wheels wheels;
            private Engine engine;
            private Body body;

            public Car_Composition()
            {
                wheels = new BBC(4);
                //wheels = new Yamaha();
                
                engine = new Engine(400);
                body = new Body("Red");
            }

            public void Info()
            {
                Console.WriteLine("\tCar Composition:\n");
                wheels.Info();
                engine.Info();
                body.Info();
                Console.WriteLine("\n");
            }
        }
        
        
        public static void Main(string[] args)
        {
            Wheels w = new Yamaha(5);
            Wheels w2 = new BBC(7);
            Engine e = new Engine(500);
            Body b = new Body("Blue");
            
            Car_Agregation carAgregation = new Car_Agregation(w, e, b);
            carAgregation.Info();
            
            Car_Composition carComposition = new Car_Composition();
            carComposition.Info();
            
        }
    }
}