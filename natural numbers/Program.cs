using System;

namespace natural_numbers
{
    internal class Program
    {
        private static int sum;

        static void Main(string[] args)
        {
            Console.Write("Find the sum of first 10 natural numbers:\n");
            Console.Write("\n\n");
            Console.Write("The first 10 natural number are :\n");
            for (int j = 1; j <= 10; j++)
            {
                sum = sum + j;
                Console.Write("{0} ", j);
            }
            Console.Write("\nThe Sum is : {0}\n", sum);
            {
                int j, n, sum = 0;
                Console.Write("Display n terms of natural number and their sum:\n");
                Console.Write("\n\n");

                Console.Write("Input Value of terms : ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nThe first {0} natural number are :\n", n);
                for (j = 1; j <= n; j++)
                {
                    Console.Write("{0} ", j);
                    sum += j;
                }
                Console.Write("\nThe Sum of Natural Number upto {0} terms : {1} \n", n, sum);
                {
                    int i;
                    Console.Write("Display the first 10 natural numbers:\n");

                    Console.Write("\n\n");

                    Console.WriteLine("The first 10 natural number are:");

                    for (i = 1; i <= 10; i++)
                    {
                        Console.Write("{0} ", i);
                    }
                    {
                        int b, sum1 = 0;
                        double avg;
                        Console.Write("Read 10 numbers and calculate sum and average:\n");
                        Console.Write("----------------------------------------------");
                        Console.Write("\b\b");

                        Console.Write("Input the 10 numbers : \b");
                        for (i = 1; i <= 10; i++)
                        {
                            Console.Write("Number-{0} :", i);

                            b = Convert.ToInt32(Console.ReadLine());
                            sum1 += b;
                        }
                        avg = sum / 10.0;
                        Console.Write("The sum of 10 no is : {0}\bThe Average is : {1}\b", sum, avg);
                    }
                    int c, ctr;
                    Console.Write("Display the cube of the number:\n");
                    Console.Write("Input number of terms : ");
                    ctr = Convert.ToInt32(Console.ReadLine());
                    for (i = 1; i <= ctr; i++)
                    {
                        Console.Write("Number is : {0} and cube of the {1} is :{2} \n", i, i, (i * i * i));
                    }
                    {
                        int f;
                        Console.Write("Display the multiplication table:\n");
                        Console.Write("\n\n");

                        Console.Write("Input the number (Table to be calculated) : ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n");
                        for (f = 1; f <= 10; f++)
                        {
                            Console.Write("{0} X {1} = {2} \n", n, f, n * f);
                        }
                        {
                            int s, p;
                            Console.Write("Display the multiplication table vertically from 1 to n:\n");
                            n = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Multiplication table from 1 to {0} \n", n);
                            for (p = 1; p <= 10; p++)
                            {
                                for (s = 1; s <= n; s++)
                                {
                                    if (s <= n - 1)
                                        Console.Write("{0}x{1} = {2}, ", s, p, p * s);
                                    else
                                        Console.Write("{0}x{1} = {2}", p, s, s * p);
                                }
                                {
                                    int t, sum2 = 0;
                                    Console.Write("Display the sum of n odd natural number:\n");
                                    Console.Write("Input number of terms : ");
                                    n = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("\nThe odd numbers are :");
                                    for (t = 1; t <= n; t++)
                                    {
                                        Console.Write("{0} ", 2 * t - 1);
                                        sum2 += 2 * i - 1;
                                    }
                                    Console.Write("\nThe Sum of odd Natural Number upto {0} terms : {1} \n", n, sum2);
                                }
                                {
                                    int o, u, rows;
                                    Console.Write("Display the pattern like right angle using asterisk:\n");
                                    Console.Write("Input number of rows : ");
                                    rows = Convert.ToInt32(Console.ReadLine());
                                    for (o = 1; o <= rows; o++)
                                    {
                                        for (u = 1; u <= o; u++)
                                            Console.Write("*");
                                        Console.Write("\n");
                                    }
                                    {
                                        int x, z, rows1;
                                        Console.Write("Display the pattern as right angle triangle using number:\n");
                                        Console.Write("Input number of rows1 : ");
                                        rows1 = Convert.ToInt32(Console.ReadLine());
                                        for (x = 1; x <= rows; x++)
                                        {
                                            for (z = 1; z <= i; z++)
                                                Console.Write("{0}", z);
                                            Console.Write("\n");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    {

                    }

                }
            }
        }
    }
}
