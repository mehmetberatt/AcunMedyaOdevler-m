using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WındowsFormOdeb.Business
{
    public class KrediKarti : IOdemeYontemi
    {
        public string Ode(decimal tutar) =>
            $"💳 {tutar:C} kredi kartı ile tahsil edildi.";
    }
}
