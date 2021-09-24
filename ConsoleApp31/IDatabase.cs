using System.Collections.Generic;

namespace ConsoleApp31
{
    internal interface IDatabase
    {
        List<Student> Students { get; }

        void AddStudent(Student s);
        Student GetStudentById(string id);
    }
}