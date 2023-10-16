namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the database type (list, sql, or mongo): ");
            string databaseType = Console.ReadLine();

            IDataAccess dataAccess = DataAccessFactory.GetDataAccessType(databaseType);

            List<Product> data = dataAccess.LoadData();
            dataAccess.SaveData(data);
        }
    }
}
