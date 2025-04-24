using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WındowsFormOdeb.Business
{
    public class EFT : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"{tutar:C} EFT ile tahsil edildi.";
        }
    }
}

