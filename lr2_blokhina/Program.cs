using System;

namespace RectangleApp
{
    class Rectangle
    {
        // Закрытые поля для хранения данных о высоте и ширине
        private double height;
        private double width;

        // Свойства для работы с закрытыми полями
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        // Конструктор для создания объектов
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        // Метод для показа данных о прямоугольнике
        public void ShowInfo()
        {
            Console.WriteLine($"Высота: {Height}, Ширина: {Width}");
        }

        // Метод, который рассчитывает и возвращает значение периметра
        public double Perimeter()
        {
            return 2 * height + 2 * width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта класса Rectangle
            Rectangle rectangle = new Rectangle(2, 3);

            // Вывод данных объекта на экран
            rectangle.ShowInfo();

            // Рассчет периметра прямоугольника и вывод его на экран
            double perimeter = rectangle.Perimeter();
            Console.WriteLine($"Периметр прямоугольника: {perimeter}");
        }
    }
}
