Exception exception = new Exception("Произошло исключение");
exception.Data.Add("Дата создания исключения: ", Convert.ToString(DateOnly.FromDateTime(DateTime.Now)));
exception.HelpLink = "dsdfs";
Console.ReadKey();