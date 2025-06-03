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
        protected string Role { get; }
        protected int ID {  get; }
        
        public List<WeaponTypes> Weapon { get; } 

        public Soldier(string name, int age, string role, int iD, List<WeaponTypes> weapon) : base(name, age)
        {
            this.Role = role;
            this.ID = iD;
            this.Weapon = weapon;
        }

        public override void Print()
        {
            base.Print();
            Console.Write($", role: {this.Role} , id: {this.ID} , weapon: {this.Weapon} ");
        }

        public virtual void AddWeapon(WeaponTypes weapon)
        {
            this.Weapon.Add(weapon);
        }
    }
}
