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
        public enum_UnitName Name { get; }
        public int ID { get; }
        public string Type { get; }
        public Soldier Commander { get; }
        public int MissionID { get; }
        public List<Soldier> Soldiers { get; }
        public Dictionary<ACombatVehicle, List<AWeapon>> Weapons { get; }
        public bool Available { get; set; }
        public StructureType EfficientVS { get; }
        public int Ammo {  get; }


        public AUnit(enum_UnitName name, int id, string type, Soldier commander, int missionID, List<Soldier> soldiers, Dictionary<ACombatVehicle, List<AWeapon>> Weapons, bool Available = true)
        {
            this.Name = name;
            this.ID = id;
            this.Type = type;
            this.Commander = commander;
            this.MissionID = missionID;
            this.Soldiers = soldiers;
            this.Weapons = Weapons;
            this.Available = Available;
        }

        public virtual void Print()
        {
            Console.WriteLine($"unit name: {this.Name} , type: {this.Type}");

        }

        public virtual void Attack()
        {
            Console.WriteLine($"{this.Name} attacking");
            this.Available = false;
        }

        public virtual void BackToBase()
        {
            Console.WriteLine($"{this.Name} unit is back to base");
            this.Available = true;
        }

        public abstract void AddSoldier(Soldier soldier);
        public abstract void  RemoveSoldier(Soldier soldier);

        public abstract void AddWeapon(Dictionary<ACombatVehicle, List<AWeapon>> weapon_dict);
        public abstract void RemoveWeapon(Dictionary<ACombatVehicle, List<AWeapon>> weapon_dict, bool RemoveKey = false);
    }
}