namespace RoadLibrary
{
    // Базовый класс Дорожные работы
    public class RoadWorks
    {
        public double _width;     // ширина дороги (м)
        public double _length;     // длина (м)
        public double _massPerSqM;  // масса дорожного покрытия на 1 кв.м (кг)

        // Статический список объектов класса
        public static List<RoadWorks> Works = new List<RoadWorks>();

        // Конструктор
        public RoadWorks(double width, double length, double massPerSqM)
        {
            _width = width;
            _length = length;
            _massPerSqM = massPerSqM;
        }

        // Функция качества Q
        public virtual double CalculateQ()
        {
            return _width * _length * _massPerSqM / 1000;
        }

        // Метод вывода информации
        public virtual string GetInfo()
        {
            return $"Дорожные работы: Ширина={_width}м, Длина={_length}м, Масса/кв.м={_massPerSqM}кг, Q={CalculateQ():F2}";
        }

        // Метод удаления нескольких объектов из списка
        public static void RemoveWorks(List<RoadWorks> worksToRemove)
        {
            Works = Works.Except(worksToRemove).ToList();
        }
    }
}
