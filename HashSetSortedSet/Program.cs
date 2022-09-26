using System.Xml.Linq;

namespace HashSetSortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HashSet
            var customers = new List<Customer>
            {
             new Customer { Name = "Ehap Azzazi", Telephone = "+20 112 330 1879" },
             new Customer { Name = "Ali Azazi", Telephone = "+20 112 330 1234" },
             new Customer { Name = "Mahmoud Azazi", Telephone = "+20 112 330 5678" },
             new Customer { Name = "Kareem Mohammed", Telephone = "+20 112 330 1870" },
             new Customer { Name = "Mostafa Ahmed", Telephone = "+20 112 330 1871" }

            };
            HashSet<Customer> Custs = new HashSet<Customer>(customers);

            Custs.Add(new Customer { Name = "Ehap Azzazi", Telephone = "+20 112 330 1879" }); // won't be add cuz it's already been added.
            Custs.Add(new Customer { Name = "Ehap", Telephone = "+20 112 330 1879" }); // will be added

            //Custs.ExceptWith(customers);// to remove a list or array or a punch of data at once from a hashset.


            //var customers1 = new List<Customer>
            //{
            //new Customer { Name = "Ehap Azzazi", Telephone = "+20 112 330 1879" },
            //new Customer { Name = "Ali Azazi", Telephone = "+20 112 330 1234" },
            ////true at IsProperSubsetOf()
            //new Customer { Name = "Mostafa1 Ahmed", Telephone = "+20 112 330 1871" } // will return false cuz of Name = "Mostafa1 Ahmed" the '1'. at IsProperSubsetOf()
            //};
            //HashSet<Customer> Custs1 = new HashSet<Customer>(customers1);

            //Console.WriteLine(Custs1.IsProperSubsetOf(Custs)); // Helps u to find which of 2 HashSets is a node of the other or is considered as a part of another. <the samall one>.IntersectWith(<The Large One>);
            // The elements of the smaller one should be the same of the bigger one.

            //Custs.IntersectWith(Custs1); // بنستخدمها علشان نعمل مقارنة بين Double HashSets علشان نطلع اوجه التشابة بين عناصرهم

            //Custs.RemoveWhere(x => x.Name.ToLower().Contains("e"));// The Argument of it should be a bool method as its is a predicate delegate or we can use LAMBDA Expression
            //or
            // Custs.RemoveWhere(MyFunc);

            //Custs.UnionWith(Custs1); // we use it if we want to add a hashset to another.
            
            Console.WriteLine("----------------HashSet----------------");
            foreach (var cust in Custs)
                Console.WriteLine(cust);
            Console.WriteLine("----------------HashSet----------------");
            #endregion


            //=================================================================================


            #region SortedSet
            var Custs0 = new SortedSet<Customer>(Custs);

            Console.WriteLine("----------------SortedSet----------------");
            foreach (var cust in Custs0)
                Console.WriteLine(cust);
            Console.WriteLine("----------------SortedSet----------------");
            #endregion


            Console.ReadLine();
        }

        static bool MyFunc(Customer obj)
        {
            return obj.Name.ToLower().Contains("e");
        }
    }
}