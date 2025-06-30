namespace StudentManagement
{
    public class Student
    {
        private double _averageScore;

        public string FullName { get; set; }
        public string Specialty { get; set; }
        public string GroupNumber { get; set; }

        public double AverageScore
        {
            get => _averageScore;
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Средний балл должен быть в диапазоне от 1 до 5");
                }
                _averageScore = value;
            }
        }

        public Student(string fullName, string specialty, string groupNumber, double averageScore)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("ФИО не может быть пустым", nameof(fullName));

            if (string.IsNullOrWhiteSpace(specialty))
                throw new ArgumentException("Специальность не может быть пустой", nameof(specialty));

            if (string.IsNullOrWhiteSpace(groupNumber))
                throw new ArgumentException("Номер группы не может быть пустым", nameof(groupNumber));

            FullName = fullName;
            Specialty = specialty;
            GroupNumber = groupNumber;
            AverageScore = averageScore;
        }

        public override string ToString()
        {
            return $"{FullName}|{Specialty}|{GroupNumber}|{AverageScore}";
        }

        public static Student FromString(string data)
        {
            var parts = data.Split('|');
            if (parts.Length != 4)
                throw new FormatException("Некорректный формат данных студента");

            return new Student(parts[0], parts[1], parts[2], double.Parse(parts[3]));
        }
    }
}
