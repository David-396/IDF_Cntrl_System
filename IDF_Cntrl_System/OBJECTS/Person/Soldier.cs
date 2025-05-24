using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IDF_Cntrl_System.OBJECTS.Unit;

namespace IDF_Cntrl_System.OBJECTS.Person
{
    internal class Soldier : APerson
    {
        protected AUnit Unit;
        protected string Role;
        protected int ID;
        protected Weapon Weapon;

        public Soldier(string name, int age, AUnit unit, string role, int iD, Weapon weapon) : base(name, age)
        {
            this.Unit = unit;
            this.Role = role;
            this.ID = iD;
            this.Weapon = weapon;
        }

        public AUnit GetUnit()
        {
            return this.Unit;
        }
        public string GetRole()
        {
            return this.Role;
        }
        public int GetID()
        {
            return this.ID;
        }
        public Weapon GetWeapon()
        {
            return this.weapon;
        }
    }
}
