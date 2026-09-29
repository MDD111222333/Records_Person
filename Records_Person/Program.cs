using System;

namespace Records_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Иван", 20);
            Person p2 = new Person("Иван", 20);
            Console.WriteLine($"new Person(\"Иван\", 20) == new Person(\"Иван\", 20): {p1 == p2}");

            Person pCopy = p1 with { Age = 21 };
            Console.WriteLine($"новый объект, Age == {pCopy.Age}; оригинал остался с Age == {p1.Age}");

            var (name, age) = p1;
            Console.WriteLine($"name = {name}, age = {age} (значения свойств)");

            PersonStruct personStruct = new PersonStruct("Иван", 20);
            personStruct.Age = 30;
            Console.WriteLine($"personStruct.Age = {personStruct.Age} (изменено напрямую)");
        }
    }
}