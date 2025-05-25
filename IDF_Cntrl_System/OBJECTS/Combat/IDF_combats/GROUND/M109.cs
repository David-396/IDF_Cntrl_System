using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Cntrl_System.OBJECTS.Weapons;

namespace IDF_Cntrl_System.OBJECTS.Combat.IDF_combats.GROUND
{
    internal class M109 : ACombatVehicle
    {
        public M109(CombatType CombatType, List<WeaponTypes> SelfWeapons, List<string> bombType, List<string> efficientVS, string activatedBy, int attacksRemain, int maxAttacks, int fuelRemain = 100)
            : base(CombatType.Artilery, SelfWeapons, bombType, efficientVS, activatedBy, attacksRemain, maxAttacks, fuelRemain) { }
    }
}
