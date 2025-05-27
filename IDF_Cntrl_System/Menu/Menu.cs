using IDF_Cntrl_System.OBJECTS.Person;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Cntrl_System.OBJECTS.Unit;
using IDF_Cntrl_System.OBJECTS.ArmyOrganizations;
using IDF_Cntrl_System.OBJECTS.Combat;
using IDF_Cntrl_System.OBJECTS.Weapons;
using IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj;
using IDF_Cntrl_System.OBJECTS.ArmyOrganizations.HAMMASobj;
using IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj.Units.Intelligence;


namespace IDF_Cntrl_System.Menu
{
    static class DB
    {
        static List<Terrorist> RandomTerrorist { get; }
        public static Dictionary<Terrorist, List<IntelMessege>> TerroristMSG { get; }
        public static List<AUnit> UnitsLst { get; }
    }
}