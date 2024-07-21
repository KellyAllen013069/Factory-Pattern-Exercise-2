namespace FactoryPatternExercise2;

public static class DataAccess
{
    public static IDataAccess? GetDbType()
    {
        Console.WriteLine("Which database? Please enter 1 for SQL and 2 for DynamoDb.");
        var isInt = int.TryParse(Console.ReadLine(), out int type);
        if (!isInt || (type != 1 && type != 2 ))
        {
            Console.WriteLine("Invalid input entered. Please try again.");
            return null;
        }
        if (type == 1) return new SqlData();
        return new DynamoData();
    }
}