using System.Collections.Generic;
using System;

   

interface IGameStrategy
{
    void Play();
}
namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>()
        {
            new Team("Россия"),
            new Team("Франция"),
            new Team("Китай"),
            new Team("Казахстан")
        };
            Tournament t = new Tournament();
            t.Start(teams);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
