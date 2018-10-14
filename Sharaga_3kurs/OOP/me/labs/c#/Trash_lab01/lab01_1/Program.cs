using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_1
{
    class Student
    {
        private string _name;
        private int _course;
        private bool _man;

        public string name
        {
            get { return this._name; }
            set
            {
                //Console.WriteLine(value);
                bool digit = false;
                int x;
                string ss = value;
                for(int i = 0; i < ss.Length; i++)
                {
                    if (ss[i] >= '0' && ss[i] <= '9')
                    {
                        digit = true;
                        break;
                    }
                }

                if (ss.Length < 20 && digit == false)
                {
                    this._name = ss;
                }
                else
                {
                    Console.WriteLine("Incorrect Name.");
                    this._name = "UNKNOWN";
                }
            }

        }

        public int course
        {
            set
            {
                if (value > 0 && value < 5)
                {
                    _course = value;
                }
                else
                {
                    Console.WriteLine("Incorrect course.");
                }
            }
            get { return _course; }
        }

        public bool man { set; get; }

        public Student(string n, int c, bool m)
        {
            try
            {
                name = n;
                course = c;
                man = m;
            }
            catch
            {
                Console.WriteLine("Incorrect input. ERROR");
                return;
            }
        }

        public Student()
        {
        }

        public void input()
        {

            try
            {
                Console.WriteLine("Enter name.. ");
                name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter course.. ");
                course = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Man(true) or woman(false) ? ");
                man = Convert.ToBoolean(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input. ERROR");
                return;
            }
        }

        public void output()
        {
            Console.WriteLine("Name - " + name);
            Console.WriteLine("Course - " + course.ToString());
            Console.WriteLine("Is man - " + Convert.ToBoolean(man));
            Console.WriteLine();
        }
    };



    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student("Petya", 3, true);

            s1.input();
            s1.output();
            s2.output();
            Console.ReadLine();

            return;
        }
    }
}
