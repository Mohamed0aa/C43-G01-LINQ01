using System.Collections.Concurrent;
using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Var
            //var mo = "mohamed";
            //Can Dedect the type  base on Initial value at compilation
            //must be initialized
            //cant be initialized null
            #endregion

            #region Dynamic
            ///Dynamic=var in javascript
            ///clr will resolve the actual type  of variable  in runtime and will changed in assign value
            /// not must be initialized
            ///can be initialized null
            ///
            //i use when i need varible support diffrent type
            //dynamic moo =10;
            #endregion

            #region Amomymous type
            //var mo = new { name = "mohamed", age = 55, salar = 500_000 };
            /////change in order or naming it lead to new anonymous type
            //var mo1 = new { age = 55,name = "mohamed",  salar = 500_000 };
            //Console.WriteLine(mo1.GetType().Name);

            /////object from Anonymous type is imutable [cant be changed]
            ////mo.age = 55//error
            //mo= new { mo.name,  mo.age, salar = 600_000 };

            //mo = mo with { salar = 90000 };
            #endregion

            #region extension method
            //int c = 12345;
            //Console.WriteLine(c.Reverse());
            #endregion

            #region What is  Linq -_-
            //LINQ: stand for Language-Integraded Query
            //LINQ:+40 Extension-Methods for build in interface called IEnumrable
            //this methos called "LINQ Operator" exist in class called "Enumrable"
            //Categorized in 13 category
            //USE LINQ OPERATOR AGAINS Data stored in (Sequence) Regardless Data Stor(File ,Data Provider[Sql,oracle,Mysql)
            //Sequence=>  is object from class implement Interface "IEnumrable" like [list ,Dectionary,Hash set,Array list]
            // 1-local sequence  =>L2o   linq to object     ,l2xml
            // 2-remote sequrnce=> from Data_base   =>L2EF   linq to entity_framework


            #region Differd excution
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var ood = list.Where(x => x % 2 != 0);
            // //List<int>ood = list.Where(x => x % 2 != 0).ToList();//Imediate

            //list.AddRange([10, 11, 12, 13]);

            //foreach (var x in ood)
            //    Console.WriteLine(x);
            #endregion



            #endregion

            #region LINQ Syntax

            #region fluent syntax
            //1-fluent syntax

            ///1.1 call "LINQ Operator"  as static method in class [Enumrable]

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var ood = Enumerable.Where<int>(list, x => x % 2 != 0);


            /////1.2 call "LINQ Operator"  as extension  [recommended]

            //ood = list.Where(x => x % 2 != 0);


            //foreach (var x in ood)
            //    Console.WriteLine(x);
            #endregion


            #region Query syntax
            // uery syntax   like Query syntax in sql style
            /// start with from
            ///  represent each element in  in inpute sequence (x)
            ///  end with select or group by

            //ood=from x in list
            //    where x % 2 != 0
            //    select x;



            //foreach (var x in ood)
            //    Console.WriteLine(x);
            #endregion


            #endregion

            #region  excution Way


            #region Differd excution 

            //List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var ood1 = list1.Where(x => x % 2 != 0);//Differd

            //list.AddRange([10, 11, 12, 13]);

            //foreach (var x in ood1)
            //    Console.WriteLine(x);  // 1 3 5 7 9 11 13 
            #endregion

            #region Immediate excution
            // Immediate excution   used by ( Element  Operator[first ,last,etc] , Casting Operator , Aggregate Operator[count,max,min,sum,avg)
            //List<int> list3 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var ood3 = list3.Where(x => x % 2 != 0).Count();// =>cating operator




            //list.AddRange([10, 11, 12, 13]);

            //foreach (var x in ood)
            //    Console.WriteLine(x);

            #endregion



            #endregion

            #region Data Setup

            #endregion

            #region Filtration Restoration operator -where
            //var result = ProductList.Where(P => P.UnitsInStock == 0);

            //result= from p in ProductList
            //        where p.UnitsInStock == 0
            //        select p;

            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}

            //Indexed where
            // vaild only with fluent syntax not query syntax

            ////// Get from first 10 product the prouduct with  unit stock is 0
            ///
            //result=ProductList.Where( (p,I/*FOR INDEX*/)=>I<=10&&p.UnitsInStock==0);

            #endregion

            #region Transformation (projection OPERATOR)
            //var r = ProductList.Select(x => x.ProductName);
            //var r = ProductList.Where(P => P.UnitsInStock == 0)
            //                     .Select(p => $"{p.ProductName},{p.ProductID}");




            //indexed select
            // vaild only with fluent syntax not query syntax




            //Select Many

            //var r = CustomerList.SelectMany(c => c.Orders!);

            //r=from c in CustomerList
            //  from o in c.Orders!
            //  select o;


            //var r = CustomerList.SelectMany((c,i) => c.Orders!, (cc, oo) => new { cc.CustomerName, oo });


            //var r = from c in CustomerList
            //     from object o in c.Orders!
            //     select new { Customer = c.CustomerName, Order = o };






            #endregion

            #region Ordering operator
            //var r= ProductList.OrderBy(p=>p.UnitPrice).ThenBy(p=>p.UnitsInStock);
            #endregion


            #region Element operator [imidiate operator]
            //ProductList=new List<Product>();

            // var result = ProductList.First(); //throw exception if caller is Empty

            //var result = ProductList.Last();//throw exception if caller is Empty

            //var result = ProductList.First(p =>p.UnitPrice>=100);

            //var result = ProductList.FirstOrDefault(/*Defualt*/new Product { ProductName = "Def" });

            //var result = ProductList.FirstOrDefault(p =>p.UnitPrice==47586924,new Product { ProductName = "Def" });
            //var result = ProductList.FirstOrDefault();not throw exception
            //var result = ProductList.ElementAt(0); //throw exception if caller is Empty
            // var result = ProductList.ElementAtOrDefault(600000);
            //var result = ProductList.Single();//throw exception if caller is Empty or is there more than one element
            //var result = ProductList.Single(p=>p.ProductName=="moha");
            var result = ProductList.SingleOrDefault();// throw exception if there more one element

            Console.WriteLine(result);

            #endregion

        }
    }
}
