using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace serialize
{
    public class Dataluufile
    {
        public static bool luufile(List<sinhvien> dssv, string path )
        {
            try
            {
                FileStream fs = new FileStream( path, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dssv);
                fs.Close();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<sinhvien> Docfile(string path)
        {
            List<sinhvien> dssv = new List<sinhvien>();
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            object data = bf.Deserialize(fs);
            dssv = data as List<sinhvien>;
            fs.Close();
            return dssv;
        }
    }
}
