﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06._01
{
    public class Moon : IPlanet
    {
        public string ReportAboutMovement() => "Місяць обертається навколо Землі";
        public string ReportAboutLife() => "На Місяці немає життя";
    }


}
