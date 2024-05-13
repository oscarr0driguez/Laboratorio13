using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio13
{
    public class Electronicos : Productos 
    {
        public string TiempoGarantia { set; get; }
        public string Voltaje { get; set;  }

    }
}
