using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarHub.Estrutura.Model
{
    public class Bateria
    {
        public double Capacidade { get; set; }
        public double EnergiaArmazenada { get; set; }
        public bool Ligado { get; set; }
    }
}
