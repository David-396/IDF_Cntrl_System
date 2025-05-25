using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IDF_Cntrl_System.OBJECTS.Person;
using IDF_Cntrl_System.OBJECTS.Weapons;
using IDF_Cntrl_System.OBJECTS.Combat;

namespace IDF_Cntrl_System.OBJECTS.Unit
{
    internal abstract class AUnit
    {
        protected string Name { get; }
        protected int ID { get; }
        protected string Type { get; }
        protected Soldier Commander { get; }
        protected int MissionID { get; }
        protected List<Soldier> Soldiers { get; }
        protected Dictionary<ACombatVehicle, AWeapon> Weapons { get; }

        public AUnit(string name, int id, string type, Soldier commander, int missionID, List<Soldier> soldiers, Dictionary<ACombatVehicle, AWeapon> Weapons)
        {
            this.Name = name;
            this.ID = id;
            this.Type = type;
            this.Commander = commander;
            this.MissionID = missionID;
            this.Soldiers = soldiers;
            this.Weapons = Weapons;
        }


        public abstract void AddSoldier(Soldier soldier);
        public abstract void  RemoveSoldier(Soldier soldier);

        public abstract void AddWeapon(AWeapon weapon);
        public abstract void RemoveWeapon(AWeapon weapon);
    }
}