using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Cntrl_System.Menu;
using IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj;
using IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj.Units;
using IDF_Cntrl_System.OBJECTS.Person;
using IDF_Cntrl_System.OBJECTS.Weapons;


namespace IDF_Cntrl_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soldier sldr1 = new Soldier("david", 20, new amm, "turai", 908, new List<WeaponTypes> { WeaponTypes.Shell})
            //IDF idf = new IDF("1948", );
            MenuMannager.Run();
        }
    }
}
