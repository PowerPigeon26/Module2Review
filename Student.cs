using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Review
{
    public class Student
    {
        public string Name { get; set; } = "";
        public int ID { get; set; }
        public List<double> Grades { get; set; } = new List<double>();

        public Student() { }

        public Student(string name, int iD)
        {
            Name = name;
            ID = iD;
        }

        // not sure why instructions say all methods will be static, I'm not sure how the methods would work in that case,
        // not without changing the methods to take in a instance of student and modify it. I choose to use non-static methods.
        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades);
        }

        public double CalculateAverageGrade()
        {
            if (Grades.Count == 0) return 0;
            else return Grades.Average();
        }

    }
}
