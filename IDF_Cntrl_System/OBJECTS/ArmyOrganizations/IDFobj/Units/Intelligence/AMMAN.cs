using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Cntrl_System.OBJECTS.Unit;
using IDF_Cntrl_System.OBJECTS.Person;

namespace IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj.Units.Intelligence
{
    internal class AMMAN : AUnit
    {
        public AMMAN(string name, int id, string type, Soldier commander, int missionID, List<Soldier> soldiers, List<Weapon> Weapons) : base(name, id, type, commander, missionID, soldiers, Weapons){ }

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
            }
            else
            {
                Console.WriteLine($"{soldier.Name} not in the unit");
            }
        }

        public override void AddWeapon(Weapon weapon)
        {
            if (!this.Weapons.Contains(weapon))
            {
                this.Weapons.Add(weapon);
            }
            else
            {
                Console.WriteLine($"{weapon.Name} is already added");
            }
        }
        public override void RemoveWeapon(Weapon weapon)
        {
            if (this.Weapons.Contains(weapon))
            {
                this.Weapons.Remove(weapon);
            }
            else
            {
                Console.WriteLine($"{weapon.Name} is not in the list");
            }
        }
    }
}
