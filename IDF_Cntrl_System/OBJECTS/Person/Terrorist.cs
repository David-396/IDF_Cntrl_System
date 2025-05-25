using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IDF_Cntrl_System.OBJECTS.Unit;
using IDF_Cntrl_System.OBJECTS.Weapons;

namespace IDF_Cntrl_System.OBJECTS.Person
{
    internal class Terrorist : Soldier
    {
        protected int DangerRank { get; }
        protected Tuple<int> Location {  get; }
        protected int SeniorRank {  get; }
        protected bool Status { get; set; }

        public Terrorist(string name, int age, AUnit unit, string role, int iD, AWeapon weapon, int DangerRank, Tuple<int> Location, int SeniorRank, bool Status)
            : base(name, age, unit, role, iD, weapon)
        {
            this.DangerRank = DangerRank;
            this.Location = Location;
            this.SeniorRank = SeniorRank;
            this.Status = Status;
        }

        public void UpdateStatus()
        {
            this.Status = !this.Status;
        }
    }
}
