// Задание 1
// 1. Создайте свой тип исключения.
// 2. Сделайте массив из пяти различных видов исключений, включая собственный тип исключения.
// Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения (блок finally по желанию).
// 3. В блоке catch выведите в консольном сообщении текст исключения.

using _9._6._1_practice;

List<Exception> exceptions = new List<Exception> ();
exceptions.Add(new MyException("Произошло особое исключение"));
exceptions.Add(new ArgumentException());
exceptions.Add(new DivideByZeroException());
exceptions.Add(new FileNotFoundException());
exceptions.Add(new FormatException());
foreach (Exception ex in exceptions)
{
    try
    {
            throw ex;           
    }
    catch (Exception e) when (e is MyException)
    {
        Console.WriteLine(e.Message);
    }
    catch (Exception e) when (e is ArgumentException)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception e) when (e is DivideByZeroException)
    {
        Console.WriteLine(e.Message);
    }
    catch (Exception e) when (e is FileNotFoundException)
    {
        Console.WriteLine(e.Message);
    }
    catch (Exception e) when (e is FormatException)
    {
        Console.WriteLine(e.Message);
    }
    Console.WriteLine("Enter, чтобы продолжить");
    Console.ReadLine();
    continue;
}







