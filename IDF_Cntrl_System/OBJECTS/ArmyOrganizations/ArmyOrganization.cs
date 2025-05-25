using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IDF_Cntrl_System.OBJECTS.Person;
using IDF_Cntrl_System.OBJECTS.Unit;

namespace IDF_Cntrl_System.OBJECTS.ArmyOrganizations
{
    internal abstract class ArmyOrganization
    {
        protected string Establishment {  get; }
        protected Soldier Commander { get; }
        protected int HumanResource { get; set; }
        protected List<AUnit> UnitsLST {  get; }
        protected List<Soldier> SoldiersLst { get; }

        public ArmyOrganization(string Establishment, Soldier Commander, int HumanResource, List<AUnit> UnitsLST)
        {
            this.Establishment = Establishment;
            this.Commander = Commander;
            this.HumanResource = HumanResource;
            this.UnitsLST = UnitsLST;
        }

        public abstract void UpdateHumanResource();
    }
}
