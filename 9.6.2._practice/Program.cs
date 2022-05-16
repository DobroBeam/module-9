// Задание 2
// 1.   Создайте консольное приложение, в котором будет происходить сортировка списка фамилий из пяти человек.
//      Сортировка должна происходить при помощи события. Сортировка происходит при введении пользователем либо числа 1 (сортировка А-Я),
//      либо числа 2 (сортировка Я-А).

// 2.   Дополнительно реализуйте проверку введённых данных от пользователя через конструкцию TryCatchFinally с использованием собственного типа исключения.

string[] list = new string[] { "Иванов", "Петров", "Сидоров", "Александров", "Абрамов" };
Sort sort = new Sort(list);
sort.ModeChoosenEvent += ShowList;

while(true)
{
    try
    {
        sort.ModeChoose();
    }
    catch (FormatException)
    {
        Console.WriteLine("Введено некорректное значение");
    }
}

void ShowList(int number)
{
    switch(number)
    {
        case 1: sort.SortAZ(); break;
        case 2: sort.SortZA(); break;     
    }
}

class Sort
{
    string[] list;

    public Sort(string[] list)
    {
        this.list = list;
    }

    public delegate void SortModeDelegate(int number);
    public event SortModeDelegate ModeChoosenEvent;
    protected void ModeChoosen(int number)
    {
        ModeChoosenEvent?.Invoke(number);
    }
    public void ModeChoose()
    {
        Console.WriteLine("\nСортировка списка: \n\t 1 - сортировка А - Я \n\t 2 - сортировка Я - А");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number != 1 && number != 2) throw new FormatException();
        ModeChoosen(number);
    }
    public void SortAZ()
    {
        Console.WriteLine("Сортировка А - Я:");        
        IEnumerable<string> query = from word in list
                                    orderby word.Substring(0, word.Length)
                                    select word;
        foreach (string str in query)
            Console.WriteLine(str);
    }
    public void SortZA()
    {
        Console.WriteLine("Сортировка Я - А:");
        IEnumerable<string> query = from word in list
                                    orderby word.Substring(0, word.Length) descending
                                    select word;
        foreach (string str in query)
            Console.WriteLine(str);
    }
}