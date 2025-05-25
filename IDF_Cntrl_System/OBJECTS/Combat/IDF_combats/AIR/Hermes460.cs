using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Cntrl_System.OBJECTS.Combat.IDF_combats.AIR
{
    internal class Hermes460 : ACombatVehicle
    {
        public Hermes460(CombatType CombatType, List<string> bombType, List<string> efficientVS, string activatedBy, int attacksRemain, int maxAttacks, int fuelRemain = 100) : base(CombatType.Drone, bombType, efficientVS, activatedBy, attacksRemain, maxAttacks, fuelRemain) { }
    }
}
