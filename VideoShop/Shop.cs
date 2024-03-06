using System;
using System.Collections.Generic;

namespace VideoShop
{
    [Serializable]
    public class Shop
    {
        public string Name { get; private set; }
        public List<Good> Goods { get; }
        
        public List<Worker> Workers { get; }

        public void Open()
        {
            Console.WriteLine("Opened");
        }
        
        public void Close()
        {
            void Detonate()
            {
                Console.WriteLine("Destroyed");
            }

            if (Goods.Count == 0) Detonate();
            Console.WriteLine("Closed");
        }
        
        public void GoToLunch(uint time)
        {
            void Yum()
            {
                Console.WriteLine("Yum");
            }

            for (int i = 0; i < time; i++) Yum();
            foreach (var worker in Workers)
            {
                worker.Eat();
            }
            Console.WriteLine("Closed");
        }

        public Shop(string name, params Good[] goods)
        {
            Name = name;
            Goods = new List<Good>(goods);
            Workers = new List<Worker>();
        }
    }
}