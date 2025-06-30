namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new StudentManager();

            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Добавить нового студента");
                Console.WriteLine("2. Просмотреть всех студентов (по возрастанию среднего балла)");
                Console.WriteLine("3. Просмотреть всех студентов (по убыванию среднего балла)");
                Console.WriteLine("4. Выйти");
                Console.Write("Выберите действие: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewStudent(manager);
                        break;
                    case "2":
                        manager.DisplayStudents(manager.GetSortedStudents(true));
                        break;
                    case "3":
                        manager.DisplayStudents(manager.GetSortedStudents(false));
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Неверный ввод. Попробуйте снова.");
                        break;
                }
            }
        }

        static void AddNewStudent(StudentManager manager)
        {
            try
            {
                Console.Write("Введите ФИО студента: ");
                var fullName = Console.ReadLine().Trim();
                if (string.IsNullOrWhiteSpace(fullName))
                {
                    Console.WriteLine("ФИО не может быть пустым!");
                    return;
                }

                Console.Write("Введите наименование специальности: ");
                var specialty = Console.ReadLine().Trim();
                if (string.IsNullOrWhiteSpace(specialty))
                {
                    Console.WriteLine("Специальность не может быть пустой!");
                    return;
                }

                Console.Write("Введите номер группы: ");
                var groupNumber = Console.ReadLine().Trim();
                if (string.IsNullOrWhiteSpace(groupNumber))
                {
                    Console.WriteLine("Номер группы не может быть пустым!");
                    return;
                }

                Console.Write("Введите средний балл успеваемости (от 1 до 5): ");
                if (!double.TryParse(Console.ReadLine(), out double averageScore))
                {
                    Console.WriteLine("Ошибка ввода среднего балла. Должно быть число.");
                    return;
                }

                var student = new Student(fullName, specialty, groupNumber, averageScore);
                manager.AddStudent(student);
                Console.WriteLine("Студент успешно добавлен!");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }
        }
    }
}