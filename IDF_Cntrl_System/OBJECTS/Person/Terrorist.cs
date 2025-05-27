using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj.Units.Intelligence;
using IDF_Cntrl_System.OBJECTS.Enums;
using IDF_Cntrl_System.OBJECTS.Unit;
using IDF_Cntrl_System.OBJECTS.Weapons;

namespace IDF_Cntrl_System.OBJECTS.Person
{
    internal class Terrorist : Soldier
    {
        public int DangerRank { get; set; }
        public LocationEnum Location {  get; set; }
        public int SeniorRank {  get; set; }
        
        public string Status { get; set; }

        public Terrorist(string name, int age, AUnit unit, string role, int iD, List<WeaponTypes> weapon, int DangerRank, LocationEnum Location, int SeniorRank, bool Status)
            : base(name, age, unit, role, iD, weapon)
        {
            this.DangerRank = DangerRank;
            this.Location = Location;
            this.SeniorRank = SeniorRank;
            this.Status = Status ? "live" : "dead";
        }

        public void UpdateStatus()
        
        {
            this.Status = "dead";
        }

        public override void Print()
        {
            base.Print();
            Console.Write($", danger rank: {this.DangerRank} , location:{this.Location} , senior rank: {this.SeniorRank} , status: {this.Status} \n");
        }

        public override void AddWeapon(WeaponTypes weapon)
        {
            this.Weapon.Add(weapon);
        }
    }
}
