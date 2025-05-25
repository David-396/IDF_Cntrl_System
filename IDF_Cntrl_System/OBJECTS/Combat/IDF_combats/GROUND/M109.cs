using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Cntrl_System.OBJECTS.Person;
using IDF_Cntrl_System.OBJECTS.Weapons;

namespace IDF_Cntrl_System.OBJECTS.Combat.IDF_combats.GROUND
{
    internal class M109 : ACombatVehicle
    {
        public M109(CombatType CombatType, Dictionary<WeaponTypes, AmmoCapacity> SelfWeapons,
            List<EfficientVs> efficientVS, string activatedBy, int attacksRemain, int maxAttacks, int fuelRemain = 100)
            : base(CombatType.Drone, SelfWeapons, efficientVS, activatedBy, attacksRemain, maxAttacks, fuelRemain) { }

        public override void Refuel()
        {
            this.FuelRemain = 100;
        }

        public override void UpdateFuelAfterAttack()
        {
            this.FuelRemain -= 1;
        }

        public override void Attack(Terrorist terrorist)
        {
            Console.WriteLine($"{this.CombatType} attacking {terrorist.Name}");
            terrorist.UpdateStatus();
        }

       
    }
}