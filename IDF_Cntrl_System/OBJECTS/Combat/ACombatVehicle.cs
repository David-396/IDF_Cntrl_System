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
        public CombatType CombatType { get; }
        public Dictionary<WeaponTypes, AmmoCapacity> SelfWeapons { get; }
        public List<StructureType> EfficientVS { get; }
        public int FuelRemain { get; set; }
        public int  AttacksRemain { get; }
        public int  MaxAttacks { get; }


        protected ACombatVehicle(CombatType CombatType, Dictionary<WeaponTypes, AmmoCapacity> SelfWeapons,
            List<StructureType> efficientVS, int attacksRemain, int maxAttacks, int fuelRemain = 100)
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
        public virtual void Attack(Terrorist terrorist)
        {
            Console.WriteLine($"{this.CombatType} attacking {terrorist.Name}");
            terrorist.UpdateStatus();
        }
    }
}
