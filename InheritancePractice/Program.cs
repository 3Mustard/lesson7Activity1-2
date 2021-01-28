using System;
namespace Problem1
{
    public class Animal
    {
        public virtual string GiveBirth()
        {
            return "I don't know how";
        }
    }

    public class Mammal : Animal
    {
        public override string GiveBirth()
        {
            return "I give live birth";
        }
    }

    public class Bird : Animal
    {
        public override string GiveBirth()
        {
            return "I lay eggs";
        }
    }
}

namespace Problem2
{
    public class Animal
    {
        public string name { set; get; }
        public string birthMethod { set; get; }

        public Animal()
        {
            this.name = "";
            this.birthMethod = "";
        }

        public Animal(string name, string birthMethod)
        {
            this.name = name;
            this.birthMethod = birthMethod;
        }

        public string GiveBirth()
        {
            return this.birthMethod;
        }
    }

    public class Bird : Animal
    {
        bool flies;

        public Bird() : base()
        {
            this.flies = true;
        }

        public Bird(string name, bool flies)
            : base(name, "eggs")
        {
            this.flies = flies;
        }
    }
}