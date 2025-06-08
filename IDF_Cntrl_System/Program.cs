using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Cntrl_System.Menu;
using IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj;
using IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj.Units.Intelligence;
using IDF_Cntrl_System.OBJECTS.Person;
using IDF_Cntrl_System.OBJECTS.Weapons;
using IDF_Cntrl_System.DataBase;


namespace IDF_Cntrl_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soldier sldr1 = new Soldier("david", 20, "turai", 908, new List<WeaponTypes> { WeaponTypes.Shell });
            Terrorist trrst = new Terrorist("s", 22, "ww", 21, new List<WeaponTypes> { WeaponTypes.Knife }, 21, StructureType.Car, 32, true);
            TempDB.TerroristMSG_op13.Add(trrst, new List<IntelMessege> { new IntelMessege(trrst,5)});


            MenuMannager.Run();
        }
    }
}
