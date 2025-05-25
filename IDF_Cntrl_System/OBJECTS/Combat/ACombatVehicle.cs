using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Cntrl_System.OBJECTS.Person;
using IDF_Cntrl_System.OBJECTS.Weapons;

namespace IDF_Cntrl_System.OBJECTS.Combat
{
    internal abstract class ACombatVehicle
    {
        protected CombatType CombatType { get; }
        protected Dictionary<WeaponTypes, AmmoCapacity> SelfWeapons { get; }
        protected List<string> EfficientVS { get; }
        protected int FuelRemain { get; set; }
        protected int  AttacksRemain { get; }
        protected int  MaxAttacks { get; }


        protected ACombatVehicle(CombatType CombatType, Dictionary<WeaponTypes, AmmoCapacity> SelfWeapons,
            List<string> efficientVS, int attacksRemain, int maxAttacks, int fuelRemain = 100)
        {
            this.CombatType = CombatType;
            this.SelfWeapons = SelfWeapons;
            this.EfficientVS = efficientVS;
            this.FuelRemain = fuelRemain;
            this.AttacksRemain = attacksRemain;
            this.MaxAttacks = maxAttacks;
        }
        public abstract void Refuel();
        public abstract void UpdateFuelAfterAttack();
        public abstract void Attack(Terrorist terrorist);
    }
}
