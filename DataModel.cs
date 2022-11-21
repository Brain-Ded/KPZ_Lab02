using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_Lab02.Model
{
    public class DataModel
    {
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }

        public static string DataPath = @"E:\\Visual Studio Projects\\KPZ_Lab02.Model\\EducationalData.dat";

        public static DataModel Load()
        {
            if (File.Exists(DataPath))
            {
                return DataSerializer.DeserializeData(DataPath);
            }
            return new DataModel();
        }
        public void Save()
        {
            DataSerializer.SerializeData(DataPath, this);
        }
    }
}
