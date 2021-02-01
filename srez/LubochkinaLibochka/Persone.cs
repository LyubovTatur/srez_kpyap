using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LubochkinaLibochka
{[Serializable]
    public class Persone
    {
        public string name { get; set; }
        public int age { get; set; }
        public int weight { get; set; }
        public int height { get; set; }

        public Persone()
        {
        }

        public Persone(string name, int age, int weight, int height)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.height = height;
        }

        public override string ToString()
        {
            return $"{name}, {age} лет, вес {weight}кг, рост {height}см.";
        }
    }
}
