try
{
    throw new ArgumentOutOfRangeException();
    
}
catch(Exception ex) when (ex is ArgumentOutOfRangeException)
{
    Console.WriteLine("Аргумент за пределами");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    throw new RankException();

}
catch (Exception ex) 
{
    Console.WriteLine(ex.GetType());
}


