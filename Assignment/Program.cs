
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

            //2 indexed where


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

        }
    }
}
