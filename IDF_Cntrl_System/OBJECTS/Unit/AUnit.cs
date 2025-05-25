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
        protected Dictionary<ACombatVehicle, List<AWeapon>> Weapons { get; }

        public AUnit(string name, int id, string type, Soldier commander, int missionID, List<Soldier> soldiers, Dictionary<ACombatVehicle, List<AWeapon>> Weapons)
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

        public abstract void AddWeapon(Dictionary<ACombatVehicle, List<AWeapon>> weapon_dict);
        public abstract void RemoveWeapon(Dictionary<ACombatVehicle, List<AWeapon>> weapon_dict, bool RemoveKey = false);
    }
}