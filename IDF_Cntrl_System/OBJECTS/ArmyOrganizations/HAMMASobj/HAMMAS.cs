using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IDF_Cntrl_System.OBJECTS.Person;
using IDF_Cntrl_System.OBJECTS.ArmyOrganizations;
using IDF_Cntrl_System.OBJECTS.Unit;

namespace IDF_Cntrl_System.OBJECTS.ArmyOrganizations.HAMMASobj
{
    internal class Hamas : ArmyOrganization
    {
        protected List<Terrorist> TerroristLst;

        public Hamas(string Establishment, Soldier Commander, int HumanResource, List<AUnit> UnitsLST, List<Terrorist> TerroristLst)
            : base(Establishment, Commander, HumanResource, UnitsLST)
        {
            this.TerroristLst = TerroristLst;
        }

        public override void UpdateHumanResource()
        {
            this.HumanResource = this.TerroristLst.Count;
        }
    }
}