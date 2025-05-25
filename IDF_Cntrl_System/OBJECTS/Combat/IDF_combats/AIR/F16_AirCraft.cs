using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Cntrl_System.OBJECTS.Combat.IDF_combats.AIR
{
    internal class F16_AirCraft : ACombat
    {
        public F16_AirCraft(List<string> bombType, List<string> efficientVS, string activatedBy) : base(bombType, efficientVS, activatedBy) { }
    }
}
