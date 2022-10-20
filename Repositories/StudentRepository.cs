using MauiApp1.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Repositories
{
    public class StudentRepository
    {
        private readonly SQLiteConnection _connection;

        public StudentRepository()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Student.db");
            this._connection = new SQLiteConnection(path);
        }

        public List<Student> list()
        {
            return _connection.Table<Student>().ToList();
        }

        public int create(Student student)
        {
            return _connection.Insert(student);
        }

    }
}
