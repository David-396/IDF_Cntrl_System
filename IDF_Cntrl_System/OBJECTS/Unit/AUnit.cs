using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IDF_Cntrl_System.OBJECTS.Person;

namespace IDF_Cntrl_System.OBJECTS.Unit
{
    internal abstract class AUnit
    {
        protected string Name;
        protected int ID;
        protected string Type;
        protected Soldier Commander;
        protected int MissionID;
        protected List<Soldier> Soldiers;
        protected List<Weapon> Weapons;

        public AUnit(string name, int id, string type, Soldier commander, int missionID, List<Soldier> soldiers, List<Weapon> Weapons)
        {
            this.Name = name;
            this.ID = id;
            this.Type = type;
            this.Commander = commander;
            this.MissionID = missionID;
            this.Soldiers = soldiers;
            this.Weapons = Weapons;
        }

        public string GetName()
        {
            return this.Name;
        }
        public int GetID()
        {
            return this.ID;
        }
        public string GetType()
        {
            return this.Type;
        }
        public Soldier GetCommander()
        {
            return this.Commander;
        }
        public int GetMissionID()
        {
            return this.MissionID;
        }
        public List<Soldier> GetSoldiers()
        {
            return this.Soldiers;
        }
        public List<Weapon> GetWeapons()
        {
            return this.Weapons;
        }

        public abstract bool AddSoldier(Soldier soldier);
        public abstract bool  RemoveSoldier(Soldier soldier);
    }
}