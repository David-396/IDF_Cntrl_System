using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Cntrl_System.OBJECTS.Weapons;
using IDF_Cntrl_System.OBJECTS.Person;

namespace IDF_Cntrl_System.OBJECTS.Combat.IDF_combats.AIR
{
    internal class F16 : ACombatVehicle
    {
        public F16(CombatType CombatType, List<WeaponTypes> SelfWeapons, List<string> bombType, List<string> efficientVS, string activatedBy, int attacksRemain, int maxAttacks, int fuelRemain = 100)
            : base(CombatType.AirCraft, SelfWeapons, bombType, efficientVS, activatedBy, attacksRemain, maxAttacks, fuelRemain) { }

        public override void Refuel()
        {
            this.FuelRemain = 100;
        }

        public override void UpdateFuel()
        {
            this.FuelRemain -= 10;
        }

        public override void Attack(Terrorist terrorist)
        {
            Console.WriteLine($"{this.CombatType} attacking {terrorist.Name}");
            terrorist.UpdateStatus();
        }

        public void GetBackToBase()
        {
            Console.WriteLine($"{this.CombatType} back to base");
        }
    }
}
