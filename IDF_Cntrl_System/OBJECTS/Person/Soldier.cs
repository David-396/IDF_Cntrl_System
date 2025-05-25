using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IDF_Cntrl_System.OBJECTS.Unit;
using IDF_Cntrl_System.OBJECTS.Weapons;

namespace IDF_Cntrl_System.OBJECTS.Person
{
    internal class Soldier : APerson
    {
        protected AUnit Unit { get; }
        protected string Role { get; }
        protected int ID {  get; }
        protected AWeapon Weapon {  get; }

        public Soldier(string name, int age, AUnit unit, string role, int iD, AWeapon weapon) : base(name, age)
        {
            this.Unit = unit;
            this.Role = role;
            this.ID = iD;
            this.Weapon = weapon;
        }
    }
}
