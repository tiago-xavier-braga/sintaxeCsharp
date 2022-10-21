using System;

namespace studyClass{
    class Player{
        public int id;
        public string name;
        public int level;

        public void createObject(){
            Console.WriteLine($"Name: {name} Level:{level}");
        } 
    }
    class Program{
        static void Main(){
            Player p1 = new Player();
            p1.id = 1;
            p1.level = 12;
            p1.name = "Tiago";
            p1.createObject();
        }
    }
}