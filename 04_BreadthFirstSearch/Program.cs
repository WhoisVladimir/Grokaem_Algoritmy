using System;
using System.Collections.Generic;

namespace _04_BreadthFirstSearch
{
    class Program
    {
        // За основу реализации алгоритма взят пример из книги: 
        // среди списка своих друзей на фейсбуке мы ищем продавца (ничего нелегального).
        // Если среди наших друзей никто не торгует, то пробиваем по их друзьям.
        static void Main(string[] args)
        {
            Friend you = new Friend("Ю", false);
            Friend sveta = new Friend("Света", false);
            Friend kostya = new Friend("Костя", false);
            Friend lesha = new Friend("Лёша", false);
            Friend masha = new Friend("Маша", false);
            Friend jenya = new Friend("Женя", false);
            Friend nastya = new Friend("Настя", false);
            Friend andrusha = new Friend("Андрюша", false);
            Friend olya = new Friend("Оля", false);
            Friend tanya = new Friend("Таня", false);
            Friend mansur = new Friend("Мансур", false);
            Friend stasik = new Friend("Стасик", true);

            you.AddFriends( new List<Friend> { sveta, kostya} );
            sveta.AddFriends(new List<Friend> { lesha, masha, olya });
            kostya.AddFriends(new List<Friend> { jenya, mansur, olya });
            olya.AddFriends(new List<Friend> { sveta, masha, nastya, tanya });
            jenya.AddFriends(new List<Friend> { kostya, andrusha, stasik });

            BreathFirstSearch.Search(you);

            Console.ReadLine();
        }
    }
}
