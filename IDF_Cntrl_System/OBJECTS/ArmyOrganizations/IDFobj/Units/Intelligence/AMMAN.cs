using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Cntrl_System.OBJECTS.Unit;
using IDF_Cntrl_System.OBJECTS.Person;
using IDF_Cntrl_System.OBJECTS.Weapons;
using IDF_Cntrl_System.OBJECTS.Combat;
using IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj;


namespace IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj.Units.Intelligence
{
    internal class Amman : AUnit
    {
        public Amman(enum_UnitName name, int id, string type, Soldier commander, int missionID,
        List<Soldier> soldiers, Dictionary<ACombatVehicle, List<AWeapon>> Weapons, bool Available = true)

            : base(name, id, type, commander, missionID, soldiers, Weapons){ }

        public override void AddSoldier(Soldier soldier)
        {
            if (!this.Soldiers.Contains(soldier))
            {
                this.Soldiers.Add(soldier);
            }
            else
            {
                Console.WriteLine($"{soldier.Name} is already in the unit");
            }
        }
        public override void RemoveSoldier(Soldier soldier)
        {
            if (this.Soldiers.Contains(soldier))
            {
                this.Soldiers.Remove(soldier);
                //IDF.SoldiersLst.Add(soldier);
                //IDF.UpdateHumanResource();
            }
            else
            {
                Console.WriteLine($"{soldier.Name} not in the unit");
            }
        }

        public override void AddWeapon(Dictionary<ACombatVehicle, List<AWeapon>> weapon_dict)
        {
            foreach (ACombatVehicle key in weapon_dict.Keys)
            {
                if (this.Weapons.ContainsKey(key))
                {
                    foreach (AWeapon val in weapon_dict[key])
                    {
                        if (!this.Weapons[key].Contains(val))
                        {
                            this.Weapons[key].Add(val);
                        }
                    }
                }
                else
                {
                    this.Weapons[key] = weapon_dict[key];
                }
            }
        }
        public override void RemoveWeapon(Dictionary<ACombatVehicle, List<AWeapon>> weapon_dict, bool RemoveKey = false)
        {
            foreach (ACombatVehicle key in weapon_dict.Keys)
            {
                if (this.Weapons.ContainsKey(key))
                {
                    if (RemoveKey)
                    {
                        this.Weapons.Remove((key));
                    }
                    else
                    {
                        foreach (AWeapon weapon in weapon_dict[key])
                        {
                            foreach(AWeapon orgnl_weapon in this.Weapons[key])
                            {
                                if (orgnl_weapon == weapon)
                                {
                                    this.Weapons[key].Remove(orgnl_weapon);
                                }
                            }
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine($"{key.GetType()} not in the list");
                }
            }

        }
    }
}
