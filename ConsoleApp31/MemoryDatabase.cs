using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp31
{

    interface ILogger
    {
        void Critical(string m);
    }
    class MemoryDatabase : IDatabase
    {

        public MemoryDatabase(ILogger logger)
        {
            this.Logger = logger;
        }
        ILogger Logger { get; }
        public Student GetStudentById(string id)
        {
            var result = Students.FirstOrDefault(v => v.Id == id);
            if (result == null)
                Logger.Critical("Student not found: " + id);
            return result;
        }

        public void AddStudent(Student s) => Students.Add(s);

        public List<Student> Students { get; } = new List<Student>();
    }
}
