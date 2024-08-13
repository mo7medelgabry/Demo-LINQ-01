using System;

namespace Demo_LINQ_01
{
    internal class Program
    {
        
            //static var Print(var X)
            //{
            //    return X;
            //}

            //static dynamic Print(dynamic X)
            //{
            //    return X;
            //}


            static void Main(string[] args)
            {

                #region Implicity Typed

                #region C# Keyword : var
                //var Data01 = "Ahmed";

                //var X = 12; 

                //var X;

                //var X = null;

                //Data01 = 12;

                //var X = 12;

                //X = "Ahmed";
                //X = new Object();
                #endregion

                #region Implicit dynamic
                //dynamic Data02 = "Ahmed";

                // Console.WriteLine(Data02.GetType().Name);

                // Data02 = 12;

                // Console.WriteLine(Data02.GetType().Name);

                // Data02 = 'a';

                // Console.WriteLine(Data02.GetType().Name);

                // Data02 = 1.9;

                // Console.WriteLine(Data02.GetType().Name);

                //Data02 = new StringBuilder(value: "");

                //dynamic X = null;

                //Console.WriteLine(X);

                #endregion

                #endregion

                #region Extesnion Methods

                //int Number = 12345;

                //var Result =  IntExtension.Reverse(Number);

                // Console.WriteLine(Result);

                //var Result =  Number.Reverse();

                //  Console.WriteLine(Result);

                //var Result = IntExtension.Reverse(Number);

                //Console.WriteLine(Result);

                //Number.Reverse();
                //Console.WriteLine(Number);

                //var X = 1.2 % 10;
                //Console.WriteLine(X);

                #endregion

                #region Anonymous

                //Employee Emp01 = new Employee() { id = 1, Name = "Ahmed", Salary = 12000 };

                //var Emp01 = new { id = 1, Name = "Ahmed", Salary = 12000 };

                //var Emp02 = new { id = 1, Name = "Ahmed", Salary = 12000 };

                //Emp01.id = 12;

                //var Emp02 = Emp01 with { id = 12};

                //Console.WriteLine(Emp01);
                //Console.WriteLine(Emp02);

                //Console.WriteLine(Emp01.GetType().Name);
                //Console.WriteLine(Emp02.GetType().Name);


                //if (Emp01.Equals(Emp02))
                //    Console.WriteLine("Equal");
                //else
                //    Console.WriteLine("not Equal");

                #endregion

                #region LINQ

                //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5 };

                //var Result =  Enumerable.Where(Numbers, N => N % 2 == 0);


                //var Result = Numbers.Where( N => N % 2 == 0);

                //Numbers.Any();

                //foreach (var item in Result)
                //{
                //    Console.WriteLine(item);
                //}

                #endregion

                #region LINQ Syntax
                //List<int> Numbers = new List<int>() { 9, 8, 7, 6, 5, 1, 2, 3, 4 };

                //var Result = Enumerable.Where(Numbers, N => N % 2 == 0);

                //foreach (int item in Result) 
                //{
                //    Console.Write(item + " ");
                //}

                //var Result = Numbers.Where(N => N % 2 == 0); 

                //foreach (int item in Result)
                //{
                //    Console.Write(item + " ");
                //}


                //List<int> Numbers = new List<int>() { 9, 8, 7, 6, 5, 1, 2, 3, 4 };

                //var Result = from N in Numbers
                //             where N % 2 == 0
                //             select N;

                //foreach(var item in Result)
                //{
                //    Console.WriteLine(item);
                //} 
                #endregion

                #region LINQ Execution
                //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                //var Result = Numbers.Where(N => N % 2 == 0).ToList();

                //Numbers.AddRange(new int[] { 10, 11, 12 });

                //foreach (var item in Result) 
                //{
                //    Console.WriteLine(item + " ");
                //} 
                #endregion

                //ListGenerator.ProductsList

                #region Setup

                Console.WriteLine(ListGenerator.ProductsList[0]);
                Console.WriteLine(ListGenerator.CustomersList[0]);
                #endregion


            }
        }
    }
