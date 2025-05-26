using System;
using IDF_Cntrl_System.OBJECTS.Person;



namespace IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj.Units.Intelligence
{
    public class IntelMessege
    {
        protected Terrorist terrorist;
        protected DateTime timesamp;
        protected int Confindende;

        public IntelMessege(Terrorist terrorist, int timesamp, int Confindende = 10)
        {
            this.terrorist = terrorist;
            this.timesamp = timesamp;
        }

        public string GetMessege(Terrorist terrorist)
        {
            return $@"
            === INTELLIGENCE ALERT ===
            
            STATUS: HIGH PRIORITY
            TARGET: {terrorist.Name}
            ORGANIZATION: Hamas
            LOCATION: {terrorist.Location}
            TIME: {DateTime.Now:dd/MM/yyyy HH:mm}
            THREAT LEVEL: {terrorist.DangerRank}
            CONFINDENCE MESSEGE = {Confindende}

            ";
                    }
        
    }
}
