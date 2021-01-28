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