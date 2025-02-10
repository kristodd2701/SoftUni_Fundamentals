﻿namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
            .Split()
            .Select(e => int.Parse(e))
            .OrderByDescending(e => e)
            .ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split();
                int element;

                switch (arguments[0])
                {
                    case "Insert":
                        {
                            element = int.Parse(arguments[1]);
                            int position = int.Parse(arguments[2]);
                            list.Insert(position, element);
                            break;
                        }
                    case "Delete":
                        element = int.Parse(arguments[1]);
                        for (int i = list.Count - 1; i >= 0; i--)
                        {
                            if (list[i] == element)
                            {
                                list.RemoveAt(i);
                            }
                        }

                        break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
