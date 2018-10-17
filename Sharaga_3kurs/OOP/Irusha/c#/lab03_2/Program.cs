using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;

namespace lab03
{
     
        
        abstract class Challenge
        {
            protected int mark = -1;

            public int Mark
            {
                get { return mark; }
                set { mark = value; }
            }

            public virtual void showMark()
            {
                if (mark == -1)
                {
                    Console.WriteLine("You have not set a mark. Please set it firstly");
                    return;
                }
            }
        }

        
        class Test : Challenge
        {
            private string testName { get; set; } = "*not set*";

            public string Name
            {
                get { return testName; }
                set { testName = value; }
            }

            public override void showMark()
            {
                base.showMark();
                if (testName == "*not set*")
                {
                    Console.WriteLine("You have not set name to this test, please set it firstly..");
                    return;
                }
                Console.WriteLine("The mark of test " + testName + " is " + mark);
            }
        }


        class Exam : Challenge
        {
            protected string examSubject { get; set; } = "*not set*";
            
            public string Subject
            {
                get { return examSubject; }
                set { examSubject = value; }
            }

            public override void showMark()
            {
                base.showMark();
                if (examSubject == "*not set*")
                {
                    Console.WriteLine("You have not set subject to this exam, please set it firstly..");
                    return;
                }
                Console.WriteLine("The mark of " + examSubject + " exam is " + mark);
            }
        }

        class LastExam : Exam
        {
            private bool successfullyPassed = false;

            public string succ
            {
                get
                {
                    if (successfullyPassed) return "EXAM PASSED";
                    else return "EXAM NOT PASSED";
                }

                set
                {
                    string ans = value.ToLower();
                    if (ans == "true") successfullyPassed = true;
                    else successfullyPassed = false;
                }
            }

            public void setSucc()
            {
                Console.WriteLine("If you passed that exam type true..  ");
                string ans = Console.ReadLine().ToString();
                succ = ans;
            }
            
            
        }

        
    internal class Program
    {
        public static void ShowAllInList(List<Challenge> list)
        {
            int i = 0;
            Console.WriteLine();
            foreach (Challenge var in list)
            {
                if (var is Test)
                {
                    Console.Write((++i).ToString() + " - Test, name = " + (var as Test).Name);
                }
                if (var is Exam && !(var is LastExam))
                {
                    Console.Write((++i).ToString() + " - Exam, subject = " + (var as Exam).Subject);
                }
                if (var is LastExam)
                {
                    Console.Write((++i).ToString() + " - LastExam, subject = " + (var as LastExam).Subject);
                }
                Console.WriteLine(", mark = " + var.Mark);
            }
            Console.WriteLine();
        }

        public static void ShowAllInArray(Challenge[] arr)
        {
            int i = 0;
            Console.WriteLine();
            foreach (Challenge var in arr)
            {
                if (var is Test)
                {
                    Console.Write((++i).ToString() + " - Test, name = " + (var as Test).Name);
                }
                if (var is Exam && !(var is LastExam))
                {
                    Console.Write((++i).ToString() + " - Exam, subject = " + (var as Exam).Subject);
                }
                if (var is LastExam)
                {
                    Console.Write((++i).ToString() + " - LastExam, subject = " + (var as LastExam).Subject);
                }
                Console.WriteLine(", mark = " + var.Mark);
            }
            Console.WriteLine();
        }
        
        
        public static void Main(string[] args)
        {   
            
            
            /*
            //        VARIANT 1
            
            Test t1 = new Test();
            Exam ex1 = new Exam();
            LastExam lex1 = new LastExam();

            t1.Mark = 12;
            ex1.Mark = 5;
            
            t1.showMark();
            ex1.showMark();
            lex1.showMark();

            t1.Name = "Math";
            ex1.Subject = "English";
            lex1.Subject = "Physics";
            lex1.succ = "true";

            t1.showMark();
            ex1.showMark();
            lex1.showMark();
            
            
            lex1.setSucc();
            lex1.showMark();
            Console.WriteLine("Exam passed ? " + lex1.succ);
            */

            
            
            
            
            
            
            
            
            /*
            //         VARIANT 2 - SPISOK
            
            List <Challenge> challenges = new List<Challenge>();
            challenges.Add(new Test());
            challenges.Add(new Exam());
            challenges.Add(new LastExam());
            challenges.Add(new Test());
            challenges.Add(new Exam());
            challenges.Add(new LastExam());

            int i = 1;
            foreach (Challenge ch in challenges)
            {
                ch.Mark = ++i;
                
                if (ch is Test)
                {
                    (ch as Test).Name = "English";
                }
                if (ch is Exam)
                {
                    (ch as Exam).Subject = "Computer Science";
                }
                if (ch is LastExam)
                {
                    (ch as LastExam).succ = "true";
                    Console.WriteLine("Exam passed ? " + (ch as LastExam).succ);
                }
                
                ch.showMark();
            }

            ShowAllInList(challenges); // To see all
            challenges[2].Mark = 1;
            ShowAllInList(challenges);
            */
            
            
            
            
            
            
            
            
            /*
            //            VARIANT 3 - MASIV
            
            Challenge[]challs = new Challenge[3];
            challs[0] = new Test();
            challs[1] = new Exam();
            challs[2] = new LastExam();

            for(int i = 0; i < 3; ++i) challs[i].Mark = i + 2;
            
            (challs[0] as Test).Name = "Spanish";
            (challs[1] as Exam).Subject = "Francian";
            (challs[2] as Exam).Subject = "Italian";
     
            for(int i = 0; i < 3; ++i) challs[i].showMark();
            
            ShowAllInArray(challs);
            
            */
            
            
            
            
        }
    }
}