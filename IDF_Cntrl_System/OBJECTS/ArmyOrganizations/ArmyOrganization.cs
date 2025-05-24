using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IDF_Cntrl_System.OBJECTS.Person;

namespace IDF_Cntrl_System.OBJECTS.ArmyOrganizations
{
    internal abstract class ArmyOrganization
    {
        protected string Establishment;
        protected Soldier Commander;
        protected List<Soldier> SoldiersLst;

        public ArmyOrganization(string Establishment, Soldier Commander, List<Soldier> SoldiersLst)
        {
            this.Establishment = Establishment;
            this.Commander = Commander;
            this.SoldiersLst = SoldiersLst;
        }

        public string GetEstablishment()
        {
            return this.Establishment;
        }
        public Soldier GetCommander()
        {
            return this.Commander;
        }
        public List<Soldier> GetSoldiersLst()
        {
            return this.SoldiersLst;
        }
    }
}
