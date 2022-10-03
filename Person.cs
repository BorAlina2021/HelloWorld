using System;

namespace HelloWorld
{
    public class Person
    {
        public int _age;
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
        public void SetAge(int n)
        {
            _age = n;
        }
    }
}
