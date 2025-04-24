using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WındowsFormOdeb.Business
{

    public class Havale : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $" {tutar:C} havale yöntemi ile tahsil edildi.";
        }
    }
}

