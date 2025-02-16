﻿
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
        }
    }
}
