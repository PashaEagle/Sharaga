﻿using System;
using System.Collections.Generic;

namespace lab07_1
{
    class Point
    {
        private int x;
        private int y;
        public int X { set { x = value; } get { return x; } }
        public int Y { set { y = value; } get { return y; } }
        public Point() { }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void show()
        {
            Console.WriteLine( "X: " + this.x );
            Console.WriteLine( "Y: " + this.y );
        }

        public double distance()
        {
            return (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
        }

        public void onVector(int a, int b)
        {
            Console.WriteLine( "X: " + (a + x));
            Console.WriteLine( "Y: " + b + y );
        }

        public void setPointXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void XYMultiplyBy(int z)
        {
            x *= z;
            y *= z;
        }

    };


    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(7, 8);
            Point p2 = new Point(5, 6);
            Point p3 = new Point(0, 0);

            Queue<Point> q = new Queue<Point>();
            
            q.Enqueue(p1);
            q.Enqueue(p2);
            q.Enqueue(p3);

            Console.WriteLine("Queue size = " + q.Count);
            int i = 1;
            while (q.Count > 0)
            {
                Console.WriteLine("Element {0}:", i);
                Console.WriteLine("X = {0}", q.Peek().X);
                Console.WriteLine("Y = {0}", q.Peek().Y);
                Console.WriteLine();
                q.Dequeue();
            }

            
            
            Stack<Point> s = new Stack<Point>();
            
            s.Push(p1);
            s.Push(p2);
            s.Push(p3);

            Console.WriteLine("Stack size = " + s.Count);
            i = 1;
            while (s.Count > 0)
            {
                Console.WriteLine("Element {0}:", i);
                Console.WriteLine("X = {0}", s.Peek().X);
                Console.WriteLine("Y = {0}", s.Peek().Y);
                Console.WriteLine();
                s.Pop();
            }


        }
    }
}