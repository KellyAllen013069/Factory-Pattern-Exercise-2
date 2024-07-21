namespace FactoryPatternExercise2;

public class DynamoData : IDataAccess
{
    public void GetData()
    {
        Console.WriteLine("Getting data from DynamoDb");
    }
}