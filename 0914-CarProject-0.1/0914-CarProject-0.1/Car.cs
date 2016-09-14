using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0914_CarProject_0._1
{
    class Car
    {
        //Properties
        public string model { get; set; }
        public string regNumb { get; set; }
        public string propelant { get; set; }
        public string transmission { get; set; }
        public bool available { get; set; }
        public int seats { get; set; }
        public int doors { get; set; }
        public string baggageSpace { get; set; }
        //Override
        public override string ToString()
        {
            return model;
        }
    }
}
