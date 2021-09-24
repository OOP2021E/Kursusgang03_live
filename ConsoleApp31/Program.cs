using System;
using System.Collections.Generic;

namespace ConsoleApp31
{

    class ConstantDb : IDatabase
    {
        public List<Student> Students { get; } = new List<Student>() { new Student("Thomas", "20212020") };

        public void AddStudent(Student s)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentById(string id)
        {
            throw new NotImplementedException();
        }
    }


    class CloudDb : IDatabase
    {
        public List<Student> Students { get; }

        public void AddStudent(Student s)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentById(string id)
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger l = new ConsoleLogger();

            StudentManagerApp app = new StudentManagerApp(l, new CloudDb()) ;
            app.Start();
        }
    }
}
