using System;
using System.Collections.Generic;

namespace _04_BreadthFirstSearch
{
    class BreathFirstSearch
    {
        public static void Search(Friend rootNode)
        {
            Queue<Friend> traitors = new Queue<Friend>();
            rootNode.FriendList?.ForEach(traitors.Enqueue);

            List<Friend> used = new List<Friend>();

            while (traitors.Count > 0)
            {
                Friend person = traitors.Dequeue();
                Console.WriteLine($"\nПроверяется {person}:\n");
                if (!used.Contains(person))
                {
                    if (person.IsSeller) 
                    {
                        Console.WriteLine($"Найден продавец! Его имя: {person}!");
                        break;
                    }
                    else
                    {
                        used.Add(person);
                        person.FriendList?.ForEach(traitors.Enqueue);
                        Console.WriteLine($"Не, {person} не торгует.");
                    }
                }
                else Console.WriteLine("Не, уже проверяли! По второму разу что ли всех проверять будем? Дурак что ли?");
            }
        }
    }
}
