using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Cntrl_System.OBJECTS.Weapons;

namespace IDF_Cntrl_System.OBJECTS.Combat
{
    internal abstract class ACombatVehicle
    {
        protected CombatType CombatType { get; }
        protected List<WeaponTypes> SelfWeapons { get; }
        protected List<string> BombType { get; }
        protected List<string> EfficientVS { get; }
        protected string ActivatedBy { get; }
        protected int FuelRemain { get; set; }
        protected int  AttacksRemain { get; }
        protected int  MaxAttacks { get; }


        protected ACombatVehicle(CombatType CombatType, List<WeaponTypes> SelfWeapons, List<string> bombType, List<string> efficientVS, string activatedBy, int attacksRemain, int maxAttacks, int fuelRemain = 100)
        {
            this.CombatType = CombatType;
            this.SelfWeapons = SelfWeapons;
            this.BombType = bombType;
            this.EfficientVS = efficientVS;
            this.ActivatedBy = activatedBy;
            this.FuelRemain = fuelRemain;
            this.AttacksRemain = attacksRemain;
            this.MaxAttacks = maxAttacks;
        }
        public abstract void Refuel();
        public abstract void UpdateFuel();
        public abstract void Attack();
    }
}
