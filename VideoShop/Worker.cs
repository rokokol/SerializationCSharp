using System;

namespace VideoShop
{
    [Serializable]
    public class Worker
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public uint Iq { get; set; } 
        public bool IsSingle { get; set; }

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

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Salary)}: {Salary}, {nameof(Iq)}: {Iq}, {nameof(IsSingle)}: {IsSingle}";
        }

        public Worker(string name, decimal salary, uint iq, bool isSingle)
        {
            Name = name;
            Salary = salary > 0 ? salary : 10;
            Iq = iq;
            IsSingle = isSingle;
        }

        public Worker()
        {
        }
    }
}