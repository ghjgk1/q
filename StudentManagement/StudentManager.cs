namespace StudentManagement
{
    public class StudentManager
    {
        private const string FilePath = "students.txt";

        public void AddStudent(Student student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));

            using (StreamWriter writer = File.AppendText(FilePath))
            {
                writer.WriteLine(student.ToString());
            }
        }

        public List<Student> GetAllStudents()
        {
            if (!File.Exists(FilePath))
                return new List<Student>();

            try
            {
                var lines = File.ReadAllLines(FilePath);
                return lines.Select(line =>
                {
                    try
                    {
                        return Student.FromString(line);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при чтении строки: {line}. Ошибка: {ex.Message}");
                        return null;
                    }
                }).Where(s => s != null).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
                return new List<Student>();
            }
        }

        public List<Student> GetSortedStudents(bool ascending = true)
        {
            var students = GetAllStudents();
            return ascending ?
                students.OrderBy(s => s.AverageScore).ToList() :
                students.OrderByDescending(s => s.AverageScore).ToList();
        }

        public void DisplayStudents(List<Student> students)
        {
            if (students == null || !students.Any())
            {
                Console.WriteLine("\nСписок студентов пуст.");
                return;
            }

            Console.WriteLine("\n{0,-25} {1,-20} {2,-10} {3,-10}", "ФИО", "Специальность", "Группа", "Средний балл");
            Console.WriteLine(new string('-', 70));

            foreach (var student in students)
            {
                Console.WriteLine("{0,-25} {1,-20} {2,-10} {3,-10}",
                    student.FullName, student.Specialty, student.GroupNumber, student.AverageScore);
            }
        }
    }
}
