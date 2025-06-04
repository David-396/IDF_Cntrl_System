using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Cntrl_System.OBJECTS.Weapons
{
    internal abstract class AWeapon
    {
        protected WeaponTypes WeaponType {  get; }
        protected StructureType EfficientVS {  get; }
        protected int CurrentAmmo { get; }
        protected int AmmoLeft { get; set; }
        protected AmmoCapacity MaxAmmo { get; }
        

        public AWeapon(WeaponTypes weaponType, StructureType efficientVS, int CurrentAmmo, int ammoLeft, AmmoCapacity MaxAmmo)
        {
            this.WeaponType = weaponType;
            this.EfficientVS = efficientVS;
            this.CurrentAmmo = CurrentAmmo;
            this.AmmoLeft = ammoLeft;
            this.MaxAmmo = MaxAmmo;
        }

        public virtual void Attack(int ammoUsed)
        {
            if (this.AmmoLeft == 0) ReAmmo();
            this.AmmoLeft -= ammoUsed;
        }
        public virtual void ReAmmo()
        {
            this.AmmoLeft = (int)this.MaxAmmo;
        }

    }
}
