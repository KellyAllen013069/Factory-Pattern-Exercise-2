namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var type = DataAccess.GetDbType();
            if (type != null) type.GetData();
        }
    }
}
