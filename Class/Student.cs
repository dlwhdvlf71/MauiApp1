using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Class
{
    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public static IEnumerable All
        {
            get; private set;
        }

        static Student()
        {
            All = new List<Student>()
            {
                new Student() { Name = "홍길동1", Age = 29, Gender = "M" }
                , new Student() { Name = "홍길동2", Age = 22, Gender = "W" }
                , new Student() { Name = "홍길동3", Age = 18, Gender = "M" }
                , new Student() { Name = "홍길동4", Age = 18, Gender = "M" }
                , new Student() { Name = "홍길동5", Age = 18, Gender = "M" }
                , new Student() { Name = "홍길동6", Age = 18, Gender = "W" }
                , new Student() { Name = "홍길동7", Age = 18, Gender = "M" }
                , new Student() { Name = "홍길동8", Age = 18, Gender = "M" }
                , new Student() { Name = "홍길동9", Age = 18, Gender = "W" }
                , new Student() { Name = "홍길동10", Age = 18, Gender = "W" }
                , new Student() { Name = "홍길동11", Age = 18, Gender = "M" }
            };
        }
    }
}
