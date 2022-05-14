/*
    //Задание 9.3.2
    //Создайте консольное приложение, в котором есть функция, принимающая на вход два числа int,
    //и возвращающая результат int вычитания второго числа из первого. Вызовите эту функцию в классе Main
    //при помощи делегата и отобразите результат в консольном сообщении.

    //Задание 9.3.3
    //используя ваше приложение из задания 9.3.2, реализуйте вызов делегата двумя разными способами.
    int a1 = 10;
    int b1 = 20;

    CalcDelegate calcDelegate = Calc;
    Console.WriteLine($"Вызов делегата 1ым способом {calcDelegate(a1, b1)}");    
    Console.WriteLine($"Вызов делегата 2ым способом {calcDelegate.Invoke(a1, b1)}");

    Console.WriteLine(Calc2(a1, b1));

    static int Calc (int a, int b)
    {
        return b-a;
    }
    static int Calc2(int a, int b)
    {
        return b - a + 1;
    }

    public delegate int CalcDelegate(int a, int b);
*/

/*
    //Задание 9.3.4
    //Реализуйте консольное приложение, в котором существует две функции: первая функция вычитает второе число из первого
    //и отображает результат в консольном сообщении, вторая функция складывает два числа и отображает результат в консоли.
    //Реализуйте вызов этих двух функций через многоадресный делегат.

    int a2 = 20;
    int b2 = 30;
    int a3 = 5;
    int b3 = 6;

    Action action = Function1;
    action += Function2;
    action.Invoke(a2,b2);
    Console.WriteLine("------");
    action.Invoke(b2, a2);
    Console.WriteLine("------");
    Action action2 = Function2;
    Action action3 = action + action2;
    action3.Invoke(a3,b3);



    static void Function1 (int a, int b)
    {
        int result = b - a;
        Console.WriteLine (result);
    }

    static void Function2(int a, int b)
    {
        int result = a + b;
        Console.WriteLine(result);
    }
    public delegate void Action(int a, int b);
*/

/*
    //Задание 9.3.8
    //Используя консольное решение из предыдущей задачи 9.3.7, реализуйте применение шаблонных делегатов

    Action showMessageDelegate = ShowMessage;
    showMessageDelegate.Invoke();

    Func<int,int,int,int> sumDelegate = Sum;
    int result = sumDelegate.Invoke(1, 30, 120);
    Console.WriteLine(result);

    Predicate<string> checkLengthDelegate = CheckLength;
    bool status = checkLengthDelegate.Invoke("skill_factory");
    Console.WriteLine(status);

    Console.ReadLine();

      static void ShowMessage()
    {
        Console.WriteLine("Hello World!");
    }

    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    static bool CheckLength(string _row)
    {
        if (_row.Length > 3) return true;
        return false;
    }
    // при применении шаблонных делегатов в кода прописывать свои делегаты НЕ нужно:

        delegate void ShowMessageDelegate();
        delegate int SumDelegate(int a, int b, int c);
        delegate bool CheckLengthDelegate(string row);
*/

/*
// Задание 9.3.12
// Существует следующее консольное решение, которое отображает сообщение Hello World в консольном сообщении.
// Реализуйте в данном решении анонимный метод, не сломав логику приложения.

namespace DelegatePractices
{
    class Program
    {
        delegate void ShowMessageDelegate(string _message);
        static void Main(string[] args)
        {
            ShowMessageDelegate showMessageDelegate = delegate (string text)
            { Console.WriteLine(text); };
            showMessageDelegate.Invoke("Hello World!");
            Console.Read();
        }
    }
}
*/


// Задание 9.3.13
// Существует консольное решение, которое выводит случайное целое число в диапазоне от 0 до 100 и
// отображает результат в консольное сообщение.
// Реализуйте в данном решении анонимный метод, не сломав логику приложения.
namespace DelegatePractices2
{
    class Program
    {
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            RandomNumberDelegate randomNumberDelegate = delegate()
            {
                return new Random().Next(0, 100);
            };
            Console.WriteLine(randomNumberDelegate.Invoke());
            Console.Read();
        }
    }
}