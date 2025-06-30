namespace RoadLibrary
{
    // Класс-потомок
    public class ExtendedRoadWork : RoadWorks
    {
        public int _p; // номер месяца (0 < P ≤ 12)

        // Конструктор
        public ExtendedRoadWork(double width, double length, double massPerSqM, int p)
            : base(width, length, massPerSqM)
        {
            _p = p;
        }

        // Перекрытая функция качества Qp
        public override double CalculateQ()
        {
            double baseQ = base.CalculateQ();

            if (_p >= 5 && _p <= 8)
                return baseQ * 1.1;
            else if (_p == 3 || _p == 4 || _p == 9 || _p == 10)
                return baseQ * 1.6;
            else
                return baseQ * 2.1 + _p * 10;
        }

        // Перекрытый метод вывода информации
        public override string GetInfo()
        {
            return $"Дорожные работы (расширенные): Ширина={_width}м, Длина={_length}м, Масса/кв.м={_massPerSqM}кг, Месяц={_p}, Qp={CalculateQ():F2}";
        }
    }
}
