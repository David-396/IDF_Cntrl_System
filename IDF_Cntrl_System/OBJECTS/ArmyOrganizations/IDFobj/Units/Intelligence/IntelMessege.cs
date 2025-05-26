using IDF_Cntrl_System.OBJECTS.Person;

namespace IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj.Units.Intelligence
{
    public class IntelMessege
    {
        protected Terrorist terrorist;
        protected int timesamp;

        public IntelMessege(Terrorist terrorist, int timesamp)
        {
            this.terrorist = terrorist;
            this.timesamp = timesamp;
        }

        public string GetMessege()
        {
            return "fff ";
        }
        
    }
}
