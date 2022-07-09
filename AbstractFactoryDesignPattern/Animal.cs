using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public interface Animal
    {
        string Speak();
    }




    public class Cat : Animal
    {
        public string Speak()
        {
            return "Meow meow meow";
        }
    }
    public class Lion : Animal
    {
        public string Speak()
        {
            return "Roar";
        }
    }
    public class Dog : Animal
    {
        public string Speak()
        {
            return "Bark bark";
        }
    }

    public class Octopus : Animal
    {
        public string Speak()
        {
            return "SQAWCK";
        }
    }

    public class Shark : Animal
    {
        public string Speak()
        {
            return "Can not speak";
        }
    }
}
