using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks50
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = -1;

            while (n != 0)
            {
                
                Console.WriteLine("Enter number of task 1...47, type 0 to exit:");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Task 1:");
                        f1();
                        break;
                    case 2:
                        Console.WriteLine("Task 2:");
                        f2();
                        break;
                    case 3:
                        Console.WriteLine("Task 3:");
                        f3();
                        break;
                    case 4:
                        Console.WriteLine("Task 4:");
                        f4();
                        break;
                    case 5:
                        Console.WriteLine("Task 5:");
                        f5();
                        break;
                    case 6:
                        Console.WriteLine("Task 6:");
                        f6();
                        break;
                    case 7:
                        Console.WriteLine("Task 7:");
                        f7();
                        break;
                    case 8:
                        Console.WriteLine("Task 8:");
                        f8();
                        break;
                    case 9:
                        Console.WriteLine("Task 9:");
                        f9();
                        break;
                    case 10:
                        Console.WriteLine("Task 10:");
                        f10();
                        break;
                    case 11:
                        Console.WriteLine("Task 11:");
                        f11();
                        break;
                    case 12:
                        Console.WriteLine("Task 12:");
                        f12();
                        break;
                    case 13:
                        Console.WriteLine("Task 13:");
                        f13();
                        break;
                    case 14:
                        Console.WriteLine("Task 14:");
                        f14();
                        break;
                    case 15:
                        Console.WriteLine("Task 15:");
                        f15();
                        break;
                    case 16:
                        Console.WriteLine("Task 16:");
                        f16();
                        break;
                    case 17:
                        Console.WriteLine("Task 17:");
                        f17();
                        break;
                    case 18:
                        Console.WriteLine("Task 18:");
                        f18();
                        break;
                    case 19:
                        Console.WriteLine("Task 19:");
                        f19();
                        break;
                    case 20:
                        Console.WriteLine("Task 20:");
                        f20();
                        break;
                    case 21:
                        Console.WriteLine("Task 21:");
                        f21();
                        break;
                    case 22:
                        Console.WriteLine("Task 22:");
                        f22();
                        break;
                    case 23:
                        Console.WriteLine("Task 23:");
                        f23();
                        break;
                    case 24:
                        Console.WriteLine("Task 24:");
                        f24();
                        break;
                    case 25:
                        Console.WriteLine("Task 25:");
                        f25();
                        break;
                    case 26:
                        Console.WriteLine("Task 26:");
                        f26();
                        break;
                    case 27:
                        Console.WriteLine("Task 27:");
                        f27();
                        break;
                    case 28:
                        Console.WriteLine("Task 28:");
                        f28();
                        break;
                    case 29:
                        Console.WriteLine("Task 29:");
                        f29();
                        break;
                    case 30:
                        Console.WriteLine("Task 30:");
                        f30();
                        break;
                    case 31:
                        Console.WriteLine("Task 31:");
                        f31();
                        break;
                    case 32:
                        Console.WriteLine("Task 32:");
                        f32();
                        break;
                    case 33:
                        Console.WriteLine("Task 33:");
                        f33();
                        break;
                    case 34:
                        Console.WriteLine("Task 34:");
                        f34();
                        break;
                    case 35:
                        Console.WriteLine("Task 35:");
                        f35();
                        break;
                    case 36:
                        Console.WriteLine("Task 36:");
                        f36();
                        break;
                    case 37:
                        Console.WriteLine("Task 37:");
                        f37();
                        break;
                    case 38:
                        Console.WriteLine("Task 38:");
                        f38();
                        break;
                    case 39:
                        Console.WriteLine("Task 39:");
                        f39();
                        break;
                    case 40:
                        Console.WriteLine("Task 40:");
                        f40();
                        break;
                    case 41:
                        Console.WriteLine("Task 41:");
                        f41();
                        break;
                    case 42:
                        Console.WriteLine("Task 42:");
                        f42();
                        break;
                    case 43:
                        Console.WriteLine("Task 43:");
                        f43();
                        break;
                    case 44:
                        Console.WriteLine("Task 44:");
                        f44();
                        break;
                    case 45:
                        Console.WriteLine("Task 45:");
                        f45();
                        break;
                    case 46:
                        Console.WriteLine("Task 46:");
                        f46();
                        break;
                    case 47:
                        Console.WriteLine("Task 47:");
                        f47();
                        break;
                    default:
                        if(n != 0)
                        Console.WriteLine("This nuber of the task does not exist!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void f1()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Press any key to exit.");           
        }

        public static void f2()
        {
            int a, b, c;
            Console.WriteLine("Enter 3 numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(c + " " + b + " " + a);            
        }

        public static void f3()
        {
            int x;
            Console.WriteLine("Enter number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X^2 = " + x*x);            
        }

        public static void f4()
        {
            int x,a,b,c;
            Console.WriteLine("Enter number");
            x = Convert.ToInt32(Console.ReadLine());
            a = x % 10;
            x = x / 10;
            b = x % 10;
            x = x / 10;
            c = x;
            Console.WriteLine("X inv = " + (100 * a + 10 * b + c));            
        }

        public static void f5()
        {
            int x,count = 0;
            Console.WriteLine("Enter number");
            x = Convert.ToInt32(Console.ReadLine());
            count = count + x % 2;
            x = x / 2;
            count = count + x % 2;
            x = x / 2;
            count = count + x % 2;
            x = x / 2;
            count = count + x;
            Console.WriteLine("X 1 bit = " + count);            
        }

        public static void f6()
        {
            int x, y;
            Console.WriteLine("Enter 2 numbers");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
                Console.WriteLine("X = " + x + " greater then Y = " + y);
            else if (x < y) Console.WriteLine("Y = " + y + " greater then X = " + x);
            else Console.WriteLine("X = Y = " + x);            
        }

        public static void f7()
        {
            int x, y,z;
            Console.WriteLine("Enter 3 numbers");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                if( x > z)
                Console.WriteLine("X = " + x );
                else Console.WriteLine("Z = " + z);
            }
            else if (y > z) Console.WriteLine("Y = " + y);
                else Console.WriteLine("Z = " + z);            
        }

        public static void f8()
        {
            int nDay;
            Console.WriteLine("Enter number of day");
            nDay = Convert.ToInt32(Console.ReadLine());
            switch (nDay)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("This day of the week does not exist!");
                    break;
            }            
        }

        public static void f9()
        {
            int x,a,b;
            Console.WriteLine("Enter number");
            x = Convert.ToInt32(Console.ReadLine());
            a = x % 10;
            x = x / 10;
            b = x % 10;
            x = x / 10;
            a = 10 * a + b;
            Console.WriteLine(x == a);          
        }

        public static void f10()
        {
            int x,right,left;
            Console.WriteLine("Enter number");
            x = Convert.ToInt32(Console.ReadLine());
            right = x % 10;
            x = x / 10;
            right = right + x % 10;
            x = x / 10;
            left = x % 10;
            x = x / 10;
            left = left + x;
            Console.WriteLine(left == right);        
        }

        public static void f11()
        {
            int x,a,b,c,d;
            Console.WriteLine("Enter number");
            x = Convert.ToInt32(Console.ReadLine());
            a = x % 2;
            x = x / 2;
            b = x % 2;
            x = x / 2;
            c = x % 2;
            x = x / 2;
            d = x % 2;
            x = x / 2;
            a = 8 * a + 4 * b + 2 * c + d;
            Console.WriteLine(x == a);         
        }

        public static void f12()
        {
            int a, b, c, d;double  x1, x2;
            Console.WriteLine("Enter 3 numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            d = b * b - 4 * a * c;
            if (d >= 0) 
                if (d != 0) 
                { 
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("x1 = " +  x1 + ", x2 = " + x2);
                }
                else 
                {
                    x1 = -(b / 2 * a);
                    Console.WriteLine("x = " + x1);
                }
            else Console.WriteLine("No real solutions!");
            
        }

        public static void f13()
        {
            int n ;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers 1...n :");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }   
        }

        public static void f14()
        {
            int n;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            if(n != 1)
            for (int i = n - 1; i > 0; i--)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i); break;
                }
            }
            else Console.WriteLine(1); 
        }

        public static void f15()
        {
            int n;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            if (n != 1)
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine(i); break;
                    }
                }
            else Console.WriteLine(1); 
        }

        public static void f16()
        {
            int n, count = 0;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividers :"); 
            for (int i = 1; i <= n; i++)
			{
                if (n % i == 0)
                {
                    count++;
                    Console.WriteLine(i);
                }
			}
            Console.WriteLine("Answer: " + count);
        }

        public static void f17()
        {
            int n, count = 0;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            for (int i = 1; i <= n; i++)
            if (n % i == 0) count++;
            Console.WriteLine(count == 2);  
        }

        public static void f18()
        {
            int n, count = 0;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            for (int i = 1; i <= n; i++)
			{
                count = 0;
			    for (int k = 1; k <= i; k++)
			    {
			        if (i % k == 0) count++;
			    }
                if (count == 2) Console.WriteLine(i + " ");
			}
        }

        public static void f19()
        {
            int k = 1, n, count, primes = 0;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            while (primes < n)
            {
                count = 0;
                for (int i = 1; i <= k; i++)
			    {
			        if (k % i == 0) count++;
			    }
                if (count == 2)
                {
                    Console.WriteLine(k + " ");
                    primes++;
                }
                k++;
            }
        }

        public static void f20()
        {
            int n, sum = 0;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            for (int i = 1; i < n; i++)
			{
			    if(n % i == 0) sum += i;
			}
            Console.WriteLine(n == sum);
        }

        public static void f21()
        {
            int n1, n2, sum1 = 0, sum2 = 0;
            Console.WriteLine("Enter 2 numbers");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            for (int i = 1; i < n1; i++)
			{
			    if (n1 % i == 0)  sum1 += i;
			}
            if (sum1 == n2)
            {
                for (int i = 1; i < n2; i++)
			    {
			        if (n2 % i == 0) sum2 += i;
			    }
                Console.WriteLine(sum2 == n1);
            }
            else Console.WriteLine("False");
        }

        public static void f22()
        {
            int n, m;
            Console.WriteLine("Enter 2 numbers");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            while (m != n)
	        {
	            if ( m > n ) m -= n;
                else n -= m; 
            }
            Console.WriteLine(m);
        }

        public static void f23()
        {
            int n, m, prod;
            Console.WriteLine("Enter 2 numbers");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            prod = m * n;
            while(m != n)
            {
                if( m > n ) m -= n;
                else n -= m;
            }
            Console.WriteLine(prod / m);
        }

        public static void f24()
        {
            int x, n, res = 1;
            Console.WriteLine("Enter 2 numbers");
            x = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            for (int i = 1; i <= n; i++)
			{
			    res *= x;
			}
            Console.WriteLine(res);
        }

        public static void f25()
        {
            int x, n, r = 1;
            Console.WriteLine("Enter 2 numbers");
            x = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            while(n != 1)
            {
                if(n % 2 != 0) r *= x;
                x = x * x;
                n = n / 2;
            }
             Console.WriteLine(x * r);
        }

        public static void f26()
        {
            int  n;
            double x1, x2;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            for (int i = 1; i <= n; i++)
			{
			    x1 = Math.Sqrt(i * i + 3) - i;
                x2 = -i -  Math.Sqrt(i * i + 3);
                Console.WriteLine("a = " + i +  ", x1 = " + x1 + ", x2 = " + x2);
			}
        }

        public static void f27()
        {
            int n;
            double x, a, res = 0;
            Console.WriteLine("Enter 2 numbers: n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < (n + 1); i++)
			{
                Console.WriteLine("a" + i + " = ");
			    a =  Convert.ToDouble(Console.ReadLine());
                res = res * x + a;
			}
            Console.WriteLine("Answer: ");
            Console.WriteLine(res);
        }

        public static void f28()
        {
            int n; Int64 fact = 1;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            for (int i = 1; i <= n; i++)
			{
			 fact *= i;
			}
            Console.WriteLine(fact);
        }

        public static void f29()
        {
            int n, k, num = 1, denom = 1;
            Console.WriteLine("Enter 2 numbers: n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("k = ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            for (int i = n; i >= n - k + 1; i--)
			{
			 num *= i;
			}
            for (int i = 1; i <= k; i++)
			{
			    denom *= i;
			}
            Console.WriteLine(num / denom);
        }

        public static void f30()
        {
            int n;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            Console.WriteLine(" ____________________________ ");
            //Console.WriteLine("|                            |");
            Console.WriteLine("|{0,7}|{1,7}|{2,7}     |", "x", "x^2", "x^3");
            Console.WriteLine(" ____________________________ ");
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("|{0,7}|{1,7}|{2,7}     |", i, i * i, i * i * i);
                Console.WriteLine(" ____________________________ ");
            }  
        }
        public static void f31()
        {
            int n, r = 0;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            while (n != 0)
	        {
	            r *=10;
                r += (n % 10);
                n /= 10;
	        }
            Console.WriteLine(r);
        }
        public static void f32()
        {
            int n, a, b, delta;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            b = n % 8;
            n = n / 8;
            a = n % 8;
            n = n / 8;
            delta = a - b;
            while(n != 0)
            {
                b = a;
                a = n % 8;
                n = n / 8;
                if (delta * (a-b) <= 0) break;
            }
            Console.WriteLine(delta * (a - b) > 0);
        }
        public static void f33()
        {
            int n, p = 2;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            Console.Write(n + " = 1");
            while (n != 1)
	        {
                if (n % p == 0)
                {
                    Console.Write(" * " + p);
                    n /= p;
                }
                else p++;
	        }
        }
        public static void f34()
        {
            int  a, b, c = 0, z = 1;
            Console.WriteLine("Enter 2 numbers: a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            while ( a != 0)
	        {
	            c = c + z * (b % 10);
                z *= 10;
                b /= 10;
                c += z*(a % 10);
                z *= 10;
                a /= 10;
	        }
            Console.WriteLine(c);            
        }
        public static void f35()
        {
            int x, n, r = 0, z = 1;
            Console.WriteLine("Enter 2 numbers: x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            while (x != 0)
	        {
	            r += z * (x % n);
                x /= n;
                z *= 10;
	        }
            Console.WriteLine(r); 
        }
        public static void f36()
        {
            int m, n, min, mindiv = 1;
            Console.WriteLine("Enter 2 numbers: m = ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            if(n < m) min = n;
            else min = m;
            for (int i = 2; i <= min; i++)
			{
			    if( n % i == 0 && m % i == 0) 
                {
                    mindiv = i; 
                    break;
                }

			}
            if(mindiv != 1) Console.WriteLine(mindiv);
            else Console.WriteLine("No divisors");
        }
        public static void f37()
        {
            int  n, a;
            int left = 0, right = 0, digits = 0;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: ");
            a = n;
            while (a != 0)
	        {
	            a /= 10;
                digits ++;
	        }
            for (int i = 1; i <= digits/2; i++)
			{
			    right += n % 10;
                n /= 10;
			}
            if(digits % 2 != 0) n /= 10;
            for (int i = 1; i <= digits/2; i++)
			{
			    left += n % 10;
                n /= 10;
			}
            Console.WriteLine(left == right);
        }
        public static void f38()
        {
            int n, a, right = 0, digits = 0;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            a = n;
            while (a != 0)
	        {
	            a /= 10;
                digits++;
	        }
            for (int i = 1; i <= digits / 2; i++)
			{
			    right *= 10;
                right += n % 10;
                n /= 10;
			}
            if(digits % 2 != 0) n /= 10;
            Console.WriteLine("Answer: ");
            Console.WriteLine(n == right);
        }
        public static void f39()
        {
            int n;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            while(n > 1)
	        {
	            if(n % 2 == 1) break;
                n /= 2;
	        }
            Console.WriteLine("Answer: ");
            Console.WriteLine(n == 1);
        }
        public static void f40()
        {
            int a, prod = 1;
            Console.WriteLine("Enter number");
            a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                if (a % 2 == 0) prod *= a;
                Console.WriteLine("Enter number");
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Answer: ");
            if (prod != 1) Console.WriteLine(prod);
            else Console.WriteLine("No such elements!");
        }
        public static void f41()
        {
           int a, n, prod = 1;
           Console.WriteLine("Enter 2 numbers: n =");
           n = Convert.ToInt32(Console.ReadLine());
           Console.Write("a = ");
           a = Convert.ToInt32(Console.ReadLine());
           while(a != 0)
           {
               if(a > 9 && a < 100 && a % n == 0) prod *= a;
               Console.Write("a = ");
               a = Convert.ToInt32(Console.ReadLine());
           }
           Console.WriteLine("Answer: ");
           if(prod != 1) Console.Write(prod);
           else Console.WriteLine("No such elements!");
        }
        public static void f42()
        {
            int a, s, count = 0;
            Console.WriteLine("Enter number");
            a = Convert.ToInt32(Console.ReadLine());
            while(a != 0)
            {
                s = 0;
                for (int i = 1; i <= a; i++)
			    {
			        if(a % i == 0) s++;
			    }
                if(s == 2) count++;
                Console.Write("a = ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Answer: ");
            Console.WriteLine(count);
        }
        public static void f43()
        {
            int a, b = 0, first = 1, last = 0;
            Console.WriteLine("Enter number");
            a = Convert.ToInt32(Console.ReadLine());
            if(a != 0) 
            {
                Console.Write("Enter number b = ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            while (b != 0)
	        {
	            last = a % 10;
                first = b;
                while (first > 9)
	            {
	                first /= 10;
	            }
                if(last != first) break;
                a = b;
                Console.Write("Enter number b = ");
                b = Convert.ToInt32(Console.ReadLine());
	        }
            Console.WriteLine("Answer: ");
            Console.WriteLine(last == first);
        }
        public static void f44()
        {
            int left_num, mid__num, right_num;
            Console.WriteLine("Enter number");
            left_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number");
            mid__num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number");
            right_num = Convert.ToInt32(Console.ReadLine());
            while (right_num != 0)
	        {
	            if((left_num - mid__num) * (right_num - mid__num) <= 0) break;
                left_num = mid__num;
                mid__num = right_num;
                Console.WriteLine("Enter number");
                right_num = Convert.ToInt32(Console.ReadLine());
	        }
            if(right_num == 0) right_num = left_num;
            Console.WriteLine("Answer: ");
            Console.WriteLine((left_num - mid__num) * (right_num - mid__num) > 0);
        }
        public static void f45()
        {
            int a, b = 0, delta;
            Console.WriteLine("Enter number");
            a = Convert.ToInt32(Console.ReadLine());
            if(a != 0)
            {
                Console.WriteLine("Enter number");
                b = Convert.ToInt32(Console.ReadLine());
            }
            delta = a - b;
            while (b != 0)
	        {
	            if((delta * (a - b)) < 0) break;
                a = b;
                Console.WriteLine("Enter number");
                b = Convert.ToInt32(Console.ReadLine());
	        }
            if(a == 0) b = 1;
            Console.WriteLine("Answer: ");
            Console.WriteLine(b == 0);
        }
        public static void f46()
        {
            int fib_0 = 0, fib_1 = 1, fib_sum, n;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++)
			{
			    fib_sum = fib_0 + fib_1;
                fib_0 = fib_1;
                fib_1 = fib_sum;
			}
            if(n == 0) fib_1 = 0;
            Console.WriteLine("Answer: ");
            Console.WriteLine(fib_1);
        }
        public static void f47()
        {
            int fib_0 = 0, fib_1 = 1, fib_sum, sum = 1, n;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 0) sum = 0;
            for (int i = 2; i <= n; i++)
            {
                fib_sum = fib_0 + fib_1;
                sum = sum + fib_sum;
                fib_0 = fib_1;
                fib_1 = fib_sum;
            }
            if (n == 0) fib_1 = 0;
            Console.WriteLine("Answer: ");
            Console.WriteLine(sum);
        }
    }
}
