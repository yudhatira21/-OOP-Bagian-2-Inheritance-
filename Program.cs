using System;

namespace LatihanInheritanceReal
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Yudha", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Euy", 11, 18098, "Seterah");
            teacher.GetNameAndAge();

            Student student = new Student("Jarwo", 21, 14356, "Jarwo@gmail.com");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}
