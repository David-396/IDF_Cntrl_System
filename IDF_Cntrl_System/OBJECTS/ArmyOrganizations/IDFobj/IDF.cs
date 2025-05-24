using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IDF_Cntrl_System.OBJECTS.Person;
using IDF_Cntrl_System.OBJECTS.Unit;
using IDF_Cntrl_System.OBJECTS.ArmyOrganizations;


namespace IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj
{
    internal class IDF : ArmyOrganization
    {
        protected int HumanResource;
        protected List<AUnit> UnitsLST;

        public IDF(string Establishment, Soldier Commander, List<Soldier> SoldiersLst)
            : base(Establishment, Commander, SoldiersLst)
        {
            this.HumanResource = this.SoldiersLst.Count();
        }

        public int GetHumanResource()
        {
            return this.HumanResource;
        }
        public List<AUnit> GetUnitsLST()
        {
            return this.UnitsLST;
        }


        public bool AddUnit(AUnit unit)
        {
            if (this.UnitsLST.Contains(unit))
            {
                Console.WriteLine($"the unit {unit} is already in the list");
                return false;
            }
            this.UnitsLST.Add(unit);
            Console.WriteLine($"{unit} added to the list");
            return true;
        }

        public bool RemoveUnit(AUnit unit)
        {
            if (this.UnitsLST.Contains(unit))
            {
                this.UnitsLST.Remove(unit);
                Console.WriteLine($"{unit} removed from list");
                return true;
            }
            Console.WriteLine($"{unit} is not in the list");
            return false;
        }
    }
}
