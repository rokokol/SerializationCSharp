using System;

namespace VideoShop
{
    [Serializable]
    public class Good
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public uint Rating { get; set; }

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

        public override string ToString()
        {
            return $"{Name}: {Rating}/5 - {Price:2c}";  
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

        public Good()
        {
        }
    }
}