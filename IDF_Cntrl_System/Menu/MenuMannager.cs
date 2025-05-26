using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Cntrl_System.OBJECTS.Person;
using IDF_Cntrl_System.OBJECTS.Unit;

namespace IDF_Cntrl_System.Menu
{
    static class MenuMannager
    {
        static string option;

        static Terrorist most_report_terrorist_opt1 = null;

        static string GetOption()
        {
            return Console.ReadLine();
        }

        static void PrintMenu()
        {
            Console.WriteLine("ENTER AN OPTION:");
            Console.WriteLine("\t 1. ANALLIZE INTELLIGENCE - identify the terrorist with the most reports");
            Console.WriteLine("\t 2. ATTACK AVAILABLITY - show all the available units for attack and their current ammo");
            Console.WriteLine("\t 3. TARGETS PRIORITIZATION - identify the terrorist by quality rating");
            Console.WriteLine("\t 4. ATTACK - select an attack unit by the location of the terrorist");
        }


        static void most_report_terrorist_Mannager_opt1()
        {
            int temp_count = 0;
            
            foreach(Terrorist terrorist in DB.TerroristMSG.Keys)
            {
                if (DB.TerroristMSG[terrorist].Count > temp_count)
                {
                    temp_count = DB.TerroristMSG[terrorist].Count;
                    most_report_terrorist_opt1 = terrorist;
                }
            }
        }

        static void AvailableUnits_Mannager_opt1()
        {
            List<AUnit> availableUnit = availableUnits();
            foreach (AUnit unit in availableUnit)
            {
                Print(unit);
            }
        }


        static List<AUnit> availableUnits()
        {
            List<AUnit> availableUnit = new List<AUnit>();
            foreach(AUnit unit in DB.UnitsLst)
            {
                if (unit.Available)
                {
                    availableUnit.Add(unit);
                }
            }
            return availableUnit;
        }
    }
}
