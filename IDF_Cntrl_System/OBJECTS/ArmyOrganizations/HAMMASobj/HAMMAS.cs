using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IDF_Cntrl_System.OBJECTS.Person;
using IDF_Cntrl_System.OBJECTS.ArmyOrganizations;

namespace IDF_Cntrl_System.OBJECTS.ArmyOrganizations.HAMMASobj
{
    internal class Hamas : ArmyOrganization
    {
        public Hamas(string Establishment, Soldier Commander, List<Soldier> SoldiersLst) : base(Establishment, Commander, SoldiersLst){}
    }
}