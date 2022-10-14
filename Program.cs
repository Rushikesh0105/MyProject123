using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Console.WriteLine("Enter Age");
             int age = Convert.ToInt32(Console.ReadLine());
             if(age>18)
             {
                 Console.WriteLine("Valid for Vote");
             }
             else
             {
                 Console.WriteLine("Not Valid For Vote");
             }*/



            //  SumOfNatural

            /* Console.WriteLine("Enter Number");
             int n = Convert.ToInt32(Console.ReadLine());
             int sum = 0;

             for (int i = 1; i <= n; i++)
             {
                 // sum = sum + i;
                 sum += i;
             }
             {
                 Console.WriteLine("Sum of first {0} natural numbers = {1}", n, sum);*/

            //Table

            /*  int j, n;

              Console.Write("\n\n");
              Console.Write("Display the multiplication table:\n");
              Console.Write("-----------------------------------");
              Console.Write("\n\n");

              Console.Write("Input the number (Table to be calculated) : ");
              n = Convert.ToInt32(Console.ReadLine());
              Console.Write("\n");
              for (j = 1; j <= 10; j++)
              {
                  Console.Write("{0} X {1} = {2} \n", n, j, n * j);
              }*/

            //Print reverse


            /* int n, reverse = 0, rem;
             Console.Write("Enter a number: ");
             n = int.Parse(Console.ReadLine());
             while (n != 0)
             {
                 rem = n % 10;
                 reverse = reverse * 10 + rem;
                 n /= 10;
             }
             Console.Write("Reversed Number: " + reverse);  */




            // Largest between three


            /* int num1, num2, num3;
             Console.Write("\n\n");
             Console.Write("Find the largest of three numbers:\n");
             Console.Write("------------------------------------");
             Console.Write("\n\n");

             Console.Write("Input the 1st number :");
             num1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("Input the  2nd number :");
             num2 = Convert.ToInt32(Console.ReadLine());
             Console.Write("Input the 3rd  number :");
             num3 = Convert.ToInt32(Console.ReadLine());

             if (num1 > num2)
             {
                 if (num1 > num3)
                 {
                     Console.Write("The 1st Number is the greatest among three. \n\n");
                 }
                 else
                 {
                     Console.Write("The 3rd Number is the greatest among three. \n\n");
                 }
             }
             else if (num2 > num3)
                 Console.Write("The 2nd Number is the greatest among three \n\n");
             else
                 Console.Write("The 3rd Number is the greatest among three \n\n");*/



            // sum of even



            /* int i, num, sum = 0;

             Console.Write("Enter any number: ");
             num = Convert.ToInt32(Console.ReadLine());

             for (i = 2; i <= num; i += 2)
             {
                 sum += i;
             }
             Console.WriteLine("Sum of all even number between 1 to " + num + " = " + sum);

             Console.ReadLine();  */


            // area of triangle

            /* 
             Console.WriteLine("Enter the base of triangle:");
             double triangleBase = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Enter the height of triangle:");
             double triangleHeight = Convert.ToDouble(Console.ReadLine());
             double areaOfTriangle = (triangleBase * triangleHeight) / 2;
             Console.WriteLine("Area of triangle is: " + areaOfTriangle);
            */


            //Area of rectangle

            /* double length, breadth, area;
             Console.WriteLine("Enter length of rectangle : ");
             length = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Enter breadth of rectangle : ");
             breadth = Convert.ToDouble(Console.ReadLine());
             area = length * breadth;
             Console.WriteLine("\nArea of rectangle: " + area);
             Console.ReadKey();
            */



            //Arithmatic Operator

            /* int result;
             int x = 20, y = 10;
             result = (x + y);
             Console.WriteLine("Addition Operator: " + result);
             result = (x - y);
             Console.WriteLine("Subtraction Operator: " + result);
             result = (x * y);
             Console.WriteLine("Multiplication Operator: " + result);
             result = (x / y);
             Console.WriteLine("Division Operator: " + result);
             result = (x % y);
             Console.WriteLine("Modulo Operator: " + result);
             Console.WriteLine("Press Enter Key to Exit..");
             Console.ReadLine();
            */




            int[,] list = new int[3, 2];
            Console.WriteLine(  "Enter the elements in an array: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    list[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
                for(int i= 0; i<3;i++)

                {
                    for(int j=0;j<2;j++)
                    {
                        Console.Write(list [i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }

