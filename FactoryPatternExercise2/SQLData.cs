namespace FactoryPatternExercise2;

public class SqlData : IDataAccess
{
    public void GetData()
    {
        Console.WriteLine("Getting data from SQL");
    }
}