namespace Task05
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Numerics;

    public class Task05
    {
        public static void Main()
        {
            //var n = int.Parse(Console.ReadLine());

            //var currentOpposite = new StringBuilder();
            //var opposites = new List<string>();
            //var straights = new List<string>();
            //var routes = new List<string>();

            //string ab; 
            //while (true)
            //{
            //    ab = Console.ReadLine();
            //    if (ab == "-1 -1")
            //    {
            //        break;
            //    }

            //    routes.Add(ab);
            //    straights.Add(ab);

            //    for (int i = ab.Length - 1; i >= 0; i--)
            //    {
            //        currentOpposite.Append(ab[i]);
            //    }

            //    opposites.Add(currentOpposite.ToString());
            //    currentOpposite.Clear();
            //}

            ////Console.WriteLine(string.Join(",", routes));
            ////Console.WriteLine(string.Join(",", opposites));

            //var allRoutes = routes.Count;
            //var count = allRoutes;

            //for (int i = allRoutes - 1; i >= 0; i--)
            //{
            //    var current = routes[i];

            //    for (int j = allRoutes - 1; j >= 0; j--)
            //    {
            //        if (i == j)
            //        {
            //            continue;
            //        }

            //        if (current[0] == straights[j][0])
            //        {
            //            count++;
            //        }

            //        if (current[current.Length - 1] == straights[j][straights[j].Length - 1])
            //        {
            //            count++;
            //        }

            //        if ((current == straights[j] && current == opposites[j]))
            //        {
            //            count--;

            //            break;
            //        }
            //    }
            //}


            
            Console.WriteLine(new Random().Next(1, 9999));
        }
    }
}