using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IDF_Cntrl_System.OBJECTS.Unit;

namespace IDF_Cntrl_System.OBJECTS.Person
{
    internal class Terrorist : Soldier
    {
        protected int DangerRank;
        protected Tuple<int> Location;
        protected int SeniorRank;
        protected bool Status;

        public Terrorist(string name, int age, AUnit unit, string role, int iD, Weapon weapon, int DangerRank, Tuple<int> Location, int SeniorRank, bool Status)
            : base(name, age, unit, role, iD, weapon)
        {
            this.DangerRank = DangerRank;
            this.Location = Location;
            this.SeniorRank = SeniorRank;
            this.Status = Status;
        }

        public int GetDangerRank()
        {
            return this.DangerRank;
        }
        public Tuple<int> GetLocation()
        {
            return this.Location;
        }
        public int GetSeniorRank()
        {
            return this.SeniorRank;
        }
        public bool GetStatus()
        {
            return this.Status;
        }
    }
}
