using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06._01
{
    public class Earth : IPlanet
    {
        public string ReportAboutMovement() => "Земля обертається навколо Сонця";
        public string ReportAboutLife() => "На Землі є життя";
    }


}
