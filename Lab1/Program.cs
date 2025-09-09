namespace Task
{
    public class Program
    {
        private static List<ColoredPoint> colorPoints = [];
        private static List<PolyLine> polyLines = [];
        private static List<LineWithColor> lineWithColors = [];
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Выбрать меню точек");
                Console.WriteLine("2. Выбрать меню линий");
                Console.WriteLine("3. Выбрать меню многоугольников");
                string? choice;
                choice = Console.ReadLine();
                if(choice != "1" || choice != "2" || choice != "3")
                {
                    Console.WriteLine("Неверный выбор");
                }
                else
                {
                    switch (choice) { 
                        case "1":
                            Console.WriteLine();
                            Points();
                            break;
                        case "2":
                            Console.WriteLine();

                            break;

                        case "3":
                            Console.WriteLine();

                            break;
                    }
                }
            }
        }
        public static void Points()
        {
            while (true)
            {
                Console.WriteLine("Кол-во точек: " + colorPoints.Count.ToString());
                Console.WriteLine("1. Вывод всех точек");
                Console.WriteLine("2. Добавить точку");
                Console.WriteLine("3. Удалить точку");
                Console.WriteLine("4. Изменить точку");
                string? choice;
                choice = Console.ReadLine();

            }
        }
    }
}