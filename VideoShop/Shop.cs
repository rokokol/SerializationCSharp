using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoShop
{
    [Serializable]
    public class Shop
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public uint Rating { get; set; }
        public readonly List<Good> Goods = new List<Good>();
        public readonly List<Worker> Workers = new List<Worker>();

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

        public override string ToString()
        {
            return $"{nameof(Goods).ToArray()}: {Goods}, {nameof(Workers)}: {Workers.ToArray()}," +
                   $" {nameof(Name)}: {Name}, {nameof(Price)}: {Price}, {nameof(Rating)}: {Rating}";
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

        public Shop(string name, decimal price, uint rating)
        {
            Name = name;
            Price = price > 0 ? price : 1000000;
            Rating = rating;
        }
        
        public Shop()
        {
        }
    }
}