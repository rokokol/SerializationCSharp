using System;

namespace VideoShop
{
    [Serializable]
    public class Good
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public uint Rating { get; private set; }

        public void Do()
        {
            void Break()
            {
                Console.WriteLine(":(");
            }

            if (Rating > 1)
            {
                Console.WriteLine("Doing");
            }
            else
            {
                Break();
            }
        }
        
        public void Exsist()
        {
            void Crumble()
            {
                Console.WriteLine(":(((((");
            }

            if (Rating > 1)
            {
                Console.WriteLine("Existing");
            }
            else
            {
                Crumble();
            }
        }

        public Good(string name, decimal price, uint rating)
        {
            Name = name;
            if (price > 0)
            {
                Price = price;
            }
            else
            {
                Price = 100m;
            }
            
            if (rating > 0 && rating <= 5)
            {
                Rating = rating;
            }
            else
            {
                Rating = 2;
            }
        }
    }
}