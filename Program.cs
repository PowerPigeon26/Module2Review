namespace Module2Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student stacy = new Student("Stacy", 1);
            students.Add(stacy);
            stacy.AddGrade(100.0);
            stacy.AddGrade(100.0, 100.0, 89.0);

            Student lucy = new Student("Lucy", 2);
            students.Add(lucy);
            lucy.AddGrade(65);
            lucy.AddGrade(60, 75, 72);

            Student baxter = new Student("Baxter", 3);
            students.Add(baxter);
            baxter.AddGrade(90);
            baxter.AddGrade(85, 70, 85);

            Student vertin = new Student("Vertin", 4);
            students.Add(vertin);
            vertin.AddGrade(100);
            vertin.AddGrade(100, 100, 0);

            // used string concatenation rather than string interpolation
            Console.WriteLine("---------------------------------------------------------------------------");
            foreach (Student student in students)
            {
                Console.WriteLine("Name: " + student.Name);
                Console.WriteLine("ID: " + student.ID);
                Console.Write("Grades: ");
                foreach (double grade in student.Grades)
                {
                    Console.Write(grade + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Average grade: " + student.CalculateAverageGrade());
                Console.WriteLine("---------------------------------------------------------------------------");
            }

        }
    }
}
