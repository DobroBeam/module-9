
HadlerMethod hadlerCar = CarHandler;
// ковариантность (делегату возвращающий базовый класс Car, передаем метод класса наследника возвращающий экземплял класса наследника Lexus)
HadlerMethod handlerLexus = LexusHandler;
// контровариантность (делегату принимающим на вход экземпляр класса наследника Lexus, передаем метод принимающий на вход экземпляр базового класса Car)
LexusInfo lexusInfo = GetCarInfo;
// передаем в метод GetCarInfo экземпляр классf Lexus (вместо Car)
lexusInfo.Invoke(new Lexus());

static Car CarHandler()
{
    return null;
}
static Lexus LexusHandler()
{
    return null;
}
static void GetCarInfo (Car c)
{
    Console.WriteLine(c.GetType());
}


public delegate Car HadlerMethod();
delegate void LexusInfo (Lexus lexus);
public class Car { }
public class Lexus : Car { }



