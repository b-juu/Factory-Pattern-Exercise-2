using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("Reading data from SQL database...");
            return new List<Product>();
        }

        public void SaveData(List<Product> data)
        {
            Console.WriteLine("Saving data to an SQL database...");
        }
    }
}
