//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace Chome
//{
//    class dictC
//    {
//        static void Main(string[] args)
//        {

//            Dictionary<int, string> athletes = new Dictionary<int, string>(5);
//            for (int i = 1; i < 6; i++)
//            {
//                Console.WriteLine($"Value {i}");
//                athletes.Add(i,Console.ReadLine());
//            }
//            Console.WriteLine(athletes[1]);
//            athletes.Remove(4);
//            foreach (KeyValuePair<int,string> kv in athletes)
//            {
//                Console.WriteLine(kv.Key+".place" +kv.Value);
//            }


//            LinkedList<int> list = new LinkedList<int>();
//            for (int i = 1; i < 10; i++)
//            {
//                list.AddFirst(i);
//                if (i%2!=0)
//                {
//                    list.Remove(i);
//                }
//            }
//            foreach (int item in list)
//            {
//                Console.WriteLine(item);
//            }
//            List<people> pp1 = new List<people>();
//            pp1.Add(new people() { Name = "bob" });

//            foreach (people people in pp1)
//            {
//                Console.WriteLine(people.Name);
//            }



//            string[] name1 = new string[1] { "bobik" };
//            List<string> names = new List<string>(name1);
//            Console.WriteLine("Enter a name");
//            names.Add(Console.ReadLine());
//            names.Insert(0, "bobek");
//            if (names.Contains("bobek"))
//            {
//                Console.WriteLine("Это имя уже существует"+"это в {0} месте",names.IndexOf("bobek"));
//            }
//            else
//            {
//                Console.WriteLine("нету такого");
//            }
//            foreach (string name in names)
//            {
//                Console.WriteLine(name);
//            }
//            Console.ReadKey();
//        }
//    }
//}
