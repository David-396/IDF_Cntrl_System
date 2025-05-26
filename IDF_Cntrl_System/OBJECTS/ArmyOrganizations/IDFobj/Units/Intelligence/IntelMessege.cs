using System;
using IDF_Cntrl_System.OBJECTS.Person;



namespace IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj.Units.Intelligence
{
    public class IntelMessege
    {
        protected Terrorist Terrorist;
        protected DateTime Timestamp;
        protected int Confindende { get; }

        public IntelMessege(Terrorist terrorist, DateTime? timestamp = null, int Confindende = 10)
        {
            this.Terrorist = terrorist;
            this.Timestamp = timestamp ?? DateTime.Now;
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
