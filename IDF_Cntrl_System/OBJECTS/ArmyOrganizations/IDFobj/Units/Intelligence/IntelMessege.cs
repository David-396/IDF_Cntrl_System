using System;
using IDF_Cntrl_System.OBJECTS.Person;
using IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj.Units.Intelligence;




namespace IDF_Cntrl_System.OBJECTS.ArmyOrganizations.IDFobj.Units.Intelligence
{
    internal class IntelMessege
    {
        protected Terrorist Terrorist;
        protected DateTime Timestamp;
        public int Confindende { get; set; }

        public IntelMessege(Terrorist terrorist, int Confindende, DateTime? timestamp = null)
        {
            

            this.Terrorist = terrorist;
            this.Timestamp = timestamp ?? DateTime.Now;
            this.Confindende = Confindende;

           
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
            CONFINDENCE MESSEGE = {this.Confindende}

            ";
                    }

        public DateTime GetTime()
        {
            return DateTime.Now;
        }
        
        public int SetConfindende(int Confindende)
        {
            this.Confindende = Confindende;
            return this.Confindende;
        }
        
        
    }
}
