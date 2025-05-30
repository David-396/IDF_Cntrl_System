﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Cntrl_System.DataBase;
using IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj.Units.Intelligence;
using IDF_Cntrl_System.OBJECTS.Person;
using IDF_Cntrl_System.OBJECTS.Unit;
using IDF_Cntrl_System.ValidateInput;
using IDF_Cntrl_System.OBJECTS;

namespace IDF_Cntrl_System.Menu
{
    static class MenuMannager
    {
        public static string FirstMenuOption;

        public static Terrorist most_report_terrorist_opt1 = null;
        private static Terrorist most_Dangours_terrorist_opt3 = null;

        public static Terrorist TerroristToKill;
        public static Terrorist TerroristToKill_Location;
        public static AUnit UnitToAttack;

        public static bool Exit = false;

        public static void Run()
        {
            while (!Exit)
            {
                FirstMenu();
                SwitchCaseFirstMenu(FirstMenuOption);
            }
        }


        // Exit option
        static void ExitOpt()
        {
            Console.WriteLine("bye");
            Exit = true;
        }


        // first menu
        public static void PrintMenu()
        {
            Console.WriteLine("ENTER AN OPTION:");
            Console.WriteLine("\t 1. ANALLIZE INTELLIGENCE - identify the terrorist with the most reports");
            Console.WriteLine("\t 2. ATTACK AVAILABLITY - show all the available units for attack and their current ammo");
            Console.WriteLine("\t 3. TARGETS PRIORITIZATION - identify the terrorist by quality rating");
            Console.WriteLine("\t 4. ATTACK - select an attack unit by the location of the terrorist\n\n");
            Console.WriteLine("5. EXIT.");
        }

        public static string GetOption()
        {
            return Console.ReadLine();
        }


        //option 1 mannager
        public static void most_report_terrorist_Mannager_opt1()
        {
            most_report_terrorist_opt1 = most_reported_terrorist();
            most_report_terrorist_opt1.Print();
        }
        public static Terrorist most_reported_terrorist()
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
        public static void AvailableUnits_Mannager_opt2()
        {
            List<AUnit> availableUnit = availableUnits();
            foreach (AUnit unit in availableUnit)
            {
                unit.Print();
            }
        }

        public static List<AUnit> availableUnits()
        {
            List<AUnit> availableUnits = new List<AUnit>();
            foreach(AUnit unit in TempDB.IDFUnits_opt24)
            {
                if (unit.Available)
                {
                    availableUnits.Add(unit);
                }
            }
            return availableUnits;
        }

        // option 3
        static void Most_Dangours_Terrorist_Mannager_opt3()
        {
            Terrorist most = Most_Dangours_Terrorist_();
            most.Print();
        }
        static Terrorist Most_Dangours_Terrorist_()
        {
            Terrorist mostDangours = null;

            double temp = 0;

            foreach (var key in TempDB.TerroristMSG_op13)
            {
                var terrorist = key.Key;
                var msg = key.Value;

                double Percentge = 1.0 - (5 - msg[msg.Count - 1].Confindende) * 0.15;

                double total = msg[msg.Count - 1].Confindende +
                             terrorist.DangerRank * terrorist.Weapon.Sum(types => (int)types);

                double calculate = total * Percentge;

                if (calculate > temp)
                {
                    temp = calculate;
                    mostDangours = terrorist;
                }
            }
            return mostDangours;    
        }



        //first menu
        static void FirstMenu()
        {
            bool getAgain = true;
            do
            {
                PrintMenu();
                FirstMenuOption = GetOption();
                if (ValidateOption.Validate("1", "2", "3", "4", "5", FirstMenuOption))
                {
                    getAgain = false;
                }
            } while (getAgain);
        }

        // switch case for the first menu
        public static void SwitchCaseFirstMenu(string option)
        {
            switch (option)
            {
                case "1":
                    most_report_terrorist_Mannager_opt1();
                    break;
                case "2":
                    AvailableUnits_Mannager_opt2();
                    break;
                case "3":
                    Most_Dangours_Terrorist_Mannager_opt3();
                    break;
                case "4":
                    SelectAndKillMannager_opt4();
                    break;
                case "5":
                    ExitOpt();
                    break;
            }
        }



        // option 4
        static void SelectAndKillMannager_opt4()
        {

        }

        // switch case for second menu
        public static void SwitchCase_Menu2(string option)
        {
            switch (option)
            {
                case "1":
                    most_report_terrorist_opt1.Print();
                    break;
                case "2":
                    most_Dangours_terrorist_opt3.Print();
                    break;
                case "3":
                    GetNewTerorist();
                    break;
                case "4":
                    ExitOpt();
                    break;
            }
        }

        // second menu
        static void SelectTerroristMenu()
        {
            most_report_terrorist_opt1 = most_report_terrorist_opt1 != null ? most_report_terrorist_opt1 : most_reported_terrorist();
            most_Dangours_terrorist_opt3 = most_Dangours_terrorist_opt3 != null ? most_Dangours_terrorist_opt3 : Most_Dangours_Terrorist_();
            Console.WriteLine($"select the terrorist:\n" +
                $"\t 1. most reported terrorist : {most_report_terrorist_opt1.Name}\n" +
                $"\t 2. most dangerous terrorist : {most_Dangours_terrorist_opt3.Name}\n" +
                $"\t 3. other\n\n" +
                $"4.EXIT ");
        }


        // option 3 - another terrorist
        static void GetNewTerorist()
        {
            bool get_again = true;
            do
            {
                Console.WriteLine("enter the name of the terrorist: ");
                string TerName = Console.ReadLine();
                foreach(Terrorist terrorist in TempDB.TerroristMSG_op13.Keys)
                {
                    if(terrorist.Name == TerName)
                    {
                        TerroristToKill = terrorist;
                        Console.WriteLine($"terrorist - {terrorist.Name} found");
                        get_again = false;
                        terrorist.Print();
                        Console.WriteLine("Search for an appropriate unit..");
                        return;
                    }
                }
                Console.WriteLine($"terrorist {TerName} not found");
            } while( get_again );
        }


        static bool SelectAttackUnit()
        {
            Terrorist terrorist = TerroristToKill;
            List<AUnit> availableUnitsLST = availableUnits();

            foreach(AUnit unit in availableUnitsLST)
            {
                if(unit.EfficientVS == terrorist.Location && unit.Available && unit.Ammo > 0)
                {
                    UnitToAttack = unit;
                    unit.Print();
                    return true;
                }
            }
            Console.WriteLine("an appropriate unit not found. please try again later.");
            return false;
        }

        static void AcceptAttackPrint()
        {
            Console.WriteLine("approved?" +
                "1.YES" +
                "2. NO");
        }
        



    }
}
