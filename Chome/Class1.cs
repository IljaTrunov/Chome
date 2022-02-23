//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Class1
//{
//    class lists
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





//            List<people> peopled = new List<people>();
//            pp1.Add(new people() { Name = "Bobik" });

//            foreach (people people in pp1)
//            {
//                Console.WriteLine(people.Name);
//            }



//            string[] name1 = new string[1] { "bobek" };
//            List<string> names = new List<string>(name1);
//            Console.WriteLine("Напиши имя");
//            names.Add(Console.ReadLine());
//            names.Insert(0, "Бобик");
//            if (names.Contains("Бобик"))
//            {
//                Console.WriteLine("Это имя уже существует"+"оно находится в {0} месте",names.IndexOf("Бобик"));
//            }
//            else
//            {
//                Console.WriteLine("Это имя не существует");
//            }
//            foreach (string name in names)
//            {
//                Console.WriteLine(name);
//            }
//            Console.ReadKey();
//        }
//    }
//}

