using System;
using System.Collections.Generic;
using System.Text;

namespace people
{
    class CclassCopy
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //int value = rand.Next(1, 100);
            //List<int> list = new List<int>();
            //List<int> add = new List<int>();
            //List<int> add1 = new List<int>();
            //int a = 1;
            //foreach (int item in list)
            //{
            //    if (item%2==0)
            //    {
            //        add.Add(item);
            //        Console.WriteLine(item);
            //    }
            //    else
            //    {
            //        add1.Add(item);
            //        Console.WriteLine(item);
            //    }
            //Console.ReadLine();
            //}






            Dictionary<string, string> dict = new Dictionary<string, string>();

            List<string> country = new List<string> { "Estonia", "Russia", "England", "Germany", "Finland" };
            List<string> capital = new List<string> { "Tallinn", "Moscow", "London", "Berlin", "Helsinki" };
            bool wantTo = true;
            int randInt = 0;
            double score = 0;

            for (int i = 0; i < country.Count; i++)
            {
                dict.Add(country[i], capital[i]);
                dict.Add(capital[i], country[i]);
            }
            while (wantTo == true)
            {

                Console.WriteLine("Найти столицу или страну - 1, сделать тест - 2");
                int answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Console.Write("Ввести страну или столицу: ");
                    string input = Console.ReadLine();
                    if (dict.ContainsKey(input))
                    {
                        Console.WriteLine(input + dict[input]);
                    }
                    else if (!dict.ContainsKey(input))
                    {
                        Console.WriteLine("Хочешь что-то добавить? да - 1, нет - 2");
                        answer = int.Parse(Console.ReadLine());
                        if (answer == 1)
                        {
                            Console.WriteLine("Набери новую страну");
                            string new1 = Console.ReadLine();

                            Console.WriteLine("Набери новую столицу");
                            string new2 = Console.ReadLine();
                            dict.Add(new1, new2);
                            dict.Add(new2, new1);
                        }
                    }
                }
                else if (answer == 2)
                {
                    score = 0;
                    for (int i = 0; i < country.Count; i++)
                    {
                        randInt = rnd.Next(1, 3);
                        int b = rnd.Next(1, country.Count);
                        if (randInt == 1)
                        {
                            Console.WriteLine("Это - " + country[b]);
                            string userInput = Console.ReadLine();
                            if (capital.IndexOf(userInput) == country.IndexOf(country[b]))
                            {
                                Console.WriteLine("Красава");
                                score++;
                            }
                        }
                        else if (randInt == 2)
                        {
                            Console.WriteLine("Это - " + capital[b]);
                            string userInput = Console.ReadLine();
                            if (country.IndexOf(userInput) == capital.IndexOf(capital[b]))
                            {
                                Console.WriteLine("Красава");
                                score++;
                            }
                        }
                    }
                    Console.WriteLine(score / country.Count * 100 + "%");
                }
            }
        }
