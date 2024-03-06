using System;

namespace VideoShop
{
    [Serializable]
    public class Worker
    {
        public string Name { get; private set; }

        public void Eat()
        {
            void Choke()
            {
                Console.WriteLine("Dead");
            }

            if (Name == "Vasya")
            {
                Choke();
            }
            Console.WriteLine("Yum");
        }

        public void Blink()
        {
            Console.WriteLine("Blinking");
        }

        public void Think()
        {
            Console.WriteLine("Hmmmmmmm...");
        }

        public string Talk()
        {
            void Yawn()
            {
                Console.WriteLine("YAWNNNNNNNNN");
            }

            if (Name == "Vasya")
            {
                Yawn();
            }
            return Name;
        }
        
        public Worker(string name)
        {
            Name = name;
        }
    }
}