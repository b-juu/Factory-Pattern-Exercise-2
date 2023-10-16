using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("Reading data from List...");
            return new List<Product>();
        }

        public void SaveData(List<Product> data)
        {
            Console.WriteLine("Saving data to a List database...");
        }
    }
}
