using System;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Metadata;
using Microsoft.VisualBasic.FileIO;

namespace oop_lab1
{
    internal class Program
    {
        static void Task1_Var3()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Rectangle rec1 = new Rectangle();

            Console.WriteLine("Input sideA x sideB");
            string[] value = Console.ReadLine().Trim().Split();
            rec1.SideA = Convert.ToDouble(value[0]);
            rec1.SideB = Convert.ToDouble(value[1]);

            Console.WriteLine(rec1);

            Console.WriteLine($"P = {Rectangle.Perimeter(rec1)}\n" +
                $"S = {Rectangle.Surface(rec1)}\n");
        }

        static void Task2_Var3()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            hubpoint:
            Console.WriteLine($"\n\n1 - Operations with triangle\n" +
                $"2 - Operations with Prism\n" +
                $"Prass any key to leave program\n");

            int option = Int32.Parse(Console.ReadLine());
            switch (option) 
            {
                case 1: 
                    {
                        TTriangle triangle = new TTriangle();

                        Console.WriteLine("\nInput sides of Triangle (SideA SideB SideC)\n");
                        string[] value = Console.ReadLine().Trim().Split();
                        triangle.SideA = Convert.ToDouble(value[0]);
                        triangle.SideB = Convert.ToDouble(value[1]);
                        triangle.SideC = Convert.ToDouble(value[2]);
                    savepoint:
                        Console.WriteLine($"\n\nSides of triangle: {triangle}\n\n");

                        Console.WriteLine($"1 - Calculate Area of Triangle\n" +
                            $"2 - Calculate Perimeter of Triangle\n" +
                            $"3 - Comparison with another triangle\n" +
                            $"4 - Multiplication\n" +
                            $"Prass any key to leave program\n");

                        int key = Int32.Parse(Console.ReadLine());
                        switch (key)
                        {
                            case 1: Console.WriteLine($"Area of Triangle = {TTriangle.Surface(triangle)}"); goto savepoint;
                            case 2: Console.WriteLine($"Perimeter of Triangle = {TTriangle.Perimeter(triangle)}"); goto savepoint;
                            case 3:
                                {
                                    Console.WriteLine($"Firrts Triangle: {triangle}\n");
                                    Console.WriteLine($"Input new triangle for Comparison\n");
                                    Console.WriteLine("Input sides of Triangle (SideA SideB SideC)\n");

                                    TTriangle triangle_ = new TTriangle();

                                    string[] value_ = Console.ReadLine().Trim().Split();
                                    triangle_.SideA = Convert.ToDouble(value_[0]);
                                    triangle_.SideB = Convert.ToDouble(value_[1]);
                                    triangle_.SideC = Convert.ToDouble(value_[2]);

                                    if (TTriangle.IsSimilar(triangle, triangle_))
                                        Console.WriteLine($"SUCCESS, triangle {triangle} = triangle {triangle_}\n");
                                    else
                                        Console.WriteLine($"NO, triangle {triangle} != triangle {triangle_}\n");
                                    triangle_ = null;
                                    goto savepoint;
                                }
                            case 4:                          
                                Console.WriteLine($"\n\nSides of 1 triangle: {triangle}\n\n" +
                                    $"Input num:");
                                double num = Double.Parse(Console.ReadLine());

                                Console.WriteLine($"\nTriangle * num = {triangle * num}\n" +
                                    $"Num * triangle = {num * triangle}\n");
                                goto savepoint;

                            default: goto hubpoint;
                              
                        }
                        goto hubpoint;
                    }

                case 2:
                    {
                        TTrianglePrizm prizm = new TTrianglePrizm();

                        TTriangle triangle = new TTriangle();

                        Console.WriteLine("\nInput sides of Triangle and Height (SideA SideB SideC Height)\n");
                        string[] value = Console.ReadLine().Trim().Split();
                        triangle.SideA = Convert.ToDouble(value[0]);
                        triangle.SideB = Convert.ToDouble(value[1]);
                        triangle.SideC = Convert.ToDouble(value[2]);
                        double height = Convert.ToDouble(value[3]);

                        prizm = new TTrianglePrizm(triangle, height);

                        Console.WriteLine($"\n\nPrism: {prizm}\n" +
                            $"Volume of prizm: {TTrianglePrizm.Volume(prizm)}\n" +
                            $"Area of prizm: {TTrianglePrizm.Surface(prizm)}\n");
                        break;
                    }
                    default: break;
            }

           
        }

        static void Main(string[] args)
        {// Лаба 1. Завдання 1 варіант 3; Завдання 2 варіант 3.
            savepoint:
            Console.WriteLine($"\n1 - Operation with Rectangle\n" +
                $"2 - Opration with Triangle and Prism\n" +
                $"0 - Exit\n" +
                $"Prass any key to leave program\n");
            int key = Int32.Parse(Console.ReadLine());
            switch (key)
            {
                case 0: Environment.Exit(0); break;
                case 1: Task1_Var3(); goto savepoint;
                case 2: Task2_Var3(); goto savepoint;
                    default: break;
            }
        }
    }
}
