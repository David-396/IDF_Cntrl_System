using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Cntrl_System.DataBase;
using IDF_Cntrl_System.OBJECTS.Person;
using IDF_Cntrl_System.OBJECTS.Unit;

namespace IDF_Cntrl_System.Menu
{
    static class MenuMannager
    {
        static string option;

        static Terrorist most_report_terrorist_opt1 = null;


        static void PrintMenu()
        {
            Console.WriteLine("ENTER AN OPTION:");
            Console.WriteLine("\t 1. ANALLIZE INTELLIGENCE - identify the terrorist with the most reports");
            Console.WriteLine("\t 2. ATTACK AVAILABLITY - show all the available units for attack and their current ammo");
            Console.WriteLine("\t 3. TARGETS PRIORITIZATION - identify the terrorist by quality rating");
            Console.WriteLine("\t 4. ATTACK - select an attack unit by the location of the terrorist");
        }

        static void GetOption()
        {
            option = Console.ReadLine();
        }


        //option 1 mannager
        static void most_report_terrorist_Mannager_opt1()
        {
            most_report_terrorist_opt1 = most_reported_terrorist();
            most_report_terrorist_opt1.Print();
        }
        static Terrorist most_reported_terrorist()
        {
            int temp_count = 0;
            Terrorist temp_terrorist = null;

            foreach (Terrorist terrorist in TempDB.TerroristMSG_op13.Keys)
            {
                if (TempDB.TerroristMSG_op13[terrorist].Count > temp_count)
                {
                    temp_count = TempDB.TerroristMSG_op13[terrorist].Count;
                    temp_terrorist = terrorist;
                }
            }
            return temp_terrorist;
        }



        // option 2 mannager
        static void AvailableUnits_Mannager_opt2()
        {
            List<AUnit> availableUnit = availableUnits();
            foreach (AUnit unit in availableUnit)
            {
                unit.Print();
            }
        }

        static List<AUnit> availableUnits()
        {
            List<AUnit> availableUnit = new List<AUnit>();
            foreach(AUnit unit in TempDB.IDFUnits_opt24)
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
