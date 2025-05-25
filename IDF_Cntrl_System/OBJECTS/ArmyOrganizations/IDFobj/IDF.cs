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
        protected List<Soldier> SoldiersLst {  get; }

        public IDF(string Establishment, Soldier Commander, int HumanResource, List<AUnit> UnitsLST, List<Soldier> soldiersLst)
            : base(Establishment, Commander, HumanResource, UnitsLST)
        {
            SoldiersLst = soldiersLst;
        }

        public override void UpdateHumanResource()
        {
            this.HumanResource = this.SoldiersLst.Count;
        }

        public void AddUnit(AUnit unit)
        {
            if (this.UnitsLST.Contains(unit))
            {
                Console.WriteLine($"the unit {unit} is already in the list");
            }
            this.UnitsLST.Add(unit);
            Console.WriteLine($"{unit} added to the list");
        }
        public void RemoveUnit(AUnit unit)
        {
            if (this.UnitsLST.Contains(unit))
            {
                this.UnitsLST.Remove(unit);
                Console.WriteLine($"{unit} removed from list");
            }
            Console.WriteLine($"{unit} is not in the list");
        }
    }
}
