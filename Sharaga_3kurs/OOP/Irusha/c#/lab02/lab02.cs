using System;

namespace lab02_origin_irusha
{
    
    class Darray
    {
        private int n, m;
        private int [,]a;

        public int N
        {
            set { n = value; }
            get { return n; }
        }

        public int M
        {
            set { m = value; }
            get { return m; }
        }
        
        public Darray()
        {
        }

        public Darray(int nn, int mm)
        {
            n = nn;
            m = mm;
            a = new int[n, m];

            for (int i = 0; i < n; i++)
            {// ââîä
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Enter element " + "[" + i + "][" + j + "]  ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }


        public void input_k()
        {
            Console.Write("Enter the amount of rows, colnums :");
            int mm, nn;
            nn = Convert.ToInt32(Console.ReadLine());
            mm = Convert.ToInt32(Console.ReadLine());
            n = nn;
            m = mm;
            a = new int[n, m];
         
            for (int i = 0; i < n; i++)
            {// ââîä
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Enter element " + "[" + i + "][" + j + "]  ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }

        public void output_s()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void sortt()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int k = m - 1; k > j; k--)
                        if (a[i, k] > a[i, k - 1])
                        {
                            int tmp = a[i, k];
                            a[i, k] = a[i, k - 1];
                            a[i, k - 1] = tmp;
                        }
                    //cout << "\t" << "a=" << a[i][j] << "\n";
                }
            }

            Console.WriteLine("Sorted : ");
            output_s();
        }

        public int count_of_elts()
        {    
            return m * n;
        }

        public void multiply_by(int x)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] *= x;
                }
            }

            Console.WriteLine("Successfully multiplied");
        }


        public static Darray operator ++(Darray x)
        {
            for (int i = 0; i < x.N; i++)
            {
                for (int j = 0; j < x.M; j++)
                {
                    x.a[i, j] += 1;
                }
            }

            return x;
        }

        public static Darray operator --(Darray x)
        {
            for (int i = 0; i < x.N; i++)
            {
                for (int j = 0; j < x.M; j++)
                {
                    x.a[i, j] -= 1;
                }
            }

            return x;
        }
        
        public static bool operator true(Darray x)
        {
            bool checker = true;
            for (int i = 0; i < x.N; i++)
            {
                for (int j = 1; j < x.M; j++)
                {
                    if (x.a[i, j] < x.a[i, j - 1]) {checker = false; break;}
                }
            }
            return checker;
        }
        
        public static bool operator false(Darray x)
        {
            bool checker = true;
            for (int i = 0; i < x.N; i++)
            {
                for (int j = 1; j < x.M; j++)
                {
                    if (x.a[i, j] < x.a[i, j - 1]) {checker = false; break;}
                }
            }
            return !checker;
        }

        public static Darray operator *(Darray y, Darray u)
        {
            if (y.M != u.M || y.N != u.N ){Console.WriteLine("Cannot multiply"); return y;}
            for (int i = 0; i < y.N; i++)
            {
                for (int j = 0; j < y.M; j++)
                {
                    y.a[i, j] *= u.a[i, j];
                }
            }
            return y;
        }

        //int** operator !(Darray x);
        //I dont understand last task, ask her
    };
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Darray masyv = new Darray();
            Darray s1 = new Darray(2, 2);
            masyv.input_k();
            masyv.output_s();
            //masyv.sortt();
            Console.WriteLine("Amount of elements is " + masyv.count_of_elts());
            //masyv.multiply_by(2);
            masyv.output_s();

            ++masyv;
            masyv.output_s();

            --masyv;
            masyv.output_s();

            //peregruzka bool
            Console.WriteLine("Masyv sorted in upper ? Answer: ");
            if (masyv) Console.WriteLine("True");
            else Console.WriteLine("False");

            //peregruzka *
            masyv = masyv * s1;
            masyv.output_s();

            Console.ReadKey();
        }
    }
}