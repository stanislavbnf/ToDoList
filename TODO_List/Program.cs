using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        Console.WriteLine("Добро пожаловать в ТУДУЛИСТ");
        List<string> TODOLIST = new List<string>();
        string vvod = "";


        while (vvod != "4")
        {
            Console.WriteLine('\n' + "Список дел:");
            Console.WriteLine("Нажмите 1 чтобы добавить задачу");
            Console.WriteLine("Нажмите 2 чтобы удалить задачу");
            Console.WriteLine("Нажмите 3 для просмотра списка задач");
            Console.WriteLine("Нажмите 4 для выхода");
            vvod = Console.ReadLine();

            if (vvod == "1")
            {
                Console.WriteLine("");
                string zadacha = Console.ReadLine();
                TODOLIST.Add(zadacha);
                Console.Clear();
                Console.WriteLine("Задача добавлена") ;
            }

            else if (vvod == "2")
            {
                for (int i = 0; i < TODOLIST.Count; i++)
                {
                    Console.WriteLine(i + " : " + TODOLIST[i]);
                }
                Console.WriteLine("Введите номер задачи для удаления");
                int TODONUMBER = Convert.ToInt32(Console.ReadLine());
                TODOLIST.RemoveAt(TODONUMBER);
                Console.Clear();
                Console.WriteLine("Задача удалена");

            }
            else if (vvod == "3")
            {
                Console.WriteLine("Текущие задачи");
                for (int i = 0; i < TODOLIST.Count; i++)
                {
                    Console.WriteLine(TODOLIST[i]);
                }

            }
            else if (vvod == "4")
            {
                Console.Clear();
                Console.WriteLine("Программа Заверешена");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Неверный выбор");
            }
            


            // Выводим список задач
            // Выводим меню           
            // Считываем выбор пользователя           
            // Обрабатываем выбор пользовател                        
            // 1. Добавить задачу
            // Считываем задачу
            // Добавляем задачу                     
            // 2. Удалить задачу
            // Считываем номер задачи
            // Удаляем задачу
            // Если ввод некорректный, выводим сообщение об ошибке                
            // 3. Выход
            // Выходим из программы               
            // Ввод за пределами меню
            // Выводим сообщение об ошибке
        }
        Console.WriteLine("Спасибо за использование программы");
    }
}