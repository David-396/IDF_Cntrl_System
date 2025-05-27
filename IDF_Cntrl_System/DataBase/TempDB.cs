using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj.Units.Intelligence;
using IDF_Cntrl_System.OBJECTS.Person;
using IDF_Cntrl_System.OBJECTS.Unit;

namespace IDF_Cntrl_System.DataBase
{
    static class TempDB
    {
        public static Dictionary<Terrorist, List<IntelMessege>> TerroristMSG_op13 { get; set; } = new Dictionary<Terrorist, List<IntelMessege>>();
        public static List<AUnit> IDFUnits_opt24 { get; set; } = new List<AUnit>();

    }
}
