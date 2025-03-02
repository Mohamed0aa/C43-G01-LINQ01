﻿
using System.Net.Http.Headers;
using static Assignment.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1=>for fluent
            //2=> for query

            #region q1 : Find all products that are out of stock.
            ////1
            //var result = ProductList.Where(p => p.UnitsInStock == 0);

            ////2
            //result=from p in ProductList
            //       where p.UnitsInStock == 0
            //       select p;

            //foreach (var item in result) 
            //    Console.WriteLine(item);
            #endregion


            #region q2 :Find all products that are in stock and cost more than 3.00 per unit.

            ////1
            //var result = ProductList.Where(p => p.UnitsInStock == 0 &&p.UnitPrice>(decimal)3.00);

            ////2
            //result = from p in ProductList
            //         where p.UnitsInStock == 0 && p.UnitPrice > (decimal)3.00
            //         select p;

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion


            #region q3: Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            ////1
            //var result = Arr.Where((x, i) => x.Length < i)
            //           .Select(i=>i);

            ////2 indexed where not valid in query syntax


            //foreach(var x in result) 
            //    Console.WriteLine(x);

            #endregion

            #region q4 : 1. Return a sequence of just the names of a list of products.

            ////1
            //var result = ProductList.Select(x => x.ProductName);



            ////2
            //result=from x in ProductList
            //       select x.ProductName;


            //foreach (var item in result) 
            //    Console.WriteLine(item);

            #endregion


            #region q5 : Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            ////1
            //var result = words.Select(x => new { Upper = x.ToUpper(), Lower = x.ToLower() });

            ////2
            //result = from x in words
            //         select new { Upper = x.ToUpper(), Lower = x.ToLower() };


            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}
            #endregion

            #region q6 : 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            ////1
            //var result = ProductList.Select(x => new { x.ProductID, x.ProductName, Price = x.UnitPrice });

            ////2
            //result = from x in ProductList
            //         select new { x.ProductID, x.ProductName, Price = x.UnitPrice };


            //foreach (var item in result) 
            //    Console.WriteLine(item);
            #endregion


            #region q7 : 4. Determine if the value of ints in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            ////1
            //var result=Arr.Select((x,i)=>x==i);

            ////2 indexed select not valid in query syntax

            //foreach(var x in result) 
            //    Console.WriteLine(x);


            #endregion


            #region q8 : 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            ////1
            //var result = numbersA.SelectMany(a => numbersB, (a, b) => new { x = a, y = b })
            //                    .Where(z => z.x < z.y);




            //     var result = from x in numbersA
            //                 from y in numbersB
            //                 where x<y
            //                 select $"{x} less than {y}";


            //foreach ( var x in result)
            //    Console.WriteLine(x);

            #endregion


            #region q9 : 6. Select all orders where the order total is less than 500.00.

            ////1
            //    var r = CustomerList.SelectMany(c => c.Orders!).
            //                         Where(c=>c.Total< (decimal)500.00);



            ////2
            //     r = from c in CustomerList
            //        from o in c.Orders!
            //        where o.Total< (decimal)500.00
            //        select o;

            //foreach (var c in r) 
            //    Console.WriteLine(c);
            #endregion



            #region  q10 : 7. Select all orders where the order was made in 1998 or later.
            ////1
            //var r = CustomerList.SelectMany(c => c.Orders!).
            //                     Where(c => c.OrderDate.Year <= 1998);



            ////2
            //r = from c in CustomerList
            //    from o in c.Orders!
            //    where o.OrderDate.Year <= 1998
            //    select o;

            //foreach (var c in r)
            //    Console.WriteLine(c);
            #endregion




        }
    }
}
