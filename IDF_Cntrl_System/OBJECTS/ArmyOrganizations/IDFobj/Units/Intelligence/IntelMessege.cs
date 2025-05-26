using System;
using IDF_Cntrl_System.OBJECTS.Person;



namespace IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj.Units.Intelligence
{
    public class IntelMessege
    {
        protected Terrorist terrorist;
        protected DateTime timestamp;
        protected int Confindende { get; }

        public IntelMessege(Terrorist terrorist, DateTime? timesamp = null, int Confindende = 10)
        {
            this.terrorist = terrorist;
            this.timestamp = timestamp ?? DateTime.Now;
        }

        public string GetMessegeString(Terrorist terrorist)
        {
            return $@"
            === INTELLIGENCE ALERT ===
            
            TARGET: {terrorist.Name}
            STATUS: {terrorist.Status}
            ORGANIZATION: Hamas
            LOCATION: {terrorist.Location}
            TIME: {DateTime.Now:dd/MM/yyyy HH:mm}
            THREAT LEVEL: {terrorist.DangerRank}
            CONFINDENCE MESSEGE = {Confindende}

            ";
                    }

        public DateTime GetTime()
        {
            return DateTime.Now;
        }
        
        
    }
}
