using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LubochkinaLibochka
{
    static public class Loader
    {
        static public List<Persone> Load(string filename)
        {
            List<Persone> p = new List<Persone>();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                var temp = (Persone[])formatter.Deserialize(fs);

                foreach (var item in temp)
                {
                    p.Add(item);
                }
            }
            return p;
        }
        static public void Save(string filename, Persone[] saveList)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, saveList);
            }
        }
    }
}
