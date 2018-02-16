using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_Работа__8
{
    [Serializable]
    public class AverageTemp
    {
        public AverageTemp(int numDay, double temp)
        {
            NumDay = numDay;
            Temperature = temp;
        }

        public int NumDay { get; set; }
        public double Temperature { get; set; }

        public bool Deleted { get; set; }

        public override string ToString()
        {
            return string.Format("День: {0}, Температура: {1}", NumDay, Temperature);
        }

    }
}
